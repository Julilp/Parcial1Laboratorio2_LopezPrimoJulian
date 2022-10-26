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
    
    public partial class GrillaDeViajes : Form
    {
        public int id;
        public GrillaDeViajes()
        {
            InitializeComponent();
        }
        
        private void GrillaDeViajes_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("En Viaje");
            cmbEstado.Items.Add("Finalizado");
            cmbEstado.Items.Add("Todos");
            foreach (Cruceros item in Listas.listOfCruceros)
            {
                CmbBarcos.Items.Add(item.NombreCrucero);
            }
            CmbBarcos.Items.Add("Todos");

            foreach (Viajes item in Listas.listOfViajes)
            {              
                    dataGridView1.Rows.Add(item.mostrarLosViajes());
            }
           
        }
        



        private void CmbBarcos_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarViaje frm =new AgregarViaje();
            frm.Show();
        }

        private void cmbEstado_TextChanged1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntradaPrograma frm = new EntradaPrograma(); 
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EntradaPrograma frm = new EntradaPrograma();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            InformacionDeViaje frm = new InformacionDeViaje();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            frm.viajeAMostrar = Viajes.DevolverViajePorId(id);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InformacionDeViaje frm = new InformacionDeViaje();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            frm.viajeAMostrar = Viajes.DevolverViajePorId(id);
            frm.ShowDialog();
        }

        private void CmbBarcos_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (CmbBarcos.Text == "Todos")
            {
                foreach (Viajes item in Listas.listOfViajes)
                {
                    dataGridView1.Rows.Add(item.mostrarLosViajes());
                }
            }
            else
            {
                foreach (Viajes item in Listas.listOfViajes)
                {
                    if (item.Crucero.NombreCrucero == CmbBarcos.Text)
                    {
                        dataGridView1.Rows.Add(item.mostrarLosViajes());
                    }

                }
            }
        }

        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Viajes item in Listas.listOfViajes)
            {
                if (cmbEstado.Text == "Todos")
                {
                    dataGridView1.Rows.Add(item.mostrarLosViajes());
                }
                else
                {
                    if (cmbEstado.Text == item.Estado)
                    {
                        dataGridView1.Rows.Add(item.mostrarLosViajes());
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarViaje frm = new AgregarViaje();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este form, si le damos doble click a los viajes podemos acceder a una informacion mas detallada de estos, y el boton agregar viaje nos sirve para crear un nuevo viaje.Luego tambien tenemos dos filtros para los viajes, por crucero y por estado de viaje", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
