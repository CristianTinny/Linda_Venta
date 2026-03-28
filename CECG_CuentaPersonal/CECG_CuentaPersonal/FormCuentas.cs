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
    public partial class FormCuentas : Form
    {

        public FormCuentas()
        {
            InitializeComponent();
            //Instanciando al objeto
            Bancastor = new Banco();
        }
        //Declarar el identificador para el objeto, sin instanciarlo
        public CuentaBancaria cuentaBancaria;
        //Declarar al objeto banco sin inicializar
        Banco Bancastor;
        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            //Validar que el nombre del titular no se quede vacío
            if(textBoxTitular.Text.Trim().Equals("")) //Se compara contra una cadena vacía
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("Es necesario especificar el nombre del titular.");
                //Colocar el foco en el control
                textBoxTitular.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }

            //Validar que el nombre del titular no sea demasiado corto
            if (textBoxTitular.Text.Trim().Length < 8 ) //Se compara contra una cadena vacía
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("El nombre es demasiado pequeño. Revise por favor.");
                //Colocar el foco en el control
                textBoxTitular.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }

            float Saldo;
            if(!float.TryParse(textBoxSaldoInicial.Text, out Saldo))
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("El saldo inicial no es válido. Revise por favor.");
                //Colocar el foco en el control
                textBoxSaldoInicial.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }

            if(Saldo < 50)
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("El saldo inicial debe ser de 50 o superior. Revise por favor.");
                //Colocar el foco en el control
                textBoxSaldoInicial.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }
            //Clase para generar el número de cuenta en forma aleatoria
            Random aleatorios = new Random();
            //Generar un valor entre 1000 y 999999
            int NumCuenta = aleatorios.Next(1000, 999999);
            //Instanciar la clase proporcionando los datos requeridos en el constructor
            cuentaBancaria = new CuentaBancaria(
                textBoxTitular.Text.Trim(),
                //El segundo dato debe ser float, por ello se hace la conversión
                float.Parse(textBoxSaldoInicial.Text), //Convert.ToSingle(textBoxSaldoInicial.Text)
                NumCuenta
                );
            //Agregar la cuenta al Banco
            Bancastor.RegistrarCuenta(cuentaBancaria);
            //Mostrar el mensaje de Banco
            MessageBox.Show(Bancastor.Mensaje);
            //Se muestra el estado de la cuenta en la etiqueta.
            labelInfoCuenta.Text = cuentaBancaria.ConsultarEstado();
            //Guardar las cuentas
            if (!Bancastor.GuardarCuentas())
                MessageBox.Show(Bancastor.Mensaje);
        }

        private void buttonAbonar_Click(object sender, EventArgs e)
        {
            if(cuentaBancaria == null)
            {
                MessageBox.Show("Primero debe crear la cuenta.");
                return; 
                /*Aquí return se usa para que ya no 
                 ejecute el código que 
                 se encuentra enseguida*/
            }
            float Cantidad;
            if (!float.TryParse(textBoxCantidad.Text, out Cantidad))
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("La cantidad no es válida. Revise por favor.");
                //Colocar el foco en el control
                textBoxCantidad.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }
            //Se invoca el método pasando el valor de la cantidad a abonar
            if (!cuentaBancaria.Abonar(float.Parse(textBoxCantidad.Text)))
                MessageBox.Show(cuentaBancaria.Mensaje);
            //Se muestra el estado de la cuenta en la etiqueta.
            labelInfoCuenta.Text = cuentaBancaria.ConsultarEstado();
            //Guardar las cuentas
            if (!Bancastor.GuardarCuentas())
                MessageBox.Show(Bancastor.Mensaje);
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            if (cuentaBancaria == null)
            {
                MessageBox.Show("Primero debe crear la cuenta.");
                return;
                /*Aquí return se usa para que ya no 
                 ejecute el código que 
                 se encuentra enseguida*/
            }
            float Cantidad;
            if (!float.TryParse(textBoxCantidad.Text, out Cantidad))
            {
                //Se muestra el mensaje de aviso.
                MessageBox.Show("La cantidad no es válida. Revise por favor.");
                //Colocar el foco en el control
                textBoxCantidad.Focus();
                //Se interrumpe el flujo normal de ejecución.
                return;
            }
            //Se invoca el método pasando el valor de la cantidad a retirar
            if (!cuentaBancaria.Retirar(float.Parse(textBoxCantidad.Text)))
                MessageBox.Show(cuentaBancaria.Mensaje);
            //Se muestra el estado de la cuenta en la etiqueta.
            labelInfoCuenta.Text = cuentaBancaria.ConsultarEstado();
            //Guardar las cuentas
            if (!Bancastor.GuardarCuentas())
                MessageBox.Show(Bancastor.Mensaje);
        }

        private void buttonConsultarHistorial_Click(object sender, EventArgs e)
        {
            if (cuentaBancaria == null)
            {
                MessageBox.Show("Primero debe crear la cuenta.");
                return;
                /*Dejar de ejecutar el código que se encuentra enseguida*/
            }
            textBoxHistorial.Text = cuentaBancaria.ConsultarMovimientos();
        }

        private void textBoxTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //65 ES A y el 90 es Z
            if ((int)e.KeyChar < 65 || (int)e.KeyChar > 90)
            {
                //8 ES BACKSPACE
                //32 ES ESPACIO EN BLANCO
                //127 ES SUPRIMIR
                if((int)e.KeyChar != 8 && (int)e.KeyChar != 127 && (int)e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }   
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Invocar al método para buscar la cuenta con el número
            //En este caso usamos el método BuscarCuenta con un parámetro
            cuentaBancaria = Bancastor.BuscarCuenta(int.Parse(textBoxBuscarNumero.Text));
            //Si el objeto es nulo significa que no se encontró una cuenta con ese número
            if (cuentaBancaria == null)
            {    //Mostrar el mensaje al usuario
                MessageBox.Show(Bancastor.Mensaje);
                //Limpiar la etiqueta de la cuenta bancaria
                labelInfoCuenta.Text = "";
            }
            else
                //Se muestra el estado de la cuenta en la etiqueta.
                labelInfoCuenta.Text = cuentaBancaria.ConsultarEstado();
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            //Si no se pudieron cargar las cuentas
            if (!Bancastor.CargarCuentas())
                //Mostrar mensaje
                MessageBox.Show(Bancastor.Mensaje);
        }

        private void FormCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cerrar por completo la aplicación
            Application.Exit();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
