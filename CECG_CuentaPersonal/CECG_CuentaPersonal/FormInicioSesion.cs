using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormInicioSesion : Form
    {
        //Contador de intentos para bloquear acceso
        int Intentos = 1;
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(Intentos==4)
            {
                MessageBox.Show("No puede acceder porque lleva más de tres intentos");
                return;
            }
            Intentos++;
            if(textBoxNumero.Text.Equals("0000") && textBoxClave.Text.Equals("@dmin"))
            {
                //Instanciar el formulario de cuentas
                FormCuentas formCuentas = new FormCuentas();
                //Mostrar el nuevo formulario
                formCuentas.Show();
                //Ocultar esta ventana
                this.Hide();
                //Omitir el resto de código
                return;
            }


            //Instanciar la clase banco
            Banco banco = new Banco();
            //Cargar las cuentas existentes
            banco.CargarCuentas();
            //Buscar la cuenta con el número proporcionado
            CuentaBancaria cuenta = banco.BuscarCuenta(int.Parse(textBoxNumero.Text));
            if (cuenta == null)
            {
                MessageBox.Show("El número de cuenta o clave no es válid@.");
                return;
            }

            if (cuenta.ConsultarTitular().Equals(textBoxClave.Text))
            {
                //Instanciar el formulario de cuentas
                FormCuentas formCuentas = new FormCuentas();
                //Ocultar el panel de gestionar cuentas
                formCuentas.groupBoxGestionarCuentas.Hide();
                //Asignar la cuenta actual a la cuenta del formulariocuentas
                formCuentas.cuentaBancaria = cuenta;
                //Mover el panel de movimientos hacia arriba
                formCuentas.groupBoxMovientos.Location = new Point(12, 12);
                //Cambiar el tamaño del formulario
                formCuentas.Height = 282;
                //Mostrar el formulario recién creado
                formCuentas.Show();
                //Ocultar el formulario actual
                this.Hide();
                //MessageBox.Show("Bienvenid@. Acceso concedido.");
            }
            else
                MessageBox.Show("El número de cuenta o clave no es válid@.");

        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
