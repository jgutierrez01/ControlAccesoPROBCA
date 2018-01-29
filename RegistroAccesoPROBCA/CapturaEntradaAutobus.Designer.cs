namespace RegistroAccesoPROBCA
{
    partial class CapturaEntradaAutobus
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
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRutas = new System.Windows.Forms.ComboBox();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(12, 43);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(98, 24);
            this.lblConductor.TabIndex = 4;
            this.lblConductor.Text = "Conductor";
            // 
            // txtCondutor
            // 
            this.txtCondutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondutor.Location = new System.Drawing.Point(152, 40);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(809, 29);
            this.txtCondutor.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1125, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 67);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(979, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 67);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(152, 146);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(809, 79);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblRegistroID
            // 
            this.lblRegistroID.AutoSize = true;
            this.lblRegistroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroID.Location = new System.Drawing.Point(12, 9);
            this.lblRegistroID.Name = "lblRegistroID";
            this.lblRegistroID.Size = new System.Drawing.Size(131, 24);
            this.lblRegistroID.TabIndex = 0;
            this.lblRegistroID.Text = "Clave Registro";
            // 
            // txtClaveRegistro
            // 
            this.txtClaveRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveRegistro.Location = new System.Drawing.Point(152, 6);
            this.txtClaveRegistro.Name = "txtClaveRegistro";
            this.txtClaveRegistro.ReadOnly = true;
            this.txtClaveRegistro.Size = new System.Drawing.Size(269, 29);
            this.txtClaveRegistro.TabIndex = 1;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(447, 112);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(121, 24);
            this.lblHoraEntrada.TabIndex = 12;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.Location = new System.Drawing.Point(12, 112);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(134, 24);
            this.lblFechaEntrada.TabIndex = 10;
            this.lblFechaEntrada.Text = "Fecha Entrada";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(447, 8);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(65, 24);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placas";
            // 
            // txtPlacasVehiculo
            // 
            this.txtPlacasVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacasVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacasVehiculo.Location = new System.Drawing.Point(581, 5);
            this.txtPlacasVehiculo.Name = "txtPlacasVehiculo";
            this.txtPlacasVehiculo.Size = new System.Drawing.Size(380, 29);
            this.txtPlacasVehiculo.TabIndex = 1;
            this.txtPlacasVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacasVehiculo_KeyPress);
            this.txtPlacasVehiculo.Leave += new System.EventHandler(this.ValidarPlacas);
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(152, 111);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaEntrada.TabIndex = 11;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(581, 110);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraEntrada.TabIndex = 13;
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.Location = new System.Drawing.Point(12, 78);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(124, 24);
            this.lblCantidadPersonas.TabIndex = 6;
            this.lblCantidadPersonas.Text = "No. Personas";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPersonas.Location = new System.Drawing.Point(152, 75);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(269, 29);
            this.txtCantidadPersonas.TabIndex = 3;
            this.txtCantidadPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPersonas_KeyPress);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(447, 80);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 24);
            this.lblRuta.TabIndex = 8;
            this.lblRuta.Text = "Ruta";
            // 
            // cmbRutas
            // 
            this.cmbRutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbRutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.Location = new System.Drawing.Point(581, 75);
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(380, 32);
            this.cmbRutas.TabIndex = 4;
            this.cmbRutas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRutas_KeyPress);
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // CapturaEntradaAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 297);
            this.Controls.Add(this.cmbRutas);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.txtCantidadPersonas);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.txtCondutor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
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
            this.MaximizeBox = false;
            this.Name = "CapturaEntradaAutobus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapturaEntradaAutobus";
            this.Load += new System.EventHandler(this.CapturaEntradaAutobus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRutas;
        private System.Windows.Forms.Timer Reloj;
    }
}