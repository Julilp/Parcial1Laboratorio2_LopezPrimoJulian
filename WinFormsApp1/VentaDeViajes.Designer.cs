
namespace WinFormsApp1
{
    partial class VentaDeViajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroPasaporte = new System.Windows.Forms.TextBox();
            this.chkBoxPremium = new System.Windows.Forms.CheckBox();
            this.ChkBoxTurista = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPEmision = new System.Windows.Forms.DateTimePicker();
            this.DTPVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrupoFamiliar = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.DGVViajes = new System.Windows.Forms.DataGridView();
            this.NombreCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtGlobal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labellValija2 = new System.Windows.Forms.Label();
            this.txtValija2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValija1 = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.IndianRed;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(882, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 105);
            this.listBox1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(111, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(111, 172);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro. Pasaporte";
            // 
            // txtNroPasaporte
            // 
            this.txtNroPasaporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNroPasaporte.Enabled = false;
            this.txtNroPasaporte.Location = new System.Drawing.Point(173, 251);
            this.txtNroPasaporte.Name = "txtNroPasaporte";
            this.txtNroPasaporte.Size = new System.Drawing.Size(160, 23);
            this.txtNroPasaporte.TabIndex = 5;
            this.txtNroPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroPasaporte_KeyPress);
            // 
            // chkBoxPremium
            // 
            this.chkBoxPremium.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBoxPremium.AutoSize = true;
            this.chkBoxPremium.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxPremium.Enabled = false;
            this.chkBoxPremium.Location = new System.Drawing.Point(111, 353);
            this.chkBoxPremium.Name = "chkBoxPremium";
            this.chkBoxPremium.Size = new System.Drawing.Size(103, 19);
            this.chkBoxPremium.TabIndex = 7;
            this.chkBoxPremium.Text = "Viaje Premium";
            this.chkBoxPremium.UseVisualStyleBackColor = false;
            this.chkBoxPremium.CheckedChanged += new System.EventHandler(this.chkBoxPremium_CheckedChanged);
            // 
            // ChkBoxTurista
            // 
            this.ChkBoxTurista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChkBoxTurista.AutoSize = true;
            this.ChkBoxTurista.BackColor = System.Drawing.Color.Transparent;
            this.ChkBoxTurista.Enabled = false;
            this.ChkBoxTurista.Location = new System.Drawing.Point(16, 353);
            this.ChkBoxTurista.Name = "ChkBoxTurista";
            this.ChkBoxTurista.Size = new System.Drawing.Size(89, 19);
            this.ChkBoxTurista.TabIndex = 8;
            this.ChkBoxTurista.Text = "Viaje Turista";
            this.ChkBoxTurista.UseVisualStyleBackColor = false;
            this.ChkBoxTurista.CheckedChanged += new System.EventHandler(this.ChkBoxTurista_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vencimiento Pasaporte";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Emision Pasaporte";
            // 
            // DTPEmision
            // 
            this.DTPEmision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPEmision.Enabled = false;
            this.DTPEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEmision.Location = new System.Drawing.Point(199, 322);
            this.DTPEmision.MaxDate = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            this.DTPEmision.Name = "DTPEmision";
            this.DTPEmision.Size = new System.Drawing.Size(100, 23);
            this.DTPEmision.TabIndex = 11;
            this.DTPEmision.Value = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            // 
            // DTPVencimiento
            // 
            this.DTPVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPVencimiento.Enabled = false;
            this.DTPVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVencimiento.Location = new System.Drawing.Point(233, 282);
            this.DTPVencimiento.MinDate = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            this.DTPVencimiento.Name = "DTPVencimiento";
            this.DTPVencimiento.Size = new System.Drawing.Size(100, 23);
            this.DTPVencimiento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese el numero del grupo familiar: ";
            // 
            // txtGrupoFamiliar
            // 
            this.txtGrupoFamiliar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGrupoFamiliar.Location = new System.Drawing.Point(359, 81);
            this.txtGrupoFamiliar.Name = "txtGrupoFamiliar";
            this.txtGrupoFamiliar.Size = new System.Drawing.Size(55, 23);
            this.txtGrupoFamiliar.TabIndex = 14;
            this.txtGrupoFamiliar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupoFamiliar_KeyPress);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnComenzar.Location = new System.Drawing.Point(431, 81);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 15;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // DGVViajes
            // 
            this.DGVViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCrucero,
            this.Destino,
            this.fechasalida,
            this.dataGridViewTextBoxColumn1,
            this.costoTurista,
            this.costoPremium,
            this.Disponibilidad});
            this.DGVViajes.Enabled = false;
            this.DGVViajes.Location = new System.Drawing.Point(1, 390);
            this.DGVViajes.Name = "DGVViajes";
            this.DGVViajes.RowTemplate.Height = 25;
            this.DGVViajes.Size = new System.Drawing.Size(768, 186);
            this.DGVViajes.TabIndex = 16;
            this.DGVViajes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViajes_CellDoubleClick);
            // 
            // NombreCrucero
            // 
            this.NombreCrucero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCrucero.HeaderText = "Crucero";
            this.NombreCrucero.Name = "NombreCrucero";
            this.NombreCrucero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Destino
            // 
            this.Destino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechasalida
            // 
            this.fechasalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechasalida.HeaderText = "Fecha De Salida";
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // costoTurista
            // 
            this.costoTurista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costoTurista.HeaderText = "P/Turista";
            this.costoTurista.Name = "costoTurista";
            this.costoTurista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // costoPremium
            // 
            this.costoPremium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costoPremium.HeaderText = "P/Premium";
            this.costoPremium.Name = "costoPremium";
            this.costoPremium.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Camarotes Disp";
            this.Disponibilidad.Name = "Disponibilidad";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(809, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Costo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(861, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 28);
            this.label8.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(809, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Iva:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(809, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total:";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.Location = new System.Drawing.Point(882, 219);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(308, 23);
            this.txtCosto.TabIndex = 22;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.Location = new System.Drawing.Point(882, 251);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(308, 23);
            this.txtIva.TabIndex = 24;
            // 
            // txtGlobal
            // 
            this.txtGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGlobal.Location = new System.Drawing.Point(882, 291);
            this.txtGlobal.Name = "txtGlobal";
            this.txtGlobal.ReadOnly = true;
            this.txtGlobal.Size = new System.Drawing.Size(308, 23);
            this.txtGlobal.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(899, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "Grupo Familiar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("B612 Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(776, 515);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 47);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("B612 Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiguiente.Location = new System.Drawing.Point(776, 451);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(236, 47);
            this.btnSiguiente.TabIndex = 28;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(19, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(111, 211);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 29;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(386, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(304, 56);
            this.label14.TabIndex = 31;
            this.label14.Text = "  I                                                      I\r\n V   Ahora seleccione" +
    " un viaje   V";
            this.label14.Visible = false;
            // 
            // labellValija2
            // 
            this.labellValija2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labellValija2.AutoSize = true;
            this.labellValija2.BackColor = System.Drawing.Color.Transparent;
            this.labellValija2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labellValija2.Location = new System.Drawing.Point(225, 206);
            this.labellValija2.Name = "labellValija2";
            this.labellValija2.Size = new System.Drawing.Size(122, 28);
            this.labellValija2.TabIndex = 33;
            this.labellValija2.Text = "Peso valija 2";
            this.labellValija2.Visible = false;
            // 
            // txtValija2
            // 
            this.txtValija2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtValija2.Location = new System.Drawing.Point(359, 214);
            this.txtValija2.Name = "txtValija2";
            this.txtValija2.Size = new System.Drawing.Size(160, 23);
            this.txtValija2.TabIndex = 32;
            this.txtValija2.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(225, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 28);
            this.label16.TabIndex = 35;
            this.label16.Text = "Peso valija 1";
            // 
            // txtValija1
            // 
            this.txtValija1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtValija1.Enabled = false;
            this.txtValija1.Location = new System.Drawing.Point(359, 172);
            this.txtValija1.Name = "txtValija1";
            this.txtValija1.Size = new System.Drawing.Size(160, 23);
            this.txtValija1.TabIndex = 34;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNacionalidad.Enabled = false;
            this.txtNacionalidad.Location = new System.Drawing.Point(359, 128);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(160, 23);
            this.txtNacionalidad.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(355, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 28);
            this.label15.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(225, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 28);
            this.label17.TabIndex = 38;
            this.label17.Text = "Nacionalidad";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerminar.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("B612 Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTerminar.Location = new System.Drawing.Point(775, 390);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(236, 47);
            this.btnTerminar.TabIndex = 39;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Visible = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.Gato_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1124, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 80);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // VentaDeViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.mejorado_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 574);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtValija1);
            this.Controls.Add(this.labellValija2);
            this.Controls.Add(this.txtValija2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGlobal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGVViajes);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtGrupoFamiliar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPVencimiento);
            this.Controls.Add(this.DTPEmision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkBoxTurista);
            this.Controls.Add(this.chkBoxPremium);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroPasaporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1212, 613);
            this.Name = "VentaDeViajes";
            this.Text = "VentaDeViajes";
            this.Load += new System.EventHandler(this.VentaDeViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroPasaporte;
        private System.Windows.Forms.CheckBox chkBoxPremium;
        private System.Windows.Forms.CheckBox ChkBoxTurista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPEmision;
        private System.Windows.Forms.DateTimePicker DTPVencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrupoFamiliar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.DataGridView DGVViajes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtGlobal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labellValija2;
        private System.Windows.Forms.TextBox txtValija2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValija1;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}