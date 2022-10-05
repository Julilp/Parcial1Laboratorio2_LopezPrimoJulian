using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class Viajes
    {
        private Cruceros crucero;
        private string ciudadPartida;
        private string ciudadDestino;
        private DateTime fechaInicio;
        private int costoTurista;
        private int costoPremium;
        private int duracionViaje;
        private int cantidadVendidaTotal;
        private int vendidoPremium;
        private int vendidoTurista;
        private int pesoBodegaOcupada;
        private int enumRegional;
        private int idViaje;
        private int camarotesDisponibles;
        private string estado;


        public Cruceros Crucero { get => crucero; set => crucero = value; }
        public string CiudadPartida { get => ciudadPartida; set => ciudadPartida = value; }
        public string CiudadDestino { get => ciudadDestino; set => ciudadDestino = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int CostoTurista { get => costoTurista; set => costoTurista = value; }
        public int CostoPremium { get => costoPremium; set => costoPremium = value; }
        public int DuracionViaje { get => duracionViaje; set => duracionViaje = value; }
        public int CantidadVendidaTotal { get => cantidadVendidaTotal; set => cantidadVendidaTotal = value; }
        public int VendidoPremium { get => vendidoPremium; set => vendidoPremium = value; }
        public int VendidoTurista { get => vendidoTurista; set => vendidoTurista = value; }
        public int PesoBodegaOcupada { get => pesoBodegaOcupada; set => pesoBodegaOcupada = value; }
        public int EnumRegional { get => enumRegional; set => enumRegional = value; }
        public int IdViaje { get => idViaje; set => idViaje = value; }
        public int CamarotesDisponibles { get => camarotesDisponibles; set => camarotesDisponibles = value; }
        public string Estado { get => estado; set => estado = value; }

        public Viajes()
        {
            this.crucero = new Cruceros();
            this.ciudadPartida = "";
            this.ciudadDestino = "";
            this.fechaInicio = new DateTime();
            this.costoTurista = 0;
            this.costoPremium = 0;
            this.duracionViaje = 0;
            this.enumRegional = 0;
            this.idViaje = -1;
            this.vendidoPremium = 0;
            this.vendidoTurista = 0;
            this.pesoBodegaOcupada = 0;
            this.estado = "";
        }

        public Viajes(Cruceros crucero, string ciudadPartida, string ciudadDestino, DateTime fechaInicio, int costoTurista, int costoPremium, int duracionViaje, int vendidoPremium, int vendidoTurista, int pesoBodegaOcupada, int enumRegional, int idViaje)
        {
            this.crucero = crucero;
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaInicio = fechaInicio;
            this.costoTurista = costoTurista;
            this.costoPremium = costoPremium;
            this.duracionViaje = duracionViaje;
            this.vendidoPremium = vendidoPremium;
            this.vendidoTurista = vendidoTurista;
            this.pesoBodegaOcupada = pesoBodegaOcupada;
            this.enumRegional = enumRegional;
            this.idViaje = idViaje;
            this.camarotesDisponibles = crucero.CantidadCamarotes - (vendidoPremium + vendidoTurista);
        }

        public  List<PasajeroPremium> listOfPasajeroPremium = new List<PasajeroPremium>();
        public  List<PasajeroTurista> listOfPasajeroTurista = new List<PasajeroTurista>();

        public string[] mostrarLosViajes()
        {
            string[] fila = { this.crucero.NombreCrucero, this.ciudadPartida, this.ciudadDestino, this.fechaInicio.ToShortDateString(), this.idViaje.ToString(), this.estado };
            return fila;
        }
        public static Viajes DevolverViajePorId(int id)
        {
            Viajes viajeADevolver = new Viajes();
            foreach (Viajes item in Listas.listOfViajes)
            {

                if (id == item.idViaje)
                {
                    viajeADevolver = item;
                    break;
                }
            }
            return viajeADevolver;
        }

        /// <summary>
        /// Calcula la duracion de un viaje de manera al azar
        /// </summary>
        /// <returns>Devuelve un int que se genero de manera al azar</returns>
        public static int DuracionViajeExtraRegional()
        {
            Random duracionDelViaje = new Random();
            return duracionDelViaje.Next(480, 721);
        }
        /// <summary>
        /// Calcula la duracion de un viaje de manera al azar
        /// </summary>
        /// <returns>Devuelve un int que se genero de manera al azar</returns>
        public static int DuracionViajeRegional()
        {
            Random duracionDelViaje = new Random();
            return duracionDelViaje.Next(72, 361);
        }
        /// <summary>
        /// calcula el costo de un viaje extra regional y premium
        /// </summary>
        /// <param name="duracion">recibimos la duracion del viaje para multiplicarlo por el costo por hora</param>
        /// <returns>devolvemos un int con el valor del viaje</returns>
        public static float CostoPasajePremiumExtraRegional(string duracion)
        {
            int duacionInt;
            duacionInt = int.Parse(duracion);
            float valorFinal;
            int precioFijo = (120 * 20 / 100) + 120;
            valorFinal = precioFijo * duacionInt;
            return valorFinal;
        }
        /// <summary>
        /// calcula el costo de un viaje extra regional y turista
        /// </summary>
        /// <param name="duracion">recibimos la duracion del viaje para multiplicarlo por el costo por hora</param>
        /// <returns>devolvemos un int con el valor del viaje</returns>
        public static float CostoPasajeTuristaExtraRegional(string duracion)
        {
            int duacionInt;
            duacionInt = int.Parse(duracion);
            float valorFinal;
            int precioFijo = 120;
            valorFinal = precioFijo * duacionInt;
            return valorFinal;
        }
        /// <summary>
        /// calcula el costo de un viaje  regional y premium
        /// </summary>
        /// <param name="duracion">recibimos la duracion del viaje para multiplicarlo por el costo por hora</param>
        /// <returns>devolvemos un int con el valor del viaje</returns>
        public static float CostoPasajePremiumRegional(string duracion)
        {
            int duacionInt;
            duacionInt = int.Parse(duracion);
            float valorFinal;
            int precioFijo = (57 * 20 / 100) + 57;
            valorFinal = precioFijo * duacionInt;
            return valorFinal;
        }
        /// <summary>
        /// calcula el costo de un viaje extra regional y turista
        /// </summary>
        /// <param name="duracion">recibimos la duracion del viaje para multiplicarlo por el costo por hora</param>
        /// <returns>devolvemos un int con el valor del viaje</returns>
        public static float CostoPasajeTuristaRegional(string duracion)
        {
            int duacionInt;
            duacionInt = int.Parse(duracion);
            float valorFinal;
            int precioFijo = 57;
            valorFinal = precioFijo * duacionInt;
            return valorFinal;
        }
        /// <summary>
        /// recibe todos los datos necesarios para luego poder pasarlo a otra funcion que nos guarde este mismo viaje en la lista
        /// </summary>
        /// <param name="crucero">nombre del crucero</param>
        /// <param name="ciudadPartida">punto de salida del viaje</param>
        /// <param name="ciudadDestino">destino del viaje</param>
        /// <param name="fechaInicio">fecha en la qque sale el viaje</param>
        /// <param name="costoTurista">costo del viaje clase turista</param>
        /// <param name="costoPremium">costo del viaje clase premium</param>
        /// <param name="duracionDeViaje">tiempo en horas de la duracion del viaje</param>
        /// <param name="cantidadVendidas">cantidad de viajes vendidos</param>
        /// <param name="enumRegional">identificador para saber que tipo de viaje es</param>
        /// <param name="idViajes">id del viaje para poder identificarlo</param>
        public static void GuardarViaje(Cruceros crucero, string ciudadPartida, string ciudadDestino,DateTime fechaInicio, int costoTurista,int costoPremium,int duracionDeViaje,int cantidadVendidas,int enumRegional, int idViajes) 
        {
            Viajes viajeAGuardar = new Viajes();
            viajeAGuardar.crucero = crucero;
            viajeAGuardar.ciudadPartida = ciudadPartida;
            viajeAGuardar.ciudadDestino = ciudadDestino;
            viajeAGuardar.fechaInicio = fechaInicio;
            viajeAGuardar.costoTurista = costoTurista;
            viajeAGuardar.costoPremium = costoPremium;
            viajeAGuardar.duracionViaje = duracionDeViaje;
            viajeAGuardar.cantidadVendidaTotal = cantidadVendidas;
            viajeAGuardar.enumRegional = enumRegional;
            viajeAGuardar.idViaje = idViajes;
            viajeAGuardar.vendidoPremium = 0;
            viajeAGuardar.vendidoTurista = 0;
            viajeAGuardar.pesoBodegaOcupada = 0;
            SubirALista(viajeAGuardar);
        }
        /// <summary>
        /// trabaja en conjunto con la funcion de arriba, este guarda el viaje recibido en la lista de viajes
        /// </summary>
        /// <param name="viajeAGuardar"></param>
        public static void SubirALista(Viajes viajeAGuardar)
        {
            Listas.listOfViajes.Add(viajeAGuardar);
        }
        /// <summary>
        /// devuelve ciertos valores especificos para mostrarlos en un data grid
        /// </summary>
        /// <returns>devuelve ciertos valores especificos para mostrarlos en un data grid</returns>
        public string[] mostrarLosViajes2()
        {
            string[] fila = { this.crucero.NombreCrucero, this.ciudadDestino, this.fechaInicio.ToShortDateString(), this.idViaje.ToString(), this.costoTurista.ToString(), this.costoPremium.ToString(), this.CamarotesDisponibles.ToString()};
            return fila;
        }
        /// <summary>
        /// carga los viajes harcodeados
        /// </summary>
        public static void CargarViajes()
        {
            Listas.listOfViajes.Add(new Viajes(Listas.listOfCruceros[6], "Buenos Aires (Argentina)", "Cartagena",new DateTime(2023, 12, 01, 15, 00, 00), 20000,45000,DuracionViajeRegional(),4, 6, 350, 0,001));
            Listas.listOfViajes.Add(new Viajes(Listas.listOfCruceros[4],"Buenos Aires (Argentina)","Monte Video",new DateTime(2022, 06, 29, 15, 00, 00),26000,58000, DuracionViajeRegional(), 3,8,400,0,002 ));
            Listas.listOfViajes.Add(new Viajes(Listas.listOfCruceros[3],"Buenos Aires (Argentina)","La Habana",new DateTime(2022, 05, 20, 14, 30, 00),30000,90000,DuracionViajeExtraRegional(),7,10,1000,1,003 ));
            Listas.listOfViajes.Add(new Viajes(Listas.listOfCruceros[1], "Buenos Aires (Argentina)", "Lima", new DateTime(2023, 02, 11, 4, 00, 00), 15000, 30000,DuracionViajeRegional(), 6, 8, 1500, 0,004));
            Listas.listOfViajes.Add(new Viajes( Listas.listOfCruceros[0],"Buenos Aires (Argentina)","Miami",new DateTime(2022, 10, 29, 5, 30, 00),20000,50000,DuracionViajeExtraRegional(),8,11,2000,1,005));
        }
        /// <summary>
        /// actualiza la cantidad disponible de lños camarotes de n viajes
        /// </summary>
        /// <param name="crucero"></param>
        /// <param name="miviaje"></param>
        /// <returns>devuelve la cantidad disponible de camarotes</returns>
        public static int ActualizarEspacio(Cruceros crucero, Viajes miviaje)
        {
            int camarotesDisponibles; 
            camarotesDisponibles = (crucero.CantidadCamarotesPremium - miviaje.vendidoPremium) + (crucero.CantidadCamarotesTurista - miviaje.vendidoTurista);
            return camarotesDisponibles;
        }
        /// <summary>
        /// me genera un string de una linea para luego agregarlo a una list box
        /// </summary>
        /// <param name="viajeADevolver"></param>
        /// <returns>devuelve un string con ciertos datos a mostrar</returns>
        public static string rellenarListBox(Viajes viajeADevolver)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{viajeADevolver.crucero.NombreCrucero}      ");
            sb.AppendLine($"{viajeADevolver.ciudadDestino}      ");
            sb.AppendLine($"{viajeADevolver.fechaInicio}        ");
            return sb.ToString();
        }
        /// <summary>
        /// valida el estado del viaje tomando como referencia la fecha de inicio y calculando la fecha de llegada, con esto podemos saber si el crucero esta en viaje, lo termino o ni siquiera partio
        /// </summary>
        /// <param name="viajeADevolver"></param>
        /// <returns>devuelve un strin con el estado del crucero</returns>
        public static string DefinirEstado(Viajes viajeADevolver)
        {
            string retorno="";
            int dias = viajeADevolver.duracionViaje / 24;
            DateTime hoy = DateTime.Today;
            DateTime finalizaViaje = viajeADevolver.fechaInicio.AddDays(dias);

            if (viajeADevolver.fechaInicio > hoy)
            {
                retorno = "Disponible";
            }
            else
            {
                if (finalizaViaje < hoy)
                {
                    retorno = "Finalizado";
                }
                else
                { 
                    if (finalizaViaje>hoy)
                    {
                        retorno = "En viaje";
                    }
                }
            }
            return retorno;
        }
    }
}

