using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class PasajeroPremium : PasajeroBase 
    {
        private int pesoValija1;
        private int pesoValija2;

        public PasajeroPremium(Pasaporte pasaporteViajero,string nombre, string apellido, int edad, int pesoValija1, int pesoValija2) : base( nombre,  apellido,  edad,pasaporteViajero)
        {
            this.pesoValija1 = pesoValija1;
            this.pesoValija2 = pesoValija2;
        }
        /// <summary>
        /// genera un string de una linea con ciertos datos solicitados para llenar un listbox
        /// </summary>
        /// <param name="pasajeroADevolver"></param>
        /// <returns>un string de una linea</returns>
        public static string rellenarListBoxPasajerosPremium(PasajeroPremium pasajeroADevolver)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{pasajeroADevolver.nombre}   ");
            sb.AppendLine($"{pasajeroADevolver.apellido}   ");
            sb.AppendLine($"{pasajeroADevolver.edad}   ");
            sb.AppendLine($"{pasajeroADevolver.pasaporteViajero.Nacionalidad}   ");
            sb.AppendLine($"{pasajeroADevolver.pasaporteViajero.NumeroDePasaporte}   ");
            return sb.ToString();
        }
    }
}
