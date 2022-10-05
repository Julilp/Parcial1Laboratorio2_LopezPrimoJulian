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
    public partial class Form1 : Form
    {
        public static string userName;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Viajes.CargarViajes();
            foreach (Viajes item in Listas.listOfViajes)
            {
                item.Estado=Viajes.DefinirEstado(item);
            }
            foreach (Cruceros item in Listas.listOfCruceros)
            {
                Cruceros.HarcodeoCruceros(item);
            }
            
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            CentrarControl(panel1);
        }
        private void CentrarControl(Control ctrl)
        {
            ctrl.Top = (ctrl.Parent.ClientSize.Height - ctrl.Height) / 2;
            ctrl.Left = (ctrl.Parent.ClientSize.Width - ctrl.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            foreach (Usuario usuario in Listas.listOfUsers)
            {
                if (usuario == txtUsername.Text && usuario.contraseniaUsuario == txtPassword.Text)
                {
                    this.Hide();
                    EntradaPrograma frm = new EntradaPrograma();
                    frm.ShowDialog();       
                }
                else
                {
                    label4.Show();
                    pictureBox3.Show();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
