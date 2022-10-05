using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public abstract class PasajeroBase
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected Pasaporte pasaporteViajero;

        protected PasajeroBase(string nombre, string apellido, int edad, Pasaporte pasaporteViajero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.pasaporteViajero = new Pasaporte();
            this.pasaporteViajero = pasaporteViajero;
        }
    }

}
