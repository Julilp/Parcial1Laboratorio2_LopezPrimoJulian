using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class Pasaporte 
    {
        private DateTime fechaDeVencimiento;
        private DateTime fechaDeEmision;
        private string nacionalidad;
        private int numeroDePasaporte;

        public Pasaporte(DateTime fechaDeVencimiento, DateTime fechaDeEmision, string nacionalidad, int numeroDePasaporte)
        {
            this.fechaDeVencimiento = fechaDeVencimiento;
            this.fechaDeEmision = fechaDeEmision;
            this.nacionalidad = nacionalidad;
            this.numeroDePasaporte = numeroDePasaporte;
        }
        public Pasaporte()
        {
            this.fechaDeVencimiento = new DateTime();
            this.fechaDeEmision = new DateTime();
            this.nacionalidad = "";
            this.numeroDePasaporte = 0;
        }

        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; set => fechaDeVencimiento = value; }
        public DateTime FechaDeEmision { get => fechaDeEmision; set => fechaDeEmision = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int NumeroDePasaporte { get => numeroDePasaporte; set => numeroDePasaporte = value; }

   
    }
}
