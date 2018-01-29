namespace RegistroAccesoPROBCA
{
    partial class CapturaEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturaEntrada));
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtPlacasVehiculo = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbAsunto = new System.Windows.Forms.ComboBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistroAccesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroPersonasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsEmpleado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.lblCantPers1 = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblTarjeton = new System.Windows.Forms.Label();
            this.txtTarjeton = new System.Windows.Forms.TextBox();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.lblGafete = new System.Windows.Forms.Label();
            this.txtGafeteChofer = new System.Windows.Forms.TextBox();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.txtRegistroAccesoID = new System.Windows.Forms.TextBox();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.txtRegistroPersonasID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Enabled = false;
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(609, 187);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(380, 29);
            this.dtpHoraEntrada.TabIndex = 23;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Enabled = false;
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(148, 191);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(289, 29);
            this.dtpFechaEntrada.TabIndex = 24;
            // 
            // txtPlacasVehiculo
            // 
            this.txtPlacasVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacasVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacasVehiculo.Location = new System.Drawing.Point(577, 3);
            this.txtPlacasVehiculo.Name = "txtPlacasVehiculo";
            this.txtPlacasVehiculo.Size = new System.Drawing.Size(412, 29);
            this.txtPlacasVehiculo.TabIndex = 2;
            this.txtPlacasVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacasVehiculo_KeyPress);
            this.txtPlacasVehiculo.Leave += new System.EventHandler(this.txtPlacasVehiculo_Leave);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(577, 100);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(412, 32);
            this.cmbDepartamento.TabIndex = 7;
            this.cmbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // cmbAsunto
            // 
            this.cmbAsunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAsunto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsunto.FormattingEnabled = true;
            this.cmbAsunto.Items.AddRange(new object[] {
            "",
            "CLIENTE",
            "PROVEEDOR",
            "SUBCONTRATISTA",
            "VISITA"});
            this.cmbAsunto.Location = new System.Drawing.Point(148, 101);
            this.cmbAsunto.Name = "cmbAsunto";
            this.cmbAsunto.Size = new System.Drawing.Size(289, 32);
            this.cmbAsunto.TabIndex = 6;
            this.cmbAsunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(506, 3);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(65, 24);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placas";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.Location = new System.Drawing.Point(8, 192);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(134, 24);
            this.lblFechaEntrada.TabIndex = 10;
            this.lblFechaEntrada.Text = "Fecha Entrada";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(475, 191);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(121, 24);
            this.lblHoraEntrada.TabIndex = 12;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(8, 106);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(69, 24);
            this.lblAsunto.TabIndex = 6;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(443, 106);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(128, 24);
            this.lblDepartamento.TabIndex = 8;
            this.lblDepartamento.Text = "Departamento";
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
            this.RegistroPersonasID,
            this.EsEmpleado,
            this.Placa,
            this.Gafete,
            this.Nombre,
            this.FechaEntrada,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 329);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.EliminarPasajeros);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValidarGrid_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ReplicaNombreGafeteGridToForm);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewError);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // RegistroAccesoID
            // 
            this.RegistroAccesoID.DataPropertyName = "RegistroAccesoID";
            this.RegistroAccesoID.HeaderText = "Acceso ID";
            this.RegistroAccesoID.Name = "RegistroAccesoID";
            this.RegistroAccesoID.Visible = false;
            this.RegistroAccesoID.Width = 140;
            // 
            // RegistroPersonasID
            // 
            this.RegistroPersonasID.DataPropertyName = "RegistroPersonasID";
            this.RegistroPersonasID.HeaderText = "RegistroPersonasID";
            this.RegistroPersonasID.Name = "RegistroPersonasID";
            this.RegistroPersonasID.ReadOnly = true;
            this.RegistroPersonasID.Visible = false;
            // 
            // EsEmpleado
            // 
            this.EsEmpleado.DataPropertyName = "EsEmpleado";
            this.EsEmpleado.HeaderText = "Es Empleado";
            this.EsEmpleado.Name = "EsEmpleado";
            this.EsEmpleado.Width = 150;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Visible = false;
            this.Placa.Width = 150;
            // 
            // Gafete
            // 
            this.Gafete.DataPropertyName = "Gafete";
            this.Gafete.HeaderText = "Gafete";
            this.Gafete.Name = "Gafete";
            this.Gafete.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Personas que Ingresan";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 900;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.DataPropertyName = "FechaEntrada";
            this.FechaEntrada.HeaderText = "FechaEntrada";
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.ReadOnly = true;
            this.FechaEntrada.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Eliminar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 232);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(148, 229);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(841, 29);
            this.txtDescripcion.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1017, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 67);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1171, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 67);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1071, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(211, 41);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Persona";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(443, 59);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(98, 24);
            this.lblConductor.TabIndex = 9;
            this.lblConductor.Text = "Conductor";
            // 
            // txtCondutor
            // 
            this.txtCondutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondutor.Location = new System.Drawing.Point(547, 56);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(442, 29);
            this.txtCondutor.TabIndex = 5;
            this.txtCondutor.TextChanged += new System.EventHandler(this.txtCondutor_TextChanged);
            this.txtCondutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaTextoConductor);
            // 
            // lblCantPers1
            // 
            this.lblCantPers1.AutoSize = true;
            this.lblCantPers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPers1.Location = new System.Drawing.Point(1013, 84);
            this.lblCantPers1.Name = "lblCantPers1";
            this.lblCantPers1.Size = new System.Drawing.Size(269, 24);
            this.lblCantPers1.TabIndex = 21;
            this.lblCantPers1.Text = "Cantidad de Personas que nos";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.Location = new System.Drawing.Point(1118, 108);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(81, 24);
            this.lblCantidadPersonas.TabIndex = 22;
            this.lblCantidadPersonas.Text = "visitan: 0";
            // 
            // lblTarjeton
            // 
            this.lblTarjeton.AutoSize = true;
            this.lblTarjeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeton.Location = new System.Drawing.Point(14, 3);
            this.lblTarjeton.Name = "lblTarjeton";
            this.lblTarjeton.Size = new System.Drawing.Size(79, 24);
            this.lblTarjeton.TabIndex = 4;
            this.lblTarjeton.Text = "Tarjetón";
            // 
            // txtTarjeton
            // 
            this.txtTarjeton.AcceptsTab = true;
            this.txtTarjeton.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTarjeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTarjeton.Location = new System.Drawing.Point(148, 3);
            this.txtTarjeton.Name = "txtTarjeton";
            this.txtTarjeton.Size = new System.Drawing.Size(289, 29);
            this.txtTarjeton.TabIndex = 1;
            this.txtTarjeton.Enter += new System.EventHandler(this.BorraDatosTarjeton);
            this.txtTarjeton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaSoloNumeros);
            this.txtTarjeton.Leave += new System.EventHandler(this.ValidaTarjeton);
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompania.Location = new System.Drawing.Point(8, 157);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(96, 24);
            this.lblCompania.TabIndex = 14;
            this.lblCompania.Text = "Compañía";
            // 
            // txtCompania
            // 
            this.txtCompania.AcceptsTab = true;
            this.txtCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompania.Location = new System.Drawing.Point(148, 152);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(841, 29);
            this.txtCompania.TabIndex = 8;
            // 
            // lblGafete
            // 
            this.lblGafete.AutoSize = true;
            this.lblGafete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGafete.Location = new System.Drawing.Point(177, 58);
            this.lblGafete.Name = "lblGafete";
            this.lblGafete.Size = new System.Drawing.Size(64, 24);
            this.lblGafete.TabIndex = 12;
            this.lblGafete.Text = "Gafete";
            // 
            // txtGafeteChofer
            // 
            this.txtGafeteChofer.AcceptsTab = true;
            this.txtGafeteChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafeteChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGafeteChofer.Location = new System.Drawing.Point(247, 55);
            this.txtGafeteChofer.Name = "txtGafeteChofer";
            this.txtGafeteChofer.Size = new System.Drawing.Size(190, 29);
            this.txtGafeteChofer.TabIndex = 4;
            this.txtGafeteChofer.TextChanged += new System.EventHandler(this.ReplicaGafeteFormToGrid);
            this.txtGafeteChofer.Enter += new System.EventHandler(this.BorrarCampoGafete);
            this.txtGafeteChofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGafeteChofer_KeyPress);
            this.txtGafeteChofer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaCodigoGafete);
            this.txtGafeteChofer.Leave += new System.EventHandler(this.ValidaGafeteForm);
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // txtRegistroAccesoID
            // 
            this.txtRegistroAccesoID.Location = new System.Drawing.Point(1070, 187);
            this.txtRegistroAccesoID.Name = "txtRegistroAccesoID";
            this.txtRegistroAccesoID.Size = new System.Drawing.Size(101, 20);
            this.txtRegistroAccesoID.TabIndex = 25;
            this.txtRegistroAccesoID.Visible = false;
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chkEmpleado.Location = new System.Drawing.Point(12, 55);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEmpleado.Size = new System.Drawing.Size(149, 29);
            this.chkEmpleado.TabIndex = 3;
            this.chkEmpleado.Text = "Es Empleado";
            this.chkEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEmpleado.UseVisualStyleBackColor = true;
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.chkEmpleado_CheckedChanged);
            // 
            // txtRegistroPersonasID
            // 
            this.txtRegistroPersonasID.Location = new System.Drawing.Point(1071, 210);
            this.txtRegistroPersonasID.Name = "txtRegistroPersonasID";
            this.txtRegistroPersonasID.Size = new System.Drawing.Size(101, 20);
            this.txtRegistroPersonasID.TabIndex = 26;
            this.txtRegistroPersonasID.Visible = false;
            // 
            // CapturaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 610);
            this.Controls.Add(this.txtRegistroPersonasID);
            this.Controls.Add(this.chkEmpleado);
            this.Controls.Add(this.txtRegistroAccesoID);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.lblCantPers1);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.txtCondutor);
            this.Controls.Add(this.txtGafeteChofer);
            this.Controls.Add(this.lblGafete);
            this.Controls.Add(this.txtCompania);
            this.Controls.Add(this.lblCompania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblFechaEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.cmbAsunto);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtPlacasVehiculo);
            this.Controls.Add(this.txtTarjeton);
            this.Controls.Add(this.lblTarjeton);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CapturaEntrada";
            this.Text = "Entrada Vehicular";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CapturaEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.TextBox txtPlacasVehiculo;
        private System.Windows.Forms.Label lblTarjeton;
        private System.Windows.Forms.TextBox txtTarjeton;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbAsunto;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.Label lblGafete;
        private System.Windows.Forms.TextBox txtGafeteChofer;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label lblCantPers1;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.TextBox txtRegistroAccesoID;
        private System.Windows.Forms.CheckBox chkEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAccesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroPersonasID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox txtRegistroPersonasID;
    }
}