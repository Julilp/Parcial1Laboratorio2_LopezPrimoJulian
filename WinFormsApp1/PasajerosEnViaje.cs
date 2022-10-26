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
    public partial class PasajerosEnViaje : Form
    {
       public Viajes viajeAMostrar = new Viajes(); 
       
        public PasajerosEnViaje()
        {
            InitializeComponent();
        }

        private void PasajerosEnViaje_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Viajes.rellenarListBox(viajeAMostrar));
            foreach (PasajeroPremium item in viajeAMostrar.listOfPasajeroPremium)
            {
                listBox2.Items.Add(PasajeroPremium.rellenarListBoxPasajerosPremium(item));
            }
            foreach (PasajeroTurista item in viajeAMostrar.listOfPasajeroTurista)
            {
                listBox2.Items.Add(PasajeroTurista.rellenarListBoxPasajerosTurista(item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            EntradaPrograma frm = new EntradaPrograma(); 
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui podremos ver los pasajeros registrados en el viaje con toda su informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
