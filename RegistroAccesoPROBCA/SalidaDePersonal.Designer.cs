namespace RegistroAccesoPROBCA
{
    partial class SalidaDePersonal
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
            this.components = new System.ComponentModel.Container();
            this.lblGafete = new System.Windows.Forms.Label();
            this.txtGafete = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveRegistroPersona = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.txtRegistroAccesoID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGafete
            // 
            this.lblGafete.AutoSize = true;
            this.lblGafete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGafete.Location = new System.Drawing.Point(417, 15);
            this.lblGafete.Name = "lblGafete";
            this.lblGafete.Size = new System.Drawing.Size(64, 24);
            this.lblGafete.TabIndex = 0;
            this.lblGafete.Text = "Gafete";
            // 
            // txtGafete
            // 
            this.txtGafete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtGafete.Location = new System.Drawing.Point(509, 13);
            this.txtGafete.Name = "txtGafete";
            this.txtGafete.Size = new System.Drawing.Size(301, 29);
            this.txtGafete.TabIndex = 1;
            this.txtGafete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarPersonaEnter);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(117, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(693, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNombre.Location = new System.Drawing.Point(35, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Compañía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Clave Registro";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAsunto.Location = new System.Drawing.Point(35, 100);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(69, 24);
            this.lblAsunto.TabIndex = 13;
            this.lblAsunto.Text = "Asunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(399, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departamento";
            // 
            // txtClaveRegistroPersona
            // 
            this.txtClaveRegistroPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveRegistroPersona.Enabled = false;
            this.txtClaveRegistroPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtClaveRegistroPersona.Location = new System.Drawing.Point(172, 15);
            this.txtClaveRegistroPersona.Name = "txtClaveRegistroPersona";
            this.txtClaveRegistroPersona.Size = new System.Drawing.Size(206, 29);
            this.txtClaveRegistroPersona.TabIndex = 18;
            // 
            // txtAsunto
            // 
            this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsunto.Enabled = false;
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAsunto.Location = new System.Drawing.Point(117, 100);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(261, 29);
            this.txtAsunto.TabIndex = 19;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDepartamento.Location = new System.Drawing.Point(533, 100);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(277, 29);
            this.txtDepartamento.TabIndex = 20;
            // 
            // txtCompania
            // 
            this.txtCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompania.Enabled = false;
            this.txtCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCompania.Location = new System.Drawing.Point(151, 145);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(659, 29);
            this.txtCompania.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(35, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(151, 187);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(659, 29);
            this.txtDescripcion.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGuardar.Location = new System.Drawing.Point(861, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 60);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(861, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 60);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Enabled = false;
            this.dtFechaSalida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaSalida.Location = new System.Drawing.Point(191, 338);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(215, 35);
            this.dtFechaSalida.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Hora Salida";
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.Enabled = false;
            this.dtHoraSalida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSalida.Location = new System.Drawing.Point(565, 338);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(245, 35);
            this.dtHoraSalida.TabIndex = 28;
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // txtRegistroAccesoID
            // 
            this.txtRegistroAccesoID.Location = new System.Drawing.Point(867, 254);
            this.txtRegistroAccesoID.Name = "txtRegistroAccesoID";
            this.txtRegistroAccesoID.Size = new System.Drawing.Size(130, 20);
            this.txtRegistroAccesoID.TabIndex = 30;
            this.txtRegistroAccesoID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hora Entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Fecha Entrada";
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaEntrada.Enabled = false;
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtFechaEntrada.Location = new System.Drawing.Point(204, 255);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(210, 29);
            this.txtFechaEntrada.TabIndex = 35;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtHoraEntrada.Location = new System.Drawing.Point(600, 252);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(210, 29);
            this.txtHoraEntrada.TabIndex = 36;
            // 
            // SalidaDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 394);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRegistroAccesoID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtHoraSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompania);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtClaveRegistroPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtGafete);
            this.Controls.Add(this.lblGafete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalidaDePersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida De Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGafete;
        private System.Windows.Forms.TextBox txtGafete;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveRegistroPersona;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtHoraSalida;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.TextBox txtRegistroAccesoID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtHoraEntrada;
    }
}