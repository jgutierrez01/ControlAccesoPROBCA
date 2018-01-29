namespace RegistroAccesoPROBCA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtTarjetonHistorico = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.cmbAsunto = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RegistroAccesoID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPeaton1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeton1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAutobus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtGafeteBuscar = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioGafete = new System.Windows.Forms.RadioButton();
            this.radioTarjeton = new System.Windows.Forms.RadioButton();
            this.txtTarjeton = new System.Windows.Forms.TextBox();
            this.lblTitleBusqueda = new System.Windows.Forms.Label();
            this.btnSalidaPersonal = new System.Windows.Forms.Button();
            this.btnEntradaPersonal = new System.Windows.Forms.Button();
            this.btnFiltrarActuales = new System.Windows.Forms.Button();
            this.btnEntradaAutobus = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistroAccesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroPersonasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPeaton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAutobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHistoricoPersonas = new System.Windows.Forms.TabControl();
            this.RelojRefrescaGrid = new System.Windows.Forms.Timer(this.components);
            this.TempoRefrescaHistorico = new System.Windows.Forms.Timer(this.components);
            this.btnActualizarInfoGrid1 = new System.Windows.Forms.Button();
            this.btnActualizarInfoGrid2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabHistoricoPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroAccesoPROBCA.Properties.Resources.PROBCA;
            this.pictureBox1.Location = new System.Drawing.Point(993, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizarInfoGrid2);
            this.tabPage2.Controls.Add(this.lblPlaca);
            this.tabPage2.Controls.Add(this.txtTarjetonHistorico);
            this.tabPage2.Controls.Add(this.lblDepartamento);
            this.tabPage2.Controls.Add(this.lblAsunto);
            this.tabPage2.Controls.Add(this.cmbAsunto);
            this.tabPage2.Controls.Add(this.cmbDepartamento);
            this.tabPage2.Controls.Add(this.lblFechaInicial);
            this.tabPage2.Controls.Add(this.lblFechaFinal);
            this.tabPage2.Controls.Add(this.btnFiltrar);
            this.tabPage2.Controls.Add(this.dtpFechaFinal);
            this.tabPage2.Controls.Add(this.dtpFechaInicial);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1251, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros de Ingresos Históricos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(879, 16);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(79, 24);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Tarjeton";
            // 
            // txtTarjetonHistorico
            // 
            this.txtTarjetonHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetonHistorico.Location = new System.Drawing.Point(964, 13);
            this.txtTarjetonHistorico.Name = "txtTarjetonHistorico";
            this.txtTarjetonHistorico.Size = new System.Drawing.Size(279, 29);
            this.txtTarjetonHistorico.TabIndex = 5;
            this.txtTarjetonHistorico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaSoloNumeros);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(370, 13);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(128, 24);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(6, 11);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(69, 24);
            this.lblAsunto.TabIndex = 0;
            this.lblAsunto.Text = "Asunto";
            // 
            // cmbAsunto
            // 
            this.cmbAsunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAsunto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsunto.FormattingEnabled = true;
            this.cmbAsunto.Items.AddRange(new object[] {
            "(TODOS)",
            "CLIENTE",
            "PROVEEDOR",
            "SUBCONTRATISTA",
            "VISITA"});
            this.cmbAsunto.Location = new System.Drawing.Point(81, 8);
            this.cmbAsunto.Name = "cmbAsunto";
            this.cmbAsunto.Size = new System.Drawing.Size(269, 32);
            this.cmbAsunto.TabIndex = 1;
            this.cmbAsunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MayusculasComboBox);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(504, 8);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(354, 32);
            this.cmbDepartamento.TabIndex = 3;
            this.cmbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MayusculasComboBox);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(7, 59);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(199, 24);
            this.lblFechaInicial.TabIndex = 6;
            this.lblFechaInicial.Text = "Fecha Entrada  Desde";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(432, 59);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(57, 24);
            this.lblFechaFinal.TabIndex = 8;
            this.lblFechaFinal.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(664, 50);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(269, 40);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar Registros";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(495, 55);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.ShowCheckBox = true;
            this.dtpFechaFinal.Size = new System.Drawing.Size(147, 29);
            this.dtpFechaFinal.TabIndex = 9;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(230, 55);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.ShowCheckBox = true;
            this.dtpFechaInicial.Size = new System.Drawing.Size(186, 29);
            this.dtpFechaInicial.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroAccesoID1,
            this.EsPeaton1,
            this.Tarjeton1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FechaSalida,
            this.HoraSalida,
            this.EsAutobus1,
            this.dataGridViewTextBoxColumn5,
            this.Asunto1});
            this.dataGridView2.Location = new System.Drawing.Point(5, 114);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1240, 381);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // RegistroAccesoID1
            // 
            this.RegistroAccesoID1.DataPropertyName = "RegistroAccesoID";
            this.RegistroAccesoID1.HeaderText = "AccesoID";
            this.RegistroAccesoID1.Name = "RegistroAccesoID1";
            this.RegistroAccesoID1.ReadOnly = true;
            this.RegistroAccesoID1.Visible = false;
            // 
            // EsPeaton1
            // 
            this.EsPeaton1.DataPropertyName = "EsPeaton1";
            this.EsPeaton1.HeaderText = "EsPeaton";
            this.EsPeaton1.Name = "EsPeaton1";
            this.EsPeaton1.ReadOnly = true;
            // 
            // Tarjeton1
            // 
            this.Tarjeton1.DataPropertyName = "Tarjeton1";
            this.Tarjeton1.HeaderText = "Tarjeton";
            this.Tarjeton1.Name = "Tarjeton1";
            this.Tarjeton1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Placa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaEntrada";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Entrada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Entrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.DataPropertyName = "FechaSalida";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaSalida.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaSalida.HeaderText = "Fecha Salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            this.FechaSalida.Width = 110;
            // 
            // HoraSalida
            // 
            this.HoraSalida.DataPropertyName = "HoraSalida";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.HoraSalida.DefaultCellStyle = dataGridViewCellStyle5;
            this.HoraSalida.HeaderText = "Hora Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // EsAutobus1
            // 
            this.EsAutobus1.DataPropertyName = "EsAutobus";
            this.EsAutobus1.HeaderText = "Es Autobús";
            this.EsAutobus1.Name = "EsAutobus1";
            this.EsAutobus1.ReadOnly = true;
            this.EsAutobus1.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 320;
            // 
            // Asunto1
            // 
            this.Asunto1.DataPropertyName = "Asunto";
            this.Asunto1.HeaderText = "Asunto";
            this.Asunto1.Name = "Asunto1";
            this.Asunto1.ReadOnly = true;
            this.Asunto1.Width = 210;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizarInfoGrid1);
            this.tabPage1.Controls.Add(this.txtGafeteBuscar);
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Controls.Add(this.txtTarjeton);
            this.tabPage1.Controls.Add(this.lblTitleBusqueda);
            this.tabPage1.Controls.Add(this.btnSalidaPersonal);
            this.tabPage1.Controls.Add(this.btnEntradaPersonal);
            this.tabPage1.Controls.Add(this.btnFiltrarActuales);
            this.tabPage1.Controls.Add(this.btnEntradaAutobus);
            this.tabPage1.Controls.Add(this.btnAgregarRegistro);
            this.tabPage1.Controls.Add(this.btnRegistrarSalida);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1251, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos Actuales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtGafeteBuscar
            // 
            this.txtGafeteBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafeteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGafeteBuscar.Location = new System.Drawing.Point(344, 88);
            this.txtGafeteBuscar.Name = "txtGafeteBuscar";
            this.txtGafeteBuscar.Size = new System.Drawing.Size(269, 29);
            this.txtGafeteBuscar.TabIndex = 16;
            this.txtGafeteBuscar.Visible = false;
            this.txtGafeteBuscar.TextChanged += new System.EventHandler(this.Buscar);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioGafete);
            this.groupBox.Controls.Add(this.radioTarjeton);
            this.groupBox.Location = new System.Drawing.Point(4, 70);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(234, 55);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            // 
            // radioGafete
            // 
            this.radioGafete.AutoSize = true;
            this.radioGafete.Location = new System.Drawing.Point(121, 17);
            this.radioGafete.Name = "radioGafete";
            this.radioGafete.Size = new System.Drawing.Size(82, 28);
            this.radioGafete.TabIndex = 15;
            this.radioGafete.TabStop = true;
            this.radioGafete.Text = "Gafete";
            this.radioGafete.UseVisualStyleBackColor = true;
            // 
            // radioTarjeton
            // 
            this.radioTarjeton.AutoSize = true;
            this.radioTarjeton.Checked = true;
            this.radioTarjeton.Location = new System.Drawing.Point(6, 17);
            this.radioTarjeton.Name = "radioTarjeton";
            this.radioTarjeton.Size = new System.Drawing.Size(97, 28);
            this.radioTarjeton.TabIndex = 14;
            this.radioTarjeton.TabStop = true;
            this.radioTarjeton.Text = "Tarjetón";
            this.radioTarjeton.UseVisualStyleBackColor = true;
            // 
            // txtTarjeton
            // 
            this.txtTarjeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeton.Location = new System.Drawing.Point(344, 88);
            this.txtTarjeton.Name = "txtTarjeton";
            this.txtTarjeton.Size = new System.Drawing.Size(269, 29);
            this.txtTarjeton.TabIndex = 11;
            this.txtTarjeton.TextChanged += new System.EventHandler(this.Buscar);
            this.txtTarjeton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarPorTarjetonEvento);
            // 
            // lblTitleBusqueda
            // 
            this.lblTitleBusqueda.AutoSize = true;
            this.lblTitleBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBusqueda.Location = new System.Drawing.Point(244, 92);
            this.lblTitleBusqueda.Name = "lblTitleBusqueda";
            this.lblTitleBusqueda.Size = new System.Drawing.Size(79, 24);
            this.lblTitleBusqueda.TabIndex = 10;
            this.lblTitleBusqueda.Text = "Tarjetón";
            // 
            // btnSalidaPersonal
            // 
            this.btnSalidaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaPersonal.Location = new System.Drawing.Point(969, 6);
            this.btnSalidaPersonal.Name = "btnSalidaPersonal";
            this.btnSalidaPersonal.Size = new System.Drawing.Size(183, 58);
            this.btnSalidaPersonal.TabIndex = 9;
            this.btnSalidaPersonal.Text = "Salida Peatonal";
            this.btnSalidaPersonal.UseVisualStyleBackColor = true;
            this.btnSalidaPersonal.Click += new System.EventHandler(this.btnSalidaPersonal_Click);
            // 
            // btnEntradaPersonal
            // 
            this.btnEntradaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaPersonal.Location = new System.Drawing.Point(764, 6);
            this.btnEntradaPersonal.Name = "btnEntradaPersonal";
            this.btnEntradaPersonal.Size = new System.Drawing.Size(186, 58);
            this.btnEntradaPersonal.TabIndex = 8;
            this.btnEntradaPersonal.Text = "Entrada Peatonal";
            this.btnEntradaPersonal.UseVisualStyleBackColor = true;
            this.btnEntradaPersonal.Click += new System.EventHandler(this.ClickEntradaDePersonal);
            // 
            // btnFiltrarActuales
            // 
            this.btnFiltrarActuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarActuales.Location = new System.Drawing.Point(633, 88);
            this.btnFiltrarActuales.Name = "btnFiltrarActuales";
            this.btnFiltrarActuales.Size = new System.Drawing.Size(118, 32);
            this.btnFiltrarActuales.TabIndex = 5;
            this.btnFiltrarActuales.Text = "Buscar";
            this.btnFiltrarActuales.UseVisualStyleBackColor = true;
            this.btnFiltrarActuales.Click += new System.EventHandler(this.btnFiltrarActuales_Click);
            // 
            // btnEntradaAutobus
            // 
            this.btnEntradaAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaAutobus.Location = new System.Drawing.Point(203, 6);
            this.btnEntradaAutobus.Name = "btnEntradaAutobus";
            this.btnEntradaAutobus.Size = new System.Drawing.Size(221, 58);
            this.btnEntradaAutobus.TabIndex = 1;
            this.btnEntradaAutobus.Text = "Entrada Autobus";
            this.btnEntradaAutobus.UseVisualStyleBackColor = true;
            this.btnEntradaAutobus.Click += new System.EventHandler(this.btnEntradaAutobus_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.Location = new System.Drawing.Point(4, 6);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(193, 58);
            this.btnAgregarRegistro.TabIndex = 0;
            this.btnAgregarRegistro.Text = "Entrada Vehiculo";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.Location = new System.Drawing.Point(443, 6);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(231, 58);
            this.btnRegistrarSalida.TabIndex = 2;
            this.btnRegistrarSalida.Text = "Salida Vehiculo/Autobus";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroAccesoID,
            this.RegistroPersonasID,
            this.EsPeaton,
            this.EsAutobus,
            this.Tarjeton,
            this.Placa,
            this.EsConductor,
            this.Conductor,
            this.Gafete,
            this.FechaEntrada,
            this.HoraEntrada,
            this.Departamento,
            this.Asunto});
            this.dataGridView1.Location = new System.Drawing.Point(4, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 368);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarDatosPantallaPrincipal);
            // 
            // RegistroAccesoID
            // 
            this.RegistroAccesoID.DataPropertyName = "RegistroAccesoID";
            this.RegistroAccesoID.HeaderText = "AccesoID";
            this.RegistroAccesoID.Name = "RegistroAccesoID";
            this.RegistroAccesoID.ReadOnly = true;
            this.RegistroAccesoID.Visible = false;
            // 
            // RegistroPersonasID
            // 
            this.RegistroPersonasID.DataPropertyName = "RegistroPersonasID";
            this.RegistroPersonasID.HeaderText = "RegistrosPersonasID";
            this.RegistroPersonasID.Name = "RegistroPersonasID";
            this.RegistroPersonasID.ReadOnly = true;
            this.RegistroPersonasID.Visible = false;
            // 
            // EsPeaton
            // 
            this.EsPeaton.DataPropertyName = "EsPeaton";
            this.EsPeaton.HeaderText = "EsPeaton";
            this.EsPeaton.Name = "EsPeaton";
            this.EsPeaton.ReadOnly = true;
            // 
            // EsAutobus
            // 
            this.EsAutobus.DataPropertyName = "EsAutobus";
            this.EsAutobus.HeaderText = "Es Autobus";
            this.EsAutobus.Name = "EsAutobus";
            this.EsAutobus.ReadOnly = true;
            this.EsAutobus.Width = 120;
            // 
            // Tarjeton
            // 
            this.Tarjeton.DataPropertyName = "Tarjeton";
            this.Tarjeton.HeaderText = "Tarjeton";
            this.Tarjeton.Name = "Tarjeton";
            this.Tarjeton.ReadOnly = true;
            this.Tarjeton.Width = 150;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 160;
            // 
            // EsConductor
            // 
            this.EsConductor.DataPropertyName = "EsConductor";
            this.EsConductor.HeaderText = "EsConductor";
            this.EsConductor.Name = "EsConductor";
            this.EsConductor.ReadOnly = true;
            this.EsConductor.Width = 150;
            // 
            // Conductor
            // 
            this.Conductor.DataPropertyName = "Conductor";
            this.Conductor.HeaderText = "Nombre";
            this.Conductor.Name = "Conductor";
            this.Conductor.ReadOnly = true;
            this.Conductor.Width = 250;
            // 
            // Gafete
            // 
            this.Gafete.DataPropertyName = "Gafete";
            this.Gafete.HeaderText = "Gafete";
            this.Gafete.Name = "Gafete";
            this.Gafete.ReadOnly = true;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.DataPropertyName = "FechaEntrada";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.FechaEntrada.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaEntrada.HeaderText = "Fecha Entrada";
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.ReadOnly = true;
            this.FechaEntrada.Width = 170;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            this.HoraEntrada.DefaultCellStyle = dataGridViewCellStyle8;
            this.HoraEntrada.HeaderText = "Hora Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            this.HoraEntrada.Width = 150;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 200;
            // 
            // Asunto
            // 
            this.Asunto.DataPropertyName = "Asunto";
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 200;
            // 
            // tabHistoricoPersonas
            // 
            this.tabHistoricoPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHistoricoPersonas.Controls.Add(this.tabPage1);
            this.tabHistoricoPersonas.Controls.Add(this.tabPage2);
            this.tabHistoricoPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistoricoPersonas.Location = new System.Drawing.Point(3, 47);
            this.tabHistoricoPersonas.Name = "tabHistoricoPersonas";
            this.tabHistoricoPersonas.SelectedIndex = 0;
            this.tabHistoricoPersonas.Size = new System.Drawing.Size(1259, 539);
            this.tabHistoricoPersonas.TabIndex = 0;
            this.tabHistoricoPersonas.Tag = "";
            this.tabHistoricoPersonas.SelectedIndexChanged += new System.EventHandler(this.CargarHistoricos);
            // 
            // RelojRefrescaGrid
            // 
            this.RelojRefrescaGrid.Enabled = true;
            this.RelojRefrescaGrid.Interval = 20000;
            this.RelojRefrescaGrid.Tick += new System.EventHandler(this.RelojRefrescaGrid_Tick);
            // 
            // TempoRefrescaHistorico
            // 
            this.TempoRefrescaHistorico.Enabled = true;
            this.TempoRefrescaHistorico.Interval = 30000;
            this.TempoRefrescaHistorico.Tick += new System.EventHandler(this.TempoRefrescaHistorico_Tick);
            // 
            // btnActualizarInfoGrid1
            // 
            this.btnActualizarInfoGrid1.Location = new System.Drawing.Point(1033, 87);
            this.btnActualizarInfoGrid1.Name = "btnActualizarInfoGrid1";
            this.btnActualizarInfoGrid1.Size = new System.Drawing.Size(211, 34);
            this.btnActualizarInfoGrid1.TabIndex = 17;
            this.btnActualizarInfoGrid1.Text = "Actualizar Información";
            this.btnActualizarInfoGrid1.UseVisualStyleBackColor = true;
            this.btnActualizarInfoGrid1.Click += new System.EventHandler(this.btnActualizarInfoGrid1_Click);
            // 
            // btnActualizarInfoGrid2
            // 
            this.btnActualizarInfoGrid2.Location = new System.Drawing.Point(1032, 74);
            this.btnActualizarInfoGrid2.Name = "btnActualizarInfoGrid2";
            this.btnActualizarInfoGrid2.Size = new System.Drawing.Size(211, 34);
            this.btnActualizarInfoGrid2.TabIndex = 18;
            this.btnActualizarInfoGrid2.Text = "Actualizar Información";
            this.btnActualizarInfoGrid2.UseVisualStyleBackColor = true;
            this.btnActualizarInfoGrid2.Click += new System.EventHandler(this.btnActualizarInfoGrid2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabHistoricoPersonas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control Acceso PROBCA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabHistoricoPersonas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtTarjetonHistorico;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.ComboBox cmbAsunto;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalidaPersonal;
        private System.Windows.Forms.Button btnEntradaPersonal;
        private System.Windows.Forms.Button btnEntradaAutobus;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabHistoricoPersonas;
        private System.Windows.Forms.TextBox txtTarjeton;
        private System.Windows.Forms.Label lblTitleBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAccesoID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsPeaton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAutobus1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto1;
        public System.Windows.Forms.Button btnFiltrarActuales;
        private System.Windows.Forms.Timer RelojRefrescaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAccesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroPersonasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsPeaton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAutobus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.Timer TempoRefrescaHistorico;
        private System.Windows.Forms.RadioButton radioTarjeton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioGafete;
        private System.Windows.Forms.TextBox txtGafeteBuscar;
        private System.Windows.Forms.Button btnActualizarInfoGrid1;
        private System.Windows.Forms.Button btnActualizarInfoGrid2;
    }
}

