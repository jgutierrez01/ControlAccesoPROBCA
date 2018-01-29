namespace RegistroAccesoPROBCA
{
    partial class EntradaDePersonal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbAsunto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.controlAccesoGETDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtGafete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCompania = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.txtRegistroAccesoID = new System.Windows.Forms.TextBox();
            this.txtRegistroPersonasID = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(580, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(458, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTextoCampoNombre);
            // 
            // cmbAsunto
            // 
            this.cmbAsunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbAsunto.Items.AddRange(new object[] {
            "",
            "CLIENTE",
            "PROVEEDOR",
            "SUBCONTRATISTA",
            "VISITA"});
            this.cmbAsunto.Location = new System.Drawing.Point(133, 99);
            this.cmbAsunto.Name = "cmbAsunto";
            this.cmbAsunto.Size = new System.Drawing.Size(395, 32);
            this.cmbAsunto.TabIndex = 4;
            this.cmbAsunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(556, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Departamento";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAsunto.Location = new System.Drawing.Point(32, 107);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(69, 24);
            this.lblAsunto.TabIndex = 1;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNombre.Location = new System.Drawing.Point(475, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(690, 99);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(348, 32);
            this.cmbDepartamento.TabIndex = 5;
            this.cmbDepartamento.ValueMember = "DepartamentoID";
            this.cmbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gafete";
            // 
            // txtGafete
            // 
            this.txtGafete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGafete.Location = new System.Drawing.Point(133, 49);
            this.txtGafete.Name = "txtGafete";
            this.txtGafete.Size = new System.Drawing.Size(307, 30);
            this.txtGafete.TabIndex = 2;
            this.txtGafete.Enter += new System.EventHandler(this.BorrarGafete);
            this.txtGafete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarGafete);
            this.txtGafete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaCodigoGafete);
            this.txtGafete.Leave += new System.EventHandler(this.ValidarCodigoGafeteLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Compañía";
            // 
            // cmbCompania
            // 
            this.cmbCompania.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.Location = new System.Drawing.Point(133, 146);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(906, 32);
            this.cmbCompania.TabIndex = 6;
            this.cmbCompania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(133, 196);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(906, 29);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(28, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(501, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hora Entrada";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpFechaEntrada.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(183, 249);
            this.dtpFechaEntrada.MinDate = new System.DateTime(2017, 8, 31, 0, 0, 0, 0);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(230, 29);
            this.dtpFechaEntrada.TabIndex = 15;
            this.dtpFechaEntrada.Value = new System.DateTime(2017, 8, 31, 18, 30, 31, 0);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpHoraEntrada.CustomFormat = "HH:mm:ss";
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(648, 248);
            this.dtpHoraEntrada.MinDate = new System.DateTime(2017, 8, 31, 18, 34, 10, 0);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(254, 29);
            this.dtpHoraEntrada.TabIndex = 16;
            this.dtpHoraEntrada.Value = new System.DateTime(2017, 8, 31, 19, 2, 26, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(356, 297);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 67);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(553, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 67);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // txtRegistroAccesoID
            // 
            this.txtRegistroAccesoID.Location = new System.Drawing.Point(936, 257);
            this.txtRegistroAccesoID.Name = "txtRegistroAccesoID";
            this.txtRegistroAccesoID.Size = new System.Drawing.Size(102, 20);
            this.txtRegistroAccesoID.TabIndex = 17;
            this.txtRegistroAccesoID.Visible = false;
            // 
            // txtRegistroPersonasID
            // 
            this.txtRegistroPersonasID.Location = new System.Drawing.Point(937, 284);
            this.txtRegistroPersonasID.Name = "txtRegistroPersonasID";
            this.txtRegistroPersonasID.Size = new System.Drawing.Size(102, 20);
            this.txtRegistroPersonasID.TabIndex = 18;
            this.txtRegistroPersonasID.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(925, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chkEmpleado.Location = new System.Drawing.Point(36, 16);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(149, 29);
            this.chkEmpleado.TabIndex = 1;
            this.chkEmpleado.Text = "Es Empleado";
            this.chkEmpleado.UseVisualStyleBackColor = true;
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.chkEmpleado_CheckedChanged);
            // EntradaDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 407);
            this.Controls.Add(this.chkEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtRegistroPersonasID);
            this.Controls.Add(this.txtRegistroAccesoID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGafete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbAsunto);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "EntradaDePersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada De Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGafete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCompania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.TextBox txtRegistroAccesoID;
        private System.Windows.Forms.TextBox txtRegistroPersonasID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkEmpleado;
        private System.Windows.Forms.BindingSource controlAccesoGETDepartamentosBindingSource;
    }
}