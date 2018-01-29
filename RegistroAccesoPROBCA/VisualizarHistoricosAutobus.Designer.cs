namespace RegistroAccesoPROBCA
{
    partial class VisualizarHistoricosAutobus
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
            this.cmbRutas = new System.Windows.Forms.ComboBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRegistroID = new System.Windows.Forms.Label();
            this.txtClaveRegistro = new System.Windows.Forms.TextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlacasVehiculo = new System.Windows.Forms.TextBox();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRutas
            // 
            this.cmbRutas.Enabled = false;
            this.cmbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.Items.AddRange(new object[] {
            "Administración",
            "Almacén",
            "Calidad",
            "Embarques",
            "Fabricación",
            "Ingenieria",
            "Mantenimiento",
            "Materiales",
            "Pintura",
            "Planeación y Control",
            "Recursos Humanos"});
            this.cmbRutas.Location = new System.Drawing.Point(589, 82);
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(380, 32);
            this.cmbRutas.TabIndex = 108;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(455, 87);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 24);
            this.lblRuta.TabIndex = 107;
            this.lblRuta.Text = "Ruta";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.Location = new System.Drawing.Point(20, 85);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(124, 24);
            this.lblCantidadPersonas.TabIndex = 106;
            this.lblCantidadPersonas.Text = "No. Personas";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPersonas.Location = new System.Drawing.Point(160, 82);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.ReadOnly = true;
            this.txtCantidadPersonas.Size = new System.Drawing.Size(269, 29);
            this.txtCantidadPersonas.TabIndex = 105;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(20, 50);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(98, 24);
            this.lblConductor.TabIndex = 104;
            this.lblConductor.Text = "Conductor";
            // 
            // txtCondutor
            // 
            this.txtCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondutor.Location = new System.Drawing.Point(160, 47);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.ReadOnly = true;
            this.txtCondutor.Size = new System.Drawing.Size(809, 29);
            this.txtCondutor.TabIndex = 103;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(160, 191);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(809, 44);
            this.txtDescripcion.TabIndex = 100;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 194);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 99;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblRegistroID
            // 
            this.lblRegistroID.AutoSize = true;
            this.lblRegistroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroID.Location = new System.Drawing.Point(20, 16);
            this.lblRegistroID.Name = "lblRegistroID";
            this.lblRegistroID.Size = new System.Drawing.Size(131, 24);
            this.lblRegistroID.TabIndex = 98;
            this.lblRegistroID.Text = "Clave Registro";
            // 
            // txtClaveRegistro
            // 
            this.txtClaveRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveRegistro.Location = new System.Drawing.Point(160, 13);
            this.txtClaveRegistro.Name = "txtClaveRegistro";
            this.txtClaveRegistro.ReadOnly = true;
            this.txtClaveRegistro.Size = new System.Drawing.Size(269, 29);
            this.txtClaveRegistro.TabIndex = 97;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(455, 121);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(121, 24);
            this.lblHoraEntrada.TabIndex = 94;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.Location = new System.Drawing.Point(20, 124);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(134, 24);
            this.lblFechaEntrada.TabIndex = 93;
            this.lblFechaEntrada.Text = "Fecha Entrada";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(455, 15);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(65, 24);
            this.lblPlaca.TabIndex = 92;
            this.lblPlaca.Text = "Placas";
            // 
            // txtPlacasVehiculo
            // 
            this.txtPlacasVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacasVehiculo.Location = new System.Drawing.Point(589, 12);
            this.txtPlacasVehiculo.Name = "txtPlacasVehiculo";
            this.txtPlacasVehiculo.ReadOnly = true;
            this.txtPlacasVehiculo.Size = new System.Drawing.Size(380, 29);
            this.txtPlacasVehiculo.TabIndex = 89;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(160, 121);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaEntrada.TabIndex = 88;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(589, 120);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraEntrada.TabIndex = 87;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(455, 159);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(107, 24);
            this.lblHoraSalida.TabIndex = 86;
            this.lblHoraSalida.Text = "Hora Salida";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(20, 159);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(120, 24);
            this.lblFechaSalida.TabIndex = 85;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Enabled = false;
            this.dtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(160, 156);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaSalida.TabIndex = 84;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Enabled = false;
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(589, 154);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraSalida.TabIndex = 83;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(977, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(275, 68);
            this.btnCerrar.TabIndex = 109;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VisualizarHistoricosAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 297);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbRutas);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.txtCantidadPersonas);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.txtCondutor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRegistroID);
            this.Controls.Add(this.txtClaveRegistro);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblFechaEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlacasVehiculo);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpHoraSalida);
            this.Name = "VisualizarHistoricosAutobus";
            this.Text = "VisualizarHistoricosAutobus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRutas;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRegistroID;
        private System.Windows.Forms.TextBox txtClaveRegistro;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlacasVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Button btnCerrar;
    }
}