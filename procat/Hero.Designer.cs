namespace procat
{
    partial class Hero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hero));
            this.prokatDataSet = new procat.prokatDataSet();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new procat.prokatDataSetTableAdapters.ZakazTableAdapter();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikiTableAdapter = new procat.prokatDataSetTableAdapters.SotrudnikiTableAdapter();
            this.zakazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodZakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeZakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeProkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressInfoZakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // zakazBindingSource1
            // 
            this.zakazBindingSource1.DataMember = "Zakaz";
            this.zakazBindingSource1.DataSource = this.prokatDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(932, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 56);
            this.button4.TabIndex = 13;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 318);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Старший смены:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kodZakazDataGridViewTextBoxColumn,
            this.datecreateDataGridViewTextBoxColumn,
            this.timeZakazDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.uslugsDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateCloseDataGridViewTextBoxColumn,
            this.timeProkatDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.adressInfoZakazDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodZakazDataGridViewTextBoxColumn
            // 
            this.kodZakazDataGridViewTextBoxColumn.DataPropertyName = "kodZakaz";
            this.kodZakazDataGridViewTextBoxColumn.HeaderText = "kodZakaz";
            this.kodZakazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodZakazDataGridViewTextBoxColumn.Name = "kodZakazDataGridViewTextBoxColumn";
            this.kodZakazDataGridViewTextBoxColumn.Width = 125;
            // 
            // datecreateDataGridViewTextBoxColumn
            // 
            this.datecreateDataGridViewTextBoxColumn.DataPropertyName = "datecreate";
            this.datecreateDataGridViewTextBoxColumn.HeaderText = "datecreate";
            this.datecreateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datecreateDataGridViewTextBoxColumn.Name = "datecreateDataGridViewTextBoxColumn";
            this.datecreateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeZakazDataGridViewTextBoxColumn
            // 
            this.timeZakazDataGridViewTextBoxColumn.DataPropertyName = "timeZakaz";
            this.timeZakazDataGridViewTextBoxColumn.HeaderText = "timeZakaz";
            this.timeZakazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeZakazDataGridViewTextBoxColumn.Name = "timeZakazDataGridViewTextBoxColumn";
            this.timeZakazDataGridViewTextBoxColumn.Width = 125;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "idClient";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // uslugsDataGridViewTextBoxColumn
            // 
            this.uslugsDataGridViewTextBoxColumn.DataPropertyName = "Uslugs";
            this.uslugsDataGridViewTextBoxColumn.HeaderText = "Uslugs";
            this.uslugsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uslugsDataGridViewTextBoxColumn.Name = "uslugsDataGridViewTextBoxColumn";
            this.uslugsDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCloseDataGridViewTextBoxColumn
            // 
            this.dateCloseDataGridViewTextBoxColumn.DataPropertyName = "dateClose";
            this.dateCloseDataGridViewTextBoxColumn.HeaderText = "dateClose";
            this.dateCloseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCloseDataGridViewTextBoxColumn.Name = "dateCloseDataGridViewTextBoxColumn";
            this.dateCloseDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeProkatDataGridViewTextBoxColumn
            // 
            this.timeProkatDataGridViewTextBoxColumn.DataPropertyName = "timeProkat";
            this.timeProkatDataGridViewTextBoxColumn.HeaderText = "timeProkat";
            this.timeProkatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeProkatDataGridViewTextBoxColumn.Name = "timeProkatDataGridViewTextBoxColumn";
            this.timeProkatDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressInfoZakazDataGridViewTextBoxColumn
            // 
            this.adressInfoZakazDataGridViewTextBoxColumn.DataPropertyName = "adressInfoZakaz";
            this.adressInfoZakazDataGridViewTextBoxColumn.HeaderText = "adressInfoZakaz";
            this.adressInfoZakazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressInfoZakazDataGridViewTextBoxColumn.Name = "adressInfoZakazDataGridViewTextBoxColumn";
            this.adressInfoZakazDataGridViewTextBoxColumn.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 56);
            this.button5.TabIndex = 14;
            this.button5.Text = "Принять товар";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(920, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Hero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hero";
            this.Text = "Старший смены";
            this.Load += new System.EventHandler(this.Hero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private prokatDataSet prokatDataSet;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private prokatDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private prokatDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource zakazBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodZakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeZakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslugsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeProkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressInfoZakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}