using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases_LopezPrimo;


namespace WinFormsApp1
{
    public partial class Estadisticas : Form
    {
        int recaudadoDestino;
        int recaudadoExtraRegional;
        int recaudadoRegional;
        int recaudadoTotal;
        bool bandera1 = true;
        string destinoMasElegido;
        int cantidadMasElegida;
        int contadorDestino = 0;
        int totalHorasCrucero=0;


        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            lbldestinomaselegido.Visible=true;

            foreach (ViajesRegionales ViajeRegional in Enum.GetValues(typeof(ViajesRegionales)))
            {
                foreach (Viajes viaje in Listas.listOfViajes)
                {
                    if(ViajeRegional.ToString() == viaje.CiudadDestino)
                    {
                        contadorDestino = contadorDestino + (viaje.listOfPasajeroPremium.Count() + viaje.listOfPasajeroTurista.Count());
                        recaudadoDestino = (viaje.listOfPasajeroPremium.Count() * viaje.CostoPremium) + (viaje.listOfPasajeroTurista.Count() * viaje.CostoTurista);    
                    }                
                }
                if(bandera1 == true)
                {
                    cantidadMasElegida = contadorDestino;
                    destinoMasElegido = ViajeRegional.ToString();
                    bandera1 = false;
                }
                else
                {
                    if (contadorDestino> cantidadMasElegida)
                    {
                        cantidadMasElegida = contadorDestino;
                        destinoMasElegido = ViajeRegional.ToString();
                    }
                }
                recaudadoRegional = recaudadoRegional + recaudadoDestino;
                dataGridView1.Rows.Add(ViajeRegional.ToString(), recaudadoDestino);
                recaudadoDestino = 0;
            }
            foreach (ViajesExtraRegionales ViajeRegional in Enum.GetValues(typeof(ViajesExtraRegionales)))
            {
                foreach (Viajes viaje in Listas.listOfViajes)
                {
                    if (ViajeRegional.ToString() == viaje.CiudadDestino)
                    {
                        contadorDestino = contadorDestino + (viaje.listOfPasajeroPremium.Count() + viaje.listOfPasajeroTurista.Count());
                        recaudadoDestino = (viaje.listOfPasajeroPremium.Count() * viaje.CostoPremium) + (viaje.listOfPasajeroTurista.Count() * viaje.CostoTurista);
                    }
                    
                }
                if (contadorDestino > cantidadMasElegida)
                {
                    cantidadMasElegida = contadorDestino;
                    destinoMasElegido = ViajeRegional.ToString();
                }
                recaudadoExtraRegional = recaudadoExtraRegional + recaudadoDestino;
                dataGridView1.Rows.Add(ViajeRegional.ToString(), recaudadoDestino);
                recaudadoDestino = 0;
            }
            recaudadoTotal = recaudadoExtraRegional + recaudadoRegional;
            lbltotal.Text = recaudadoTotal.ToString();
            lblTotalExtraRegional.Text = recaudadoExtraRegional.ToString();
            lblTotalRegional.Text = recaudadoRegional.ToString();
            lbldestinomaselegido.Text = $"El destino mas elegido es {destinoMasElegido}" +
                                        $" Con un total de {cantidadMasElegida} pasajeros";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntradaPrograma frm = new EntradaPrograma();
            frm.ShowDialog();
        }

        private void btnTiempocruceros_Click(object sender, EventArgs e)
        {
            dataGridViewCruceros.Visible = true;
            foreach (Cruceros crucero in Listas.listOfCruceros)
            {
                foreach (Viajes item in Listas.listOfViajes)
                {
                    if(crucero.NombreCrucero==item.Crucero.NombreCrucero)
                    {
                        totalHorasCrucero = totalHorasCrucero + item.DuracionViaje;
                    }
                }
                dataGridViewCruceros.Rows.Add(crucero.NombreCrucero,totalHorasCrucero);
                totalHorasCrucero = 0;
            }
        }
    }
}
