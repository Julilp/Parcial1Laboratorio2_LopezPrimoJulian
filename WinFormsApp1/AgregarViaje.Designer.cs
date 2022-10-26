
namespace WinFormsApp1
{
    partial class AgregarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarViaje));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.checkExtraRegional = new System.Windows.Forms.CheckBox();
            this.checkRegional = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCrucero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiudadPartida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoPremium = new System.Windows.Forms.TextBox();
            this.txtPasajeTurista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(442, 243);
            this.button1.MinimumSize = new System.Drawing.Size(170, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboDestino);
            this.groupBox1.Controls.Add(this.checkExtraRegional);
            this.groupBox1.Controls.Add(this.checkRegional);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboCrucero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCiudadPartida);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtDuracion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCostoPremium);
            this.groupBox1.Controls.Add(this.txtPasajeTurista);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.MinimumSize = new System.Drawing.Size(907, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 281);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Viaje";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(27, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 36);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 29);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 23);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.Value = new System.DateTime(2022, 10, 1, 19, 2, 4, 0);
            // 
            // comboDestino
            // 
            this.comboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestino.Enabled = false;
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(163, 129);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(159, 23);
            this.comboDestino.TabIndex = 82;
            this.comboDestino.TextChanged += new System.EventHandler(this.comboDestino_TextChanged);
            // 
            // checkExtraRegional
            // 
            this.checkExtraRegional.AutoSize = true;
            this.checkExtraRegional.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkExtraRegional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkExtraRegional.Location = new System.Drawing.Point(439, 190);
            this.checkExtraRegional.Name = "checkExtraRegional";
            this.checkExtraRegional.Size = new System.Drawing.Size(128, 23);
            this.checkExtraRegional.TabIndex = 81;
            this.checkExtraRegional.Text = "Internacionales";
            this.checkExtraRegional.UseVisualStyleBackColor = true;
            this.checkExtraRegional.CheckedChanged += new System.EventHandler(this.checkExtraRegional_CheckedChanged);
            // 
            // checkRegional
            // 
            this.checkRegional.AutoSize = true;
            this.checkRegional.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkRegional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkRegional.Location = new System.Drawing.Point(439, 172);
            this.checkRegional.Name = "checkRegional";
            this.checkRegional.Size = new System.Drawing.Size(84, 23);
            this.checkRegional.TabIndex = 80;
            this.checkRegional.Text = "Regional";
            this.checkRegional.UseVisualStyleBackColor = true;
            this.checkRegional.CheckedChanged += new System.EventHandler(this.checkRegional_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(337, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tipo de viaje";
            // 
            // comboCrucero
            // 
            this.comboCrucero.FormattingEnabled = true;
            this.comboCrucero.Location = new System.Drawing.Point(163, 29);
            this.comboCrucero.Name = "comboCrucero";
            this.comboCrucero.Size = new System.Drawing.Size(159, 23);
            this.comboCrucero.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre del crucero";
            // 
            // txtCiudadPartida
            // 
            this.txtCiudadPartida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCiudadPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudadPartida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCiudadPartida.Location = new System.Drawing.Point(163, 83);
            this.txtCiudadPartida.Name = "txtCiudadPartida";
            this.txtCiudadPartida.ReadOnly = true;
            this.txtCiudadPartida.Size = new System.Drawing.Size(159, 16);
            this.txtCiudadPartida.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(22, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Ciudad de partida";
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDuracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDuracion.Location = new System.Drawing.Point(163, 186);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.ReadOnly = true;
            this.TxtDuracion.Size = new System.Drawing.Size(159, 16);
            this.TxtDuracion.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(22, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ciudad destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Duracion del viaje";
            // 
            // txtCostoPremium
            // 
            this.txtCostoPremium.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCostoPremium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCostoPremium.Location = new System.Drawing.Point(489, 82);
            this.txtCostoPremium.Name = "txtCostoPremium";
            this.txtCostoPremium.ReadOnly = true;
            this.txtCostoPremium.Size = new System.Drawing.Size(113, 16);
            this.txtCostoPremium.TabIndex = 71;
            // 
            // txtPasajeTurista
            // 
            this.txtPasajeTurista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPasajeTurista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasajeTurista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasajeTurista.Location = new System.Drawing.Point(489, 133);
            this.txtPasajeTurista.Name = "txtPasajeTurista";
            this.txtPasajeTurista.ReadOnly = true;
            this.txtPasajeTurista.Size = new System.Drawing.Size(113, 16);
            this.txtPasajeTurista.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(328, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Costo pasaje turista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(328, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Costo pasaje premium";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(328, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Fecha de salida";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::WinFormsApp1.Properties.Resources.inicio_negro1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(22, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 55);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.invertido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(685, 415);
            this.Name = "AgregarViaje";
            this.Text = "AgregarViaje";
            this.Load += new System.EventHandler(this.AgregarViaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCrucero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiudadPartida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostoPremium;
        private System.Windows.Forms.TextBox txtPasajeTurista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.CheckBox checkExtraRegional;
        private System.Windows.Forms.CheckBox checkRegional;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}