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
    public partial class AgregarViaje : Form
    {
        int tipoDeViaje=-1;
        int validacion =-1;
        public AgregarViaje()
        {
            InitializeComponent();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (Control item in groupBox1.Controls)
            {
                
                
                
                    if (item is DateTimePicker) 
                    {
                        DateTime hoy = DateTime.Today;
                        if (dateTimePicker1.Value.Date < hoy)
                        {
                            MessageBox.Show("La fecha ingresada es menor al dia de hoy", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            validacion = 0;
                            break;
                        }
                        else 
                        {
                            if(Cruceros.ValidarDias(comboCrucero.Text,dateTimePicker1.Value)==false)
                            {
                                MessageBox.Show("El Crucero Tiene un viaje para esa fecha", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {                                         
                            validacion = 1;                        
                    }
                
            }
            if (validacion == 1)
            {
                int id;
                Random idRandom = new Random();
                id = idRandom.Next(0, 9999);
                Cruceros CruceroDelViaje = new Cruceros();
                CruceroDelViaje = Cruceros.DevolverCrucero(comboCrucero.Text);
                Viajes.GuardarViaje(CruceroDelViaje, txtCiudadPartida.Text, comboDestino.Text, dateTimePicker1.Value, int.Parse(txtPasajeTurista.Text), int.Parse(txtCostoPremium.Text), int.Parse(TxtDuracion.Text), 0, tipoDeViaje, id);
                MessageBox.Show("Se guardo el viaje correctamente", "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                GrillaDeViajes frm = new GrillaDeViajes();
                frm.ShowDialog();
            }
        }

        private void AgregarViaje_Load(object sender, EventArgs e)
        {
            comboDestino.Enabled = false;
            txtCiudadPartida.Text = "Buenos Aires (Argentina)";
            foreach (Cruceros item in Listas.listOfCruceros)
            {
                comboCrucero.Items.Add(item.NombreCrucero);
            }
        }

        private void buttonAñadir_Click_1(object sender, EventArgs e)
        {

            
        }

        private void buttonSacar_Click_1(object sender, EventArgs e)
        {

        }

        private void checkRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoDeViaje = 0;
            this.comboDestino.Text = "";
            this.comboDestino.Items.Clear();
            if (this.checkExtraRegional.Checked == false && this.checkRegional.Checked == false)
            {
                this.comboDestino.Enabled = false;
            }
            else
            {
                if (this.checkRegional.Checked == true)
                {
                    this.comboDestino.Enabled = true;
                    this.checkExtraRegional.Checked = false;
                    foreach (ViajesRegionales item in Enum.GetValues(typeof(ViajesRegionales)))
                    {
                        comboDestino.Items.Add(item);
                    }
                }
            }
        }
        private void checkExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoDeViaje = 1;
            this.comboDestino.Text = "";
            this.comboDestino.Items.Clear();
            if (this.checkExtraRegional.Checked == false && this.checkRegional.Checked == false)
            {
                this.comboDestino.Enabled = false;
            }
            else
            {
                if (this.checkExtraRegional.Checked == true)
                {
                    this.comboDestino.Enabled = true;
                    this.checkRegional.Checked = false;
                    foreach (ViajesExtraRegionales item in Enum.GetValues(typeof(ViajesExtraRegionales)))
                    {
                        comboDestino.Items.Add(item);
                    }
                    
                }
            }
        }
        private void comboDestino_TextChanged(object sender, EventArgs e)
        {
            if(this.checkExtraRegional.Checked == true)
            {
                this.TxtDuracion.Text = ($"{Viajes.DuracionViajeExtraRegional()}");
                this.txtCostoPremium.Text = ($"{Viajes.CostoPasajePremiumExtraRegional(TxtDuracion.Text)}");
                this.txtPasajeTurista.Text = ($"{Viajes.CostoPasajeTuristaExtraRegional(TxtDuracion.Text)}");
            }
            else
            {
                this.TxtDuracion.Text = ($"{Viajes.DuracionViajeRegional()}");
                this.txtCostoPremium.Text = ($"{Viajes.CostoPasajePremiumRegional(TxtDuracion.Text)}");
                this.txtPasajeTurista.Text = ($"{Viajes.CostoPasajeTuristaRegional(TxtDuracion.Text)}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            EntradaPrograma frm = new EntradaPrograma(); 
            frm.ShowDialog();
        }
    }
}
