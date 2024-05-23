namespace procat
{
    partial class interfece
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfece));
            this.prokatDataSet = new procat.prokatDataSet();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new procat.prokatDataSetTableAdapters.ZakazTableAdapter();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikiTableAdapter = new procat.prokatDataSetTableAdapters.SotrudnikiTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new procat.prokatDataSetTableAdapters.ClientTableAdapter();
            this.oborudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudTableAdapter = new procat.prokatDataSetTableAdapters.OborudTableAdapter();
            this.uslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugTableAdapter = new procat.prokatDataSetTableAdapters.UslugTableAdapter();
            this.historyVhodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.history_VhodTableAdapter = new procat.prokatDataSetTableAdapters.History_VhodTableAdapter();
            this.shtrihKodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shtrih_KodTableAdapter = new procat.prokatDataSetTableAdapters.Shtrih_KodTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSotrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVhodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeVhodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricerubVHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOborudDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idOborudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kollVNalichiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idSotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoSotrDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyVhodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtrihKodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prokatDataSet
            // 
            this.prokatDataSet.DataSetName = "prokatDataSet";
            this.prokatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.prokatDataSet;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.prokatDataSet;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.prokatDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // oborudBindingSource
            // 
            this.oborudBindingSource.DataMember = "Oborud";
            this.oborudBindingSource.DataSource = this.prokatDataSet;
            // 
            // oborudTableAdapter
            // 
            this.oborudTableAdapter.ClearBeforeFill = true;
            // 
            // uslugBindingSource
            // 
            this.uslugBindingSource.DataMember = "Uslug";
            this.uslugBindingSource.DataSource = this.prokatDataSet;
            // 
            // uslugTableAdapter
            // 
            this.uslugTableAdapter.ClearBeforeFill = true;
            // 
            // historyVhodBindingSource
            // 
            this.historyVhodBindingSource.DataMember = "History_Vhod";
            this.historyVhodBindingSource.DataSource = this.prokatDataSet;
            // 
            // history_VhodTableAdapter
            // 
            this.history_VhodTableAdapter.ClearBeforeFill = true;
            // 
            // shtrihKodBindingSource
            // 
            this.shtrihKodBindingSource.DataMember = "Shtrih_Kod";
            this.shtrihKodBindingSource.DataSource = this.prokatDataSet;
            // 
            // shtrih_KodTableAdapter
            // 
            this.shtrih_KodTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администатор:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(823, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 257);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(960, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "132";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1029, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "Выйти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(745, 384);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "История входа";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.idSotrDataGridViewTextBoxColumn1,
            this.dateVhodDataGridViewTextBoxColumn,
            this.typeVhodDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.historyVhodBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(550, 233);
            this.dataGridView6.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idSotrDataGridViewTextBoxColumn1
            // 
            this.idSotrDataGridViewTextBoxColumn1.DataPropertyName = "idSotr";
            this.idSotrDataGridViewTextBoxColumn1.HeaderText = "idSotr";
            this.idSotrDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idSotrDataGridViewTextBoxColumn1.Name = "idSotrDataGridViewTextBoxColumn1";
            this.idSotrDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateVhodDataGridViewTextBoxColumn
            // 
            this.dateVhodDataGridViewTextBoxColumn.DataPropertyName = "Date_Vhod";
            this.dateVhodDataGridViewTextBoxColumn.HeaderText = "Date_Vhod";
            this.dateVhodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateVhodDataGridViewTextBoxColumn.Name = "dateVhodDataGridViewTextBoxColumn";
            this.dateVhodDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeVhodDataGridViewTextBoxColumn
            // 
            this.typeVhodDataGridViewTextBoxColumn.DataPropertyName = "typeVhod";
            this.typeVhodDataGridViewTextBoxColumn.HeaderText = "typeVhod";
            this.typeVhodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeVhodDataGridViewTextBoxColumn.Name = "typeVhodDataGridViewTextBoxColumn";
            this.typeVhodDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(745, 384);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Услуги";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUslugDataGridViewTextBoxColumn,
            this.nameUslugDataGridViewTextBoxColumn,
            this.kodUslugDataGridViewTextBoxColumn,
            this.pricerubVHourDataGridViewTextBoxColumn,
            this.idOborudDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.uslugBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(675, 196);
            this.dataGridView5.TabIndex = 0;
            // 
            // idUslugDataGridViewTextBoxColumn
            // 
            this.idUslugDataGridViewTextBoxColumn.DataPropertyName = "idUslug";
            this.idUslugDataGridViewTextBoxColumn.HeaderText = "idUslug";
            this.idUslugDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUslugDataGridViewTextBoxColumn.Name = "idUslugDataGridViewTextBoxColumn";
            this.idUslugDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameUslugDataGridViewTextBoxColumn
            // 
            this.nameUslugDataGridViewTextBoxColumn.DataPropertyName = "nameUslug";
            this.nameUslugDataGridViewTextBoxColumn.HeaderText = "nameUslug";
            this.nameUslugDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameUslugDataGridViewTextBoxColumn.Name = "nameUslugDataGridViewTextBoxColumn";
            this.nameUslugDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodUslugDataGridViewTextBoxColumn
            // 
            this.kodUslugDataGridViewTextBoxColumn.DataPropertyName = "Kod_Uslug";
            this.kodUslugDataGridViewTextBoxColumn.HeaderText = "Kod_Uslug";
            this.kodUslugDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodUslugDataGridViewTextBoxColumn.Name = "kodUslugDataGridViewTextBoxColumn";
            this.kodUslugDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricerubVHourDataGridViewTextBoxColumn
            // 
            this.pricerubVHourDataGridViewTextBoxColumn.DataPropertyName = "Price(rubVHour)";
            this.pricerubVHourDataGridViewTextBoxColumn.HeaderText = "Price(rubVHour)";
            this.pricerubVHourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricerubVHourDataGridViewTextBoxColumn.Name = "pricerubVHourDataGridViewTextBoxColumn";
            this.pricerubVHourDataGridViewTextBoxColumn.Width = 125;
            // 
            // idOborudDataGridViewTextBoxColumn1
            // 
            this.idOborudDataGridViewTextBoxColumn1.DataPropertyName = "idOborud";
            this.idOborudDataGridViewTextBoxColumn1.HeaderText = "idOborud";
            this.idOborudDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idOborudDataGridViewTextBoxColumn1.Name = "idOborudDataGridViewTextBoxColumn1";
            this.idOborudDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(745, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Оборудование";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOborudDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.kollVNalichiiDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.oborudBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(424, 226);
            this.dataGridView4.TabIndex = 0;
            // 
            // idOborudDataGridViewTextBoxColumn
            // 
            this.idOborudDataGridViewTextBoxColumn.DataPropertyName = "idOborud";
            this.idOborudDataGridViewTextBoxColumn.HeaderText = "idOborud";
            this.idOborudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOborudDataGridViewTextBoxColumn.Name = "idOborudDataGridViewTextBoxColumn";
            this.idOborudDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOborudDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // kollVNalichiiDataGridViewTextBoxColumn
            // 
            this.kollVNalichiiDataGridViewTextBoxColumn.DataPropertyName = "KollVNalichii";
            this.kollVNalichiiDataGridViewTextBoxColumn.HeaderText = "KollVNalichii";
            this.kollVNalichiiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kollVNalichiiDataGridViewTextBoxColumn.Name = "kollVNalichiiDataGridViewTextBoxColumn";
            this.kollVNalichiiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSotrDataGridViewTextBoxColumn,
            this.doljnostDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fotoSotrDataGridViewImageColumn});
            this.dataGridView2.DataSource = this.sotrudnikiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(745, 238);
            this.dataGridView2.TabIndex = 0;
            // 
            // idSotrDataGridViewTextBoxColumn
            // 
            this.idSotrDataGridViewTextBoxColumn.DataPropertyName = "idSotr";
            this.idSotrDataGridViewTextBoxColumn.HeaderText = "idSotr";
            this.idSotrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSotrDataGridViewTextBoxColumn.Name = "idSotrDataGridViewTextBoxColumn";
            this.idSotrDataGridViewTextBoxColumn.Width = 125;
            // 
            // doljnostDataGridViewTextBoxColumn
            // 
            this.doljnostDataGridViewTextBoxColumn.DataPropertyName = "Doljnost";
            this.doljnostDataGridViewTextBoxColumn.HeaderText = "Doljnost";
            this.doljnostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doljnostDataGridViewTextBoxColumn.Name = "doljnostDataGridViewTextBoxColumn";
            this.doljnostDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotoSotrDataGridViewImageColumn
            // 
            this.fotoSotrDataGridViewImageColumn.DataPropertyName = "fotoSotr";
            this.fotoSotrDataGridViewImageColumn.HeaderText = "fotoSotr";
            this.fotoSotrDataGridViewImageColumn.MinimumWidth = 6;
            this.fotoSotrDataGridViewImageColumn.Name = "fotoSotrDataGridViewImageColumn";
            this.fotoSotrDataGridViewImageColumn.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1110, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // interfece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "interfece";
            this.Text = "Администатор";
            this.Load += new System.EventHandler(this.interfece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyVhodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtrihKodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private prokatDataSet prokatDataSet;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private prokatDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private prokatDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private prokatDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource oborudBindingSource;
        private prokatDataSetTableAdapters.OborudTableAdapter oborudTableAdapter;
        private System.Windows.Forms.BindingSource uslugBindingSource;
        private prokatDataSetTableAdapters.UslugTableAdapter uslugTableAdapter;
        private System.Windows.Forms.BindingSource historyVhodBindingSource;
        private prokatDataSetTableAdapters.History_VhodTableAdapter history_VhodTableAdapter;
        private System.Windows.Forms.BindingSource shtrihKodBindingSource;
        private prokatDataSetTableAdapters.Shtrih_KodTableAdapter shtrih_KodTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVhodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeVhodDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricerubVHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOborudDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOborudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kollVNalichiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doljnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoSotrDataGridViewImageColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}