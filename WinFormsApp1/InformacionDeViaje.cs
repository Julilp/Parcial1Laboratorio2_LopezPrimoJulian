using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases_LopezPrimo;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InformacionDeViaje : Form
    {
        public Viajes viajeAMostrar;

        
        public InformacionDeViaje()
        {
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            txtNombre.Text = viajeAMostrar.Crucero.NombreCrucero;
            txtCiudadPartida.Text = viajeAMostrar.CiudadPartida;
            txtCiudadDestino.Text = viajeAMostrar.CiudadDestino;
            TxtDuracion.Text = viajeAMostrar.DuracionViaje.ToString();
            txtFecha.Text = viajeAMostrar.FechaInicio.ToShortDateString();
            txtCostoPremium.Text = viajeAMostrar.CostoPremium.ToString();
            txtPasajeTurista.Text = viajeAMostrar.CostoTurista.ToString();
            if (viajeAMostrar.EnumRegional == 1)
            {
                txtTipoViaje.Text = "Extra Regional";
            }
            else 
            {
                txtTipoViaje.Text = "Regional";
            }
            
            listBoxSalones.Items.Add("Barras De Trago: " + viajeAMostrar.Crucero.SalonesExistentes.BarraDeTragos);
            listBoxSalones.Items.Add("Casinos: " + viajeAMostrar.Crucero.SalonesExistentes.Casino);
            listBoxSalones.Items.Add("Cines: " + viajeAMostrar.Crucero.SalonesExistentes.Cine);
            listBoxSalones.Items.Add("Gimnasios: " + viajeAMostrar.Crucero.SalonesExistentes.Gimnasio);
            listBoxSalones.Items.Add("Piletas: " + viajeAMostrar.Crucero.SalonesExistentes.Pileta);
            listBoxSalones.Items.Add("Pistas De Baile: " + viajeAMostrar.Crucero.SalonesExistentes.PistaDeBaile);
            listBoxSalones.Items.Add("Salas De Juego: " + viajeAMostrar.Crucero.SalonesExistentes.PlayRoom);
            listBoxSalones.Items.Add("Salas De Masajes: " + viajeAMostrar.Crucero.SalonesExistentes.SalaDeMasajes);
            listBoxSalones.Items.Add("Salones De Lectura: " + viajeAMostrar.Crucero.SalonesExistentes.SalonDeLectua);
            listBoxSalones.Items.Add("Spas: " + viajeAMostrar.Crucero.SalonesExistentes.Spa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasajerosEnViaje frm = new PasajerosEnViaje();
            frm.viajeAMostrar = viajeAMostrar;
            frm.Show();
        }

        private void listBoxSalones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoViaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntradaPrograma frm = new EntradaPrograma();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aca podemos observar toda la informacion del viaje, y si le damos al boton 'Ver pasajeros', podremos ver los pasajeros anotados al viaje", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
