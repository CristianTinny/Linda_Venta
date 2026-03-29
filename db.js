// Importamos mysql2
const mysql = require('mysql2');

// Creamos la conexión a la base de datos
const conexion = mysql.createConnection({
    host: 'localhost',     // servidor (siempre localhost en XAMPP)
    user: 'root',          // usuario por defecto de MySQL
    password: '',          // contraseña (vacía en XAMPP)
    database: 'nueva_lindaventa_cecg' // nombre de la base de datos
});

// Conectamos a la base de datos
conexion.connect((err) => {
    if (err) {
        console.log('Error de conexión: ' + err);
        return;
    }
    console.log('Conectado a MySQL 🚀');
});

// Exportamos la conexión para usarla en otros archivos
module.exports = conexion;