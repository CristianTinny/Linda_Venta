using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication4
{
    public class CuentaBancaria
    {
        public String Mensaje { get; set; } //Propiedad para almacenar mensajes para la IU

        private int Numero { get; set; } //Identificador único para la cuenta
        
        private String Titular { get; set; } //Get y Set indican que se trata de una propiedad

        private float Saldo { get; set; } //Las propiedades con get son de sólo lectura.
        //Si tienen get y set son de lectura y escritura
        
        private List<Movimiento> Historial { get; set; } //Controla los movimientos en la cuenta
                
        //Constructor de la clase, los parametros se le proporcionan al crear la un objeto.
        public CuentaBancaria(String NombreTitular, float SaldoInicial, int NumeroC)
        {
            //Tomar los valores recibidos para crear la cuenta nueva
            Numero = NumeroC;
            Titular = NombreTitular;
            Saldo = SaldoInicial;
            Historial = new List<Movimiento>();
        }

        //El método abonar permite incrementar el saldo de la cuenta con la cantidad indicada
        public bool Abonar(float Cantidad)
        {
            //No se pueden realizar abonos por cantidades menores a 1
            if(Cantidad<0)
            {
                Mensaje = "No se pueden realizar abonos por cantidades menores a $1.";
                //Devolver falso para indicar que no se pudo realizar la operación
                return false;
            }
            //Incrementar el saldo con la cantidad indicada
            Saldo += Cantidad;
            //Invocar al método para registrar el movimiento
            AgregarMovimiento("+ABONO+", Cantidad);
            //Devolver true cuando si se pudo realizar la operación
            return true;
        }
        //Método para agregar el movimiento realizado al historial de la cuenta.
        void AgregarMovimiento(String Tipo, float Cantidad)
        {               
            //Crear un movimiento para el abono
            Movimiento nuevo = new Movimiento();
            //Tomar la fecha y hora del sistema
            nuevo.FechaHora = DateTime.Now;
            //Especificar el tipo de movimiento
            nuevo.Tipo = Tipo;
            //Especificar el monto 
            nuevo.Monto = Cantidad;
            //Agregar el movimiento al historial
            Historial.Add(nuevo);
            //Registrar el movimiento de la cuenta en un archivo de texto
            File.AppendAllText(Numero + ".txt", nuevo.FechaHora.ToString() + "," + nuevo.Tipo + "," + nuevo.Monto + Environment.NewLine);
        }

        /// <summary>
        /// El método devuelve el titular y el saldo de la cuenta
        /// </summary>
        public String ConsultarEstado()
        {
            //Concatenar los datos de la cuenta
            return "Numero de Cuenta: " + Numero + Environment.NewLine + 
                "Titular: " + Titular + Environment.NewLine + 
                "Saldo: " + Saldo;
        }

        /// <summary>
        /// Mostrar el historial de movimientos en la cuenta
        /// </summary>
        /// <returns>String con el resumen de movimientos.</returns>
        public String ConsultarMovimientos()
        {
            //Crear el objeto para concatenar la información de los movimientos
            StringBuilder builder = new StringBuilder();
            //Estructura para recorrer la lista de movimientos
            foreach (var item in Historial) //item hace referencia a cada elemnto en la lista
            {
                //Concatenar los valores de cada movimiento
                builder.Append("Fecha: " + item.FechaHora.ToString("dd/MM/yyyy HH:mm:ss") 
                    + " Tipo: " + item.Tipo + "  Monto: " + item.Monto.ToString("$0.00"));
                //Agregar un salto de linea
                builder.AppendLine();
            }
            //Devolver la información en una sola cadena
            return builder.ToString();
        }

        //El método permite disminuir el saldo de la cuenta con la cantidad indicada
        public bool Retirar(float Cantidad)
        {
            //No se pueden realizar retiros por cantidades menores a 20
            if (Cantidad < 20)
            {
                Mensaje = "No se pueden realizar retiros por cantidades menores a $20.";
                //Devolver falso para indicar que no se pudo realizar la operación
                return false;
            }
            //No se pueden realizar retiros por cantidades mayores al saldo o que dejen menos de $1 en el saldo
            if (Cantidad > (Saldo - 1))
            {
                Mensaje = 
                    "No se puede realizar el retiro porque no tiene fondos suficientes o el saldo final sería menor a $1.";
                //Devolver falso para indicar que no se pudo realizar la operación
                return false;
            }
            //Saldo = Saldo - Cantidad; //Operación para disminuir el saldo
            Saldo -= Cantidad;
            //Invocar al método para registrar el movimiento
            AgregarMovimiento("-CARGO-", Cantidad);
            //Devolver true cuando si se pudo realizar la operación
            return true;
        }

        /// <summary>
        /// Para consultar el número de la cuenta
        /// </summary>
        /// <returns></returns>
        public int ConsultarNumero()
        {
            //Devuelve el número de la cuenta
            return Numero;
        }

        public String ConsultarTitular()
        {
            //Devuelve el nombre del titular
            return Titular;
        }

        public float ConsultarSaldo()
        {
            //Devuelve el saldo de la cuenta
            return Saldo;
        }

        public void CargarHistorial()
        {
            //Verificar si el archivo de movimientos para la cuenta si existe
            if (!File.Exists(Numero + ".txt"))
                return; //En caso de que no exista el archivo, se regresa desde aqui.
            //Leemos el archivo de los movimientos
            List<String> lineas = File.ReadLines(Numero + ".txt").ToList();
            //Recorremos la lista de lineas
            foreach (String item in lineas)
            {
                //Separar los datos del movimiento en el arreglo datosMovimiento
                String[] datosMovimiento = item.Split(new char[] { ',' });
                //Verificar si el arreglo tiene datos
                if(datosMovimiento.Count() > 0)
                {
                    //
                    Movimiento movimiento = new Movimiento();
                    movimiento.FechaHora = DateTime.Parse(datosMovimiento[0]);
                    movimiento.Tipo = datosMovimiento[1];
                    movimiento.Monto = float.Parse(datosMovimiento[2]);
                    Historial.Add(movimiento);
                }
            }
        }
    }
}
