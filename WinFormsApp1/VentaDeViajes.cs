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
    public partial class VentaDeViajes : Form
    {
        Viajes miViaje = new Viajes();
        int totalPesoBodega = 0;
        DateTime hoy = DateTime.Today;
        int idViaje;
        int cantGrupoFamiliar;
        int list;
        private List<PasajeroPremium> listOfPasajeroPremiumAux = new List<PasajeroPremium>();
        private List<PasajeroTurista> listOfPasajeroTuristaAux = new List<PasajeroTurista>();
        int tipoViaje;

        public VentaDeViajes()
        {
            InitializeComponent();
        }

        private void VentaDeViajes_Load(object sender, EventArgs e)
        {
            txtCosto.Text = "0";
            foreach (Viajes item in Listas.listOfViajes)
            {

                if (item.FechaInicio > hoy)
                {
                    DGVViajes.Rows.Add(item.mostrarLosViajes2());
                }
            }
        }

        private void txtGrupoFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNroPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (txtGrupoFamiliar.Text != "")
            {
                cantGrupoFamiliar = int.Parse(txtGrupoFamiliar.Text);
            }
            if (cantGrupoFamiliar <= 4 && cantGrupoFamiliar > 0)
            {
                DGVViajes.Enabled = true;
                label14.Visible = true;
            }
        }
        public void DGVViajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            idViaje = Convert.ToInt32(DGVViajes.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            miViaje = Viajes.DevolverViajePorId(idViaje);
            DGVViajes.Rows.Clear();
            DGVViajes.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            txtNroPasaporte.Enabled = true;
            txtGrupoFamiliar.Enabled = false;
            DTPEmision.Enabled = true;
            DTPVencimiento.Enabled = true;
            chkBoxPremium.Enabled = true;
            ChkBoxTurista.Enabled = true;
            btnSiguiente.Enabled = true;
            btnComenzar.Enabled = false;
            label14.Visible = false;
            txtValija1.Enabled = true;
            txtNacionalidad.Enabled = true;
            foreach (Viajes item in Listas.listOfViajes)
            {
                if (item.IdViaje == idViaje)
                {
                    DGVViajes.Rows.Add(item.mostrarLosViajes2());
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tipoViaje == 1)
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtNroPasaporte.Text != "" && txtValija1.Text != "" && txtValija2.Text != "" && txtNacionalidad.Text != "" && chkBoxPremium.Checked == true)
                {
                    if (int.Parse(txtEdad.Text) < 100 && (int.Parse(txtValija1.Text) < 25 && int.Parse(txtValija2.Text) < 25) && (int.Parse(txtValija1.Text) > 0 && int.Parse(txtValija2.Text) > 0))
                    {
                        listBox1.Items.Add(txtNombre.Text);
                        PasajeroPremium pasajeroAGuardar = new PasajeroPremium(new Pasaporte(DTPVencimiento.Value.Date, DTPEmision.Value.Date, txtNacionalidad.Text, int.Parse(txtNroPasaporte.Text)), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), int.Parse(txtValija1.Text), int.Parse(txtValija2.Text));
                        listOfPasajeroPremiumAux.Add(pasajeroAGuardar);
                        list = listBox1.Items.Count;
                        totalPesoBodega = totalPesoBodega + int.Parse(txtValija1.Text) + int.Parse(txtValija2.Text);
                        txtCosto.Text = ((int.Parse(txtCosto.Text) + miViaje.CostoPremium)).ToString();
                        txtIva.Text = ((int.Parse(txtCosto.Text) * 0.21)).ToString();
                        txtGlobal.Text = ((int.Parse(txtCosto.Text) + int.Parse(txtIva.Text)).ToString());
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtEdad.Text = "";
                        txtNroPasaporte.Text = "";
                        txtValija1.Text = "";
                        txtValija2.Text = "";
                        txtNacionalidad.Text = "";
                        if (list == cantGrupoFamiliar)
                        {
                            btnTerminar.Visible = true;
                            btnSiguiente.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las valijas exceden su peso limite de 25Kg o pesan menos de 0", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Revise que todos los campos esten completos", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (tipoViaje == 0 && txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtNroPasaporte.Text != "" && txtValija1.Text != "" && txtNacionalidad.Text != "" && ChkBoxTurista.Checked == true)
                {
                    if (int.Parse(txtEdad.Text) < 100 && (int.Parse(txtValija1.Text) < 25))
                    {
                        listBox1.Items.Add(txtNombre.Text);
                        PasajeroTurista pasajeroAGuardar = new PasajeroTurista(new Pasaporte(DTPVencimiento.Value.Date, DTPEmision.Value.Date, txtNacionalidad.Text, int.Parse(txtNroPasaporte.Text)), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), int.Parse(txtValija1.Text));
                        listOfPasajeroTuristaAux.Add(pasajeroAGuardar);
                        list = listBox1.Items.Count;
                        totalPesoBodega = totalPesoBodega + int.Parse(txtValija1.Text);
                        txtCosto.Text = ((int.Parse(txtCosto.Text) + miViaje.CostoPremium)).ToString();
                        txtIva.Text = ((int.Parse(txtCosto.Text) * 0.21)).ToString();
                        txtGlobal.Text = ((int.Parse(txtCosto.Text) + int.Parse(txtIva.Text)).ToString());
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtEdad.Text = "";
                        txtNroPasaporte.Text = "";
                        txtValija1.Text = "";
                        txtNacionalidad.Text = "";
                        if (list == cantGrupoFamiliar)
                        {
                            btnTerminar.Visible = true;
                            btnSiguiente.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las valijas exceden su peso limite de 25Kg", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Revise que todos los campos esten completos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void ChkBoxTurista_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seleccionar la clase turista, esta seguro de esto?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnSiguiente.Enabled = true;
                tipoViaje = 0;
                chkBoxPremium.Enabled = false;
                ChkBoxTurista.Enabled = false;
            }
            else
            {
                chkBoxPremium.Checked = false;
                ChkBoxTurista.Checked = false;
            }
        }

        private void chkBoxPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seleccionar la clase premium, esta seguro de esto?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tipoViaje = 1;
                btnSiguiente.Enabled = true;
                chkBoxPremium.Enabled = false;
                ChkBoxTurista.Enabled = false;
                labellValija2.Visible = true;
                txtValija2.Visible = true;
            }
            else
            {
                chkBoxPremium.Checked = false;
                ChkBoxTurista.Checked = false;
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (tipoViaje == 1)
            {
                miViaje.VendidoPremium = miViaje.VendidoPremium + 1;
                Viajes.ActualizarEspacio(miViaje.Crucero, miViaje);
                if (miViaje.VendidoPremium < miViaje.Crucero.CantidadCamarotesPremium)
                {
                    miViaje.PesoBodegaOcupada = miViaje.PesoBodegaOcupada + totalPesoBodega;
                    if (miViaje.Crucero.CapacidadBodega > totalPesoBodega)
                    {
                        foreach (PasajeroPremium item in listOfPasajeroPremiumAux)
                        {
                            miViaje.listOfPasajeroPremium.Add(item);
                        }
                        MessageBox.Show("Se vendio correctamente todos los pasajes del grupo familiar", "Perfecto", MessageBoxButtons.OK);
                        miViaje.CamarotesDisponibles = miViaje.Crucero.CantidadCamarotes - (miViaje.VendidoPremium + miViaje.VendidoTurista);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Barco ya tiene la bodega ocupada", "Perfecto", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                miViaje.VendidoTurista = miViaje.VendidoTurista + 1;
                Viajes.ActualizarEspacio(miViaje.Crucero, miViaje);
                if (miViaje.VendidoTurista < miViaje.Crucero.CantidadCamarotesTurista)
                {
                    miViaje.PesoBodegaOcupada = miViaje.PesoBodegaOcupada + totalPesoBodega;
                    if (miViaje.Crucero.CapacidadBodega > totalPesoBodega)
                    {
                        foreach (PasajeroTurista item in listOfPasajeroTuristaAux)
                        {
                            miViaje.listOfPasajeroTurista.Add(item);
                        }
                        MessageBox.Show("Se vendio correctamente todos los pasajes del grupo familiar", "Perfecto", MessageBoxButtons.OK);
                        miViaje.CamarotesDisponibles = miViaje.Crucero.CantidadCamarotes - (miViaje.VendidoPremium + miViaje.VendidoTurista);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Barco ya tiene la bodega ocupada", "Perfecto", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ya no quedan camarotes de clase turista", "Perfecto", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void DGVViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debes completar todos los campos con los datos solicitados, en estos hay que tener en cuenta las siguientes cosas: Las valijas no pueden pesar mas de 25 kg, no estan permitidas personas mayores a 100 años", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtValija1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtValija2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
