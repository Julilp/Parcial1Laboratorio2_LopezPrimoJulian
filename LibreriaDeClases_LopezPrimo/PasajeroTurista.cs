using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class PasajeroTurista : PasajeroBase
    {
        private int pesoValija;

        public PasajeroTurista(Pasaporte pasaporteViajero, string nombre, string apellido, int edad, int pesoValija):base(nombre,apellido,edad,pasaporteViajero)
        {
            this.pesoValija = pesoValija;
        }
        /// <summary>
        /// genera un string de una linea con ciertos datos solicitados para llenar un listbox
        /// </summary>
        /// <param name="pasajeroADevolver"></param>
        /// <returns>un string de una linea</returns>
        public static string rellenarListBoxPasajerosTurista(PasajeroTurista pasajeroADevolver)
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
