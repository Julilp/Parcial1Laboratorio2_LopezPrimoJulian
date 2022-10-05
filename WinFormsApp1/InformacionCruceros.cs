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
    
    public partial class InformacionCruceros : Form
    {
        Cruceros cruceroAMostrar = new Cruceros();
        public InformacionCruceros()
        {
            InitializeComponent();
        }

        private void InformacionCruceros_Load(object sender, EventArgs e)
        {
            foreach (Cruceros item in Listas.listOfCruceros)
            {
                listBox1.Items.Add(item.NombreCrucero);
            }
        }

        private void InformacionCruceros_DoubleClick(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
           cruceroAMostrar = Cruceros.DevolverCrucero(listBox1.SelectedItem.ToString());
            label1.Text = cruceroAMostrar.NombreCrucero;
            txtCantidadCamarotes.Text = cruceroAMostrar.CantidadCamarotes.ToString();
            txtCamarotesPremiums.Text = cruceroAMostrar.CantidadCamarotesPremium.ToString();
            txtCamarotesTuristas.Text = cruceroAMostrar.CantidadCamarotesTurista.ToString();
            txtMatricula.Text = cruceroAMostrar.IdCrucero;
            txtCantidadSalones.Text = cruceroAMostrar.CantidadSalones.ToString();
            txtCapacidadBodega.Text = cruceroAMostrar.CapacidadBodega.ToString();
            listBox2.Items.Clear();
            listBox2.Items.Add("Barras De Trago: " + cruceroAMostrar.SalonesExistentes.BarraDeTragos);
            listBox2.Items.Add("Casinos: " + cruceroAMostrar.SalonesExistentes.Casino);
            listBox2.Items.Add("Cines: " + cruceroAMostrar.SalonesExistentes.Cine);
            listBox2.Items.Add("Gimnasios: " + cruceroAMostrar.SalonesExistentes.Gimnasio);
            listBox2.Items.Add("Piletas: " + cruceroAMostrar.SalonesExistentes.Pileta);
            listBox2.Items.Add("Pistas De Baile: " + cruceroAMostrar.SalonesExistentes.PistaDeBaile);
            listBox2.Items.Add("Salas De Juego: " + cruceroAMostrar.SalonesExistentes.PlayRoom);
            listBox2.Items.Add("Salas De Masajes: " + cruceroAMostrar.SalonesExistentes.SalaDeMasajes);
            listBox2.Items.Add("Salones De Lectura: " + cruceroAMostrar.SalonesExistentes.SalonDeLectua);
            listBox2.Items.Add("Spas: " + cruceroAMostrar.SalonesExistentes.Spa);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EntradaPrograma frm = new EntradaPrograma();
            frm.ShowDialog();
        }
    }
}
