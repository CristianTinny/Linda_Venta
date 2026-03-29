// ================= IMPORTACIONES =================
const express = require('express');
const cors = require('cors');
const conexion = require('./db');

const app = express();

// ================= CONFIG =================
app.use(cors());
app.use(express.json());

// ================= RUTA PRUEBA =================
app.get('/', (req, res) => {
    res.send('Servidor funcionando 🚀');
});

// ================= LOGIN =================
app.post('/login', (req, res) => {

    const { correo, password } = req.body;

    const query = 'SELECT * FROM usuarios WHERE correo = ? AND password = ?';

    conexion.query(query, [correo, password], (err, result) => {

        if (err) {
            console.log(err);
            return res.json({ mensaje: 'Error en el servidor' });
        }

        if (result.length > 0) {
            res.json({ mensaje: 'Login correcto', usuario: result[0] });
        } else {
            res.json({ mensaje: 'Usuario o contraseña incorrectos' });
        }

    });
});

// ================= AGREGAR PRODUCTO =================
app.post('/productos', (req, res) => {

    const { nombre, precio, stock } = req.body;

    const query = 'INSERT INTO productos (nombre, precio, stock) VALUES (?, ?, ?)';

    conexion.query(query, [nombre, precio, stock], (err) => {

        if (err) {
            console.log(err);
            return res.json({ mensaje: 'Error al agregar producto' });
        }

        res.json({ mensaje: 'Producto agregado correctamente' });
    });
});

// ================= OBTENER PRODUCTOS =================
app.get('/productos', (req, res) => {

    conexion.query('SELECT * FROM productos', (err, result) => {

        if (err) {
            console.log(err);
            return res.json({ mensaje: 'Error al obtener productos' });
        }

        res.json(result);
    });
});

// ================= ELIMINAR =================
app.delete('/productos/:id', (req, res) => {

    const id = req.params.id;

    conexion.query('DELETE FROM productos WHERE id = ?', [id], (err) => {

        if (err) {
            console.log(err);
            return res.json({ mensaje: 'Error al eliminar' });
        }

        res.json({ mensaje: 'Producto eliminado' });
    });
});

// ================= EDITAR =================
app.put('/productos/:id', (req, res) => {

    const id = req.params.id;
    const { nombre, precio, stock } = req.body;

    const query = `
        UPDATE productos 
        SET nombre = ?, precio = ?, stock = ?
        WHERE id = ?
    `;

    conexion.query(query, [nombre, precio, stock, id], (err, result) => {

        if (err) {
            console.log(err);
            return res.json({ mensaje: 'Error al actualizar' });
        }

        res.json({ mensaje: 'Producto actualizado' });
    });
});

// ================= COMPRA =================
app.post('/comprar', (req, res) => {

    const carrito = req.body.carrito;

    carrito.forEach(item => {

        const query = 'INSERT INTO ventas (producto, precio) VALUES (?, ?)';

        conexion.query(query, [item.nombre, item.precio], (err) => {
            if (err) console.log(err);
        });

    });

    res.json({ mensaje: 'Compra realizada con éxito 🛒' });
});

// ================= PUERTO =================
app.listen(3000, () => {
    console.log('Servidor corriendo en http://localhost:3000');
});