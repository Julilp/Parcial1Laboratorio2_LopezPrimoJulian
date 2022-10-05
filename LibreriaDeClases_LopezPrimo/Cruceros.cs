using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class Cruceros
    {
        private string idCrucero;
        private string nombreCrucero;
        private int cantidadCamarotes;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private int cantidadSalones;
        private int capacidadBodega;
        private string disponibilidad;
        private Salones salonesExistentes;
        public Cruceros()
        {
        this.idCrucero ="";
        this.nombreCrucero="";
        this.cantidadCamarotes = 0;
        this.cantidadCamarotesPremium=0;
        this.cantidadCamarotesTurista=0;
        this.cantidadSalones=0;
        this.capacidadBodega=0;
        this.disponibilidad="";
        this.salonesExistentes=new Salones();
        }

        public Cruceros(string idCrucero, string nombreCrucero, int cantidadCamarotes, int cantidadCamarotesPremium, int cantidadCamarotesTurista, int cantidadSalones, int capacidadBodega, string disponibilidad, Salones salonesExistentes)
        {
            this.idCrucero = idCrucero;
            this.nombreCrucero = nombreCrucero;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadCamarotesPremium = cantidadCamarotesPremium;
            this.cantidadCamarotesTurista = cantidadCamarotesTurista;
            this.cantidadSalones = cantidadSalones;
            this.capacidadBodega = capacidadBodega;
            this.disponibilidad = disponibilidad;
            this.salonesExistentes = salonesExistentes;
        }

        public List<Salones> listOfSalones = new List<Salones>();

        public string IdCrucero { get => idCrucero; set => idCrucero = value; }
        public string NombreCrucero { get => nombreCrucero; set => nombreCrucero = value; }
        public int CantidadCamarotesPremium { get => cantidadCamarotesPremium; set => cantidadCamarotesPremium = value; }
        public int CantidadCamarotesTurista { get => cantidadCamarotesTurista; set => cantidadCamarotesTurista = value; }
        public int CantidadSalones { get => cantidadSalones; set => cantidadSalones = value; }
        public int CapacidadBodega { get => capacidadBodega; set => capacidadBodega = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public Salones SalonesExistentes { get => salonesExistentes; set => salonesExistentes = value; }
        public int CantidadCamarotes { get => cantidadCamarotes; set => cantidadCamarotes = value; }


        /// <summary>
        /// valida que el crucero indicado por el nombre no este ocupado el dia pasado por parametro
        /// </summary>
        /// <param name="nombreCrucero">nombre del crucero a validar</param>
        /// <param name="FechaSalida">dia que queremos ocupar ese crucero</param>
        /// <returns>devuelve true o false dependiendo el resultado</returns>
        public static bool ValidarDias(string nombreCrucero,DateTime FechaSalida)
        {
            bool retorno = true;
            DateTime fechaInicio = new DateTime();
            DateTime FechaFinal = new DateTime();
            int duracion;
            foreach (Viajes item in Listas.listOfViajes)
            {
                if(item.Crucero.nombreCrucero == nombreCrucero )
                {
                    fechaInicio = item.FechaInicio;
                    duracion = item.DuracionViaje;
                    duracion = duracion / 24;
                    FechaFinal = fechaInicio.AddDays(duracion);
                    if(DateTime.Compare(fechaInicio, FechaSalida)<=0 && DateTime.Compare(FechaFinal, FechaSalida)>=0)
                    {
                        retorno = false;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// identifica un crucero por su nombre y lo devuelve
        /// </summary>
        /// <param name="nombreCrucero"></param>
        /// <returns>devuelve el crucero identificado</returns>
        public static Cruceros DevolverCrucero(string nombreCrucero)
        {
            Cruceros cruceroADevolver = new Cruceros();
            foreach (Cruceros item in Listas.listOfCruceros)
            {
                if (item.nombreCrucero == nombreCrucero)
                {
                    cruceroADevolver = item;
                }
            }
            return cruceroADevolver;
        }
        /// <summary>
        /// harcodea los datos que se obtienen calculando en los cruceros ya creados
        /// </summary>
        /// <param name="cruceroACompletar"></param>
        public static void HarcodeoCruceros(Cruceros cruceroACompletar)
        {
            cruceroACompletar.cantidadCamarotesPremium = cruceroACompletar.cantidadCamarotes * 35 /100;
            cruceroACompletar.cantidadCamarotesTurista = cruceroACompletar.cantidadCamarotes- cruceroACompletar.cantidadCamarotesPremium;
            cruceroACompletar.cantidadSalones = Salones.CantidadDeSalones(cruceroACompletar);
        }

    }
}
