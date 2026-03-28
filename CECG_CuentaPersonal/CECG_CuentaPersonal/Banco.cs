using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication4
{
    class Banco
    {
        //Lista de cuentas bancarias
        public List<CuentaBancaria> Cuentas { get; set; }
        //Mensajes a devolver para la IU (Interfaz de Usuario)
        public String Mensaje { get; set; }

        //Constructor de la clase
        public Banco()
        {
            //Inicializar la lista de cuentas para poderla usar.
            Cuentas = new List<CuentaBancaria>();
        }

        /// <summary>
        /// Permite agregar una cuenta al banco
        /// </summary>
        /// <param name="cuenta">Cuenta a agregar</param>
        public void RegistrarCuenta(CuentaBancaria cuenta)
        {
            //Si al buscar la cuenta por su número me devuelve distinto de nulo
            //significa que ya existe y por lo tanto no la puedo agregar
            if(BuscarCuenta(cuenta.ConsultarNumero())!=null)
            {
                //Guardar el mensaje de que no se pudo realizar
                Mensaje = "El Número de Cuenta ya existe. Intente otra vez.";
                return;//Regresar sin continuar en este método
            }
            //A la lista de cuentas agregamos la cuenta
            Cuentas.Add(cuenta);
            //Indicar que la acción se realizó.
            Mensaje = "Cuenta agregada con éxito.";
        }

        /// <summary>
        /// Permite buscar una cuenta para usarla
        /// </summary>
        /// <param name="NumeroCuenta">Numero de Cuenta</param>
        /// <returns></returns>
        public CuentaBancaria BuscarCuenta(int NumeroCuenta)
        {
            //Se recorre la lista de cuentas de una en una
            foreach (var item in Cuentas)
            {
                //Si el número de la cuenta coincide con el que se busca
                if (item.ConsultarNumero() == NumeroCuenta)
                {
                    //Se devuelve la cuenta
                    return item;
                }
            }
            //Cuando se termino la lista y se llegó a este punto
            //entonces no se encontró coincidencia
            Mensaje = "No se pudo encontrar la cuenta indicada.";
            //Se devuelve null
            return null;
        }

        public bool GuardarCuentas()
        {
            try
            {
                //Objeto para concatenar las cuentas existentes
                StringBuilder builder = new StringBuilder();
                //Recorrer la lista de cuentas para concatenarlas
                foreach (CuentaBancaria item in Cuentas)
                {
                    //Tomar cada uno de los datos de la cuenta para concatenar
                    builder.Append(item.ConsultarNumero() + ","+ item.ConsultarTitular() +"," + item.ConsultarSaldo());
                    //Agregar un salto de linea
                    builder.AppendLine();
                }
                //Crear un archivo y guardar los datos
                System.IO.File.WriteAllText("BANCASTOR.csv", builder.ToString());
                //Devolver true, que significará éxito al crear el archivo.
                return true;
            }
            catch (Exception ex)
            {
                //Guardar el error a mostrar
                Mensaje = "Error al crear el archivo con la información de las cuentas.";
                //+ Environment.NewLine +
                 //   "Detalle: " + ex.StackTrace;
                return false;
            }
        }

        public bool CargarCuentas()
        {
            try
            {
                //Leer el archivo de las cuentas bancarias
                List<String> datos = File.ReadLines("BANCASTOR.csv").ToList();
                foreach (var item in datos)
                {
                    //Split sirve para separar una cadena en varias partes usando un caracter específico
                    String[] datoscuenta = item.Split(new char[] { ',' });
                    //Si el arreglo tiene datos entonces es cuenta válida
                    if(datos.Count > 0)
                    {
                        //Crear un objeto cuenta
                        CuentaBancaria cuenta = new CuentaBancaria(
                                datoscuenta[1],                 //Titular
                                float.Parse(datoscuenta[2]),    //Saldo
                                int.Parse(datoscuenta[0])       //Numero
                            );
                        //Agregar la cuenta a la lista
                        Cuentas.Add(cuenta);
                        cuenta.CargarHistorial();
                    }
                }
                //Devolver true porque la operación se pudo realizar
                return true;
            }
            catch (Exception)
            {
                Mensaje = "Error al cargar la lista de cuentas";
                //Se devuelve null
                return false;
            }
        }
    }
}
