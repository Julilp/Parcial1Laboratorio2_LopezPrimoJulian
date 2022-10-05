using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EntradaPrograma : Form
    {

        public EntradaPrograma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrillaDeViajes frm = new GrillaDeViajes();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CentrarControl(Control ctrl)
        {
            ctrl.Top = (ctrl.Parent.ClientSize.Height - ctrl.Height) / 2;
            ctrl.Left = (ctrl.Parent.ClientSize.Width - ctrl.Width) / 2;
        }

        private void EntradaPrograma_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label4.Text = Form1.userName;
          
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            VentaDeViajes frm = new VentaDeViajes();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticas frm = new Estadisticas();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quieres salir?", "Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformacionCruceros frm = new InformacionCruceros();
            frm.ShowDialog();
        }
    }
}
