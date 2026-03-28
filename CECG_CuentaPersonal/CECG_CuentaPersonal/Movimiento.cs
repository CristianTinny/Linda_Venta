using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Movimiento
    {
        //Propiedades para llevar el control de los movimientos en la cuenta
        public DateTime FechaHora { get; set; } //La fecha y hora en que se realizó
        public String Tipo { get; set; } //Para el tipo, indicando si fue CARGO o ABONO
        public float Monto { get; set; } //La cantidad que se depositó o se retiró
    }
}
