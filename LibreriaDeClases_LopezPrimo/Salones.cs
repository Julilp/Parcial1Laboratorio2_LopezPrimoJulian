using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class Salones
    {
     public int Pileta=1;
     public int SalaDeMasajes=0;
     public int Casino=0;
     public int BarraDeTragos=0;
     public int PlayRoom=0;
     public int Spa=0;
     public int Gimnasio=0;
     public int PistaDeBaile=0;
     public int Cine=0;
     public int SalonDeLectua=0;

        public Salones(int pileta, int salaDeMasajes, int casino, int barraDeTragos, int playRoom, int spa, int gimnasio, int pistaDeBaile, int cine, int salonDeLectua)
        {
            this.Pileta = pileta;
            this.SalaDeMasajes = salaDeMasajes;
            this.Casino = casino;
            this.BarraDeTragos = barraDeTragos;
            this.PlayRoom = playRoom;
            this.Spa = spa;
            this.Gimnasio = gimnasio;
            this.PistaDeBaile = pistaDeBaile;
            this.Cine = cine;
            this.SalonDeLectua = salonDeLectua;
        }
        public Salones()
        {
            this.Pileta = 0;
            this.SalaDeMasajes = 0;
            this.Casino = 0;
            this.BarraDeTragos = 0;
            this.PlayRoom = 0;
            this.Spa = 0;
            this.Gimnasio = 0;
            this.PistaDeBaile = 0;
            this.Cine = 0;
            this.SalonDeLectua = 0;
        }
        /// <summary>
        /// suma todos los tipos diferentes de salones para saber exactamente cuantos salones hay en cada crucero
        /// </summary>
        /// <param name="crucero"></param>
        /// <returns>devuelve un int con la totalidad de salones en el crucero</returns>
        public static int CantidadDeSalones(Cruceros crucero)
        {
            int retorno=0;
            retorno = crucero.SalonesExistentes.BarraDeTragos + crucero.SalonesExistentes.Casino + crucero.SalonesExistentes.Cine + crucero.SalonesExistentes.Gimnasio + crucero.SalonesExistentes.Pileta + crucero.SalonesExistentes.PistaDeBaile + crucero.SalonesExistentes.PlayRoom + crucero.SalonesExistentes.SalaDeMasajes + crucero.SalonesExistentes.SalonDeLectua + crucero.SalonesExistentes.Spa;
            return retorno;
        }
    }
}
