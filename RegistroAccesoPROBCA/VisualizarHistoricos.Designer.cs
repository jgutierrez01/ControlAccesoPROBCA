namespace RegistroAccesoPROBCA
{
    partial class VisualizarHistoricos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRegistroID = new System.Windows.Forms.Label();
            this.txtClaveRegistro = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cmbAsunto = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtPlacasVehiculo = new System.Windows.Forms.TextBox();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblCantPers1 = new System.Windows.Forms.Label();
            this.RegistroAccesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroAccesoID,
            this.Placa,
            this.Gafete,
            this.Nombre,
            this.FechaEntrada,
            this.FechaSalida});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 315);
            this.dataGridView1.TabIndex = 75;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(979, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(275, 68);
            this.btnCerrar.TabIndex = 74;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(150, 189);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(809, 44);
            this.txtDescripcion.TabIndex = 72;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(10, 192);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 71;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblRegistroID
            // 
            this.lblRegistroID.AutoSize = true;
            this.lblRegistroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroID.Location = new System.Drawing.Point(10, 13);
            this.lblRegistroID.Name = "lblRegistroID";
            this.lblRegistroID.Size = new System.Drawing.Size(131, 24);
            this.lblRegistroID.TabIndex = 70;
            this.lblRegistroID.Text = "Clave Registro";
            // 
            // txtClaveRegistro
            // 
            this.txtClaveRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveRegistro.Location = new System.Drawing.Point(150, 10);
            this.txtClaveRegistro.Name = "txtClaveRegistro";
            this.txtClaveRegistro.ReadOnly = true;
            this.txtClaveRegistro.Size = new System.Drawing.Size(269, 29);
            this.txtClaveRegistro.TabIndex = 69;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(445, 50);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(128, 24);
            this.lblDepartamento.TabIndex = 68;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(10, 50);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(69, 24);
            this.lblAsunto.TabIndex = 67;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(445, 119);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(121, 24);
            this.lblHoraEntrada.TabIndex = 66;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.Location = new System.Drawing.Point(10, 122);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(134, 24);
            this.lblFechaEntrada.TabIndex = 65;
            this.lblFechaEntrada.Text = "Fecha Entrada";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(445, 12);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(65, 24);
            this.lblPlaca.TabIndex = 64;
            this.lblPlaca.Text = "Placas";
            // 
            // cmbAsunto
            // 
            this.cmbAsunto.Enabled = false;
            this.cmbAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsunto.FormattingEnabled = true;
            this.cmbAsunto.Items.AddRange(new object[] {
            "Entrega de Insumos",
            "Subcontratista",
            "Proveedores",
            "Visita",
            "Entrevista"});
            this.cmbAsunto.Location = new System.Drawing.Point(150, 45);
            this.cmbAsunto.Name = "cmbAsunto";
            this.cmbAsunto.Size = new System.Drawing.Size(269, 32);
            this.cmbAsunto.TabIndex = 63;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Administración",
            "Calidad",
            "Compras",
            "Control de Documentos",
            "Control de Proyectos",
            "Dirección",
            "Ingenieria",
            "Materiales",
            "Otros",
            "Producción",
            "Recursos Humanos",
            "Sistemas",
            "Talleres"});
            this.cmbDepartamento.Location = new System.Drawing.Point(579, 44);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(380, 32);
            this.cmbDepartamento.TabIndex = 62;
            // 
            // txtPlacasVehiculo
            // 
            this.txtPlacasVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacasVehiculo.Location = new System.Drawing.Point(579, 9);
            this.txtPlacasVehiculo.Name = "txtPlacasVehiculo";
            this.txtPlacasVehiculo.ReadOnly = true;
            this.txtPlacasVehiculo.Size = new System.Drawing.Size(380, 29);
            this.txtPlacasVehiculo.TabIndex = 61;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(150, 119);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaEntrada.TabIndex = 60;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(579, 118);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraEntrada.TabIndex = 59;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(445, 157);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(107, 24);
            this.lblHoraSalida.TabIndex = 58;
            this.lblHoraSalida.Text = "Hora Salida";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(10, 157);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(120, 24);
            this.lblFechaSalida.TabIndex = 57;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Enabled = false;
            this.dtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(150, 154);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(269, 29);
            this.dtpFechaSalida.TabIndex = 56;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Enabled = false;
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(579, 152);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraSalida.TabIndex = 55;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(10, 86);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(98, 24);
            this.lblConductor.TabIndex = 77;
            this.lblConductor.Text = "Conductor";
            // 
            // txtCondutor
            // 
            this.txtCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondutor.Location = new System.Drawing.Point(150, 83);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.ReadOnly = true;
            this.txtCondutor.Size = new System.Drawing.Size(809, 29);
            this.txtCondutor.TabIndex = 76;
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.Location = new System.Drawing.Point(1078, 112);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(81, 24);
            this.lblCantidadPersonas.TabIndex = 79;
            this.lblCantidadPersonas.Text = "visitan: 0";
            // 
            // lblCantPers1
            // 
            this.lblCantPers1.AutoSize = true;
            this.lblCantPers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPers1.Location = new System.Drawing.Point(985, 88);
            this.lblCantPers1.Name = "lblCantPers1";
            this.lblCantPers1.Size = new System.Drawing.Size(269, 24);
            this.lblCantPers1.TabIndex = 78;
            this.lblCantPers1.Text = "Cantidad de Personas que nos";
            // 
            // RegistroAccesoID
            // 
            this.RegistroAccesoID.DataPropertyName = "RegistroAccesoID";
            this.RegistroAccesoID.HeaderText = "Acceso ID";
            this.RegistroAccesoID.Name = "RegistroAccesoID";
            this.RegistroAccesoID.ReadOnly = true;
            this.RegistroAccesoID.Visible = false;
            this.RegistroAccesoID.Width = 120;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Visible = false;
            this.Placa.Width = 150;
            // 
            // Gafete
            // 
            this.Gafete.DataPropertyName = "Gafete";
            this.Gafete.HeaderText = "Gafete";
            this.Gafete.Name = "Gafete";
            this.Gafete.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Personas que Ingresan";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 700;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.DataPropertyName = "FechaEntrada";
            this.FechaEntrada.HeaderText = "Fecha Entrada";
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.ReadOnly = true;
            this.FechaEntrada.Width = 200;
            // 
            // FechaSalida
            // 
            this.FechaSalida.DataPropertyName = "FechaSalida";
            this.FechaSalida.HeaderText = "Fecha Salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            this.FechaSalida.Width = 200;
            // 
            // VisualizarHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 562);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.lblCantPers1);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.txtCondutor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRegistroID);
            this.Controls.Add(this.txtClaveRegistro);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblFechaEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.cmbAsunto);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtPlacasVehiculo);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpHoraSalida);
            this.Name = "VisualizarHistoricos";
            this.Text = "VisualizarHistoricos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRegistroID;
        private System.Windows.Forms.TextBox txtClaveRegistro;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cmbAsunto;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtPlacasVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Label lblCantPers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAccesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
    }
}