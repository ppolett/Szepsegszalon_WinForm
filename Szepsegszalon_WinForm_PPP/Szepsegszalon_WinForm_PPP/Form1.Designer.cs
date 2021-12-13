
namespace Szepsegszalon_WinForm_PPP
{
    partial class Form1
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
            this.bindingSourceAllDataForTable = new System.Windows.Forms.BindingSource(this.components);
            this.szepsegszalonDataSet = new Szepsegszalon_WinForm_PPP.szepsegszalonDataSet();
            this.allDataTableAdapter = new Szepsegszalon_WinForm_PPP.szepsegszalonDataSetTableAdapters.AllDataTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.szakmakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szakmakTableAdapter = new Szepsegszalon_WinForm_PPP.szepsegszalonDataSetTableAdapters.szakmakTableAdapter();
            this.kezelésÁraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezelésIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeltVendégNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezelésMegnevezéseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szakmakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceAllDataForTable
            // 
            this.bindingSourceAllDataForTable.DataMember = "AllData";
            this.bindingSourceAllDataForTable.DataSource = this.szepsegszalonDataSet;
            this.bindingSourceAllDataForTable.Sort = "[Kezelés időpontja] ASC, [Alkalmazott neve] ASC";
            // 
            // szepsegszalonDataSet
            // 
            this.szepsegszalonDataSet.DataSetName = "szepsegszalonDataSet";
            this.szepsegszalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kezelésMegnevezéseDataGridViewTextBoxColumn,
            this.alkalmazottNeveDataGridViewTextBoxColumn,
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn,
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn,
            this.kezeltVendégNeveDataGridViewTextBoxColumn,
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn,
            this.kezelésIdőpontjaDataGridViewTextBoxColumn,
            this.kezelésÁraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceAllDataForTable;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 3);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 492);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.szakmakBindingSource1;
            this.comboBox1.DisplayMember = "nev";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1029, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "nev";
            // 
            // szakmakBindingSource
            // 
            this.szakmakBindingSource.DataMember = "szakmak";
            this.szakmakBindingSource.DataSource = this.szepsegszalonDataSet;
            // 
            // szakmakTableAdapter
            // 
            this.szakmakTableAdapter.ClearBeforeFill = true;
            // 
            // kezelésÁraDataGridViewTextBoxColumn
            // 
            this.kezelésÁraDataGridViewTextBoxColumn.DataPropertyName = "Kezelés ára";
            this.kezelésÁraDataGridViewTextBoxColumn.HeaderText = "Kezelés ára";
            this.kezelésÁraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésÁraDataGridViewTextBoxColumn.Name = "kezelésÁraDataGridViewTextBoxColumn";
            this.kezelésÁraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezelésIdőpontjaDataGridViewTextBoxColumn
            // 
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "Kezelés időpontja";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.HeaderText = "Kezelés időpontja";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.Name = "kezelésIdőpontjaDataGridViewTextBoxColumn";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezeltVendégTelefonszámaDataGridViewTextBoxColumn
            // 
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.DataPropertyName = "Kezelt vendég telefonszáma";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.HeaderText = "Kezelt vendég telefonszáma";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.Name = "kezeltVendégTelefonszámaDataGridViewTextBoxColumn";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezeltVendégNeveDataGridViewTextBoxColumn
            // 
            this.kezeltVendégNeveDataGridViewTextBoxColumn.DataPropertyName = "Kezelt vendég neve";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.HeaderText = "Kezelt vendég neve";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezeltVendégNeveDataGridViewTextBoxColumn.Name = "kezeltVendégNeveDataGridViewTextBoxColumn";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottSzakmájaDataGridViewTextBoxColumn
            // 
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.DataPropertyName = "Alkalmazott szakmája";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.HeaderText = "Alkalmazott szakmája";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.Name = "alkalmazottSzakmájaDataGridViewTextBoxColumn";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottTelefonszámaDataGridViewTextBoxColumn
            // 
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.DataPropertyName = "Alkalmazott telefonszáma";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.HeaderText = "Alkalmazott telefonszáma";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.Name = "alkalmazottTelefonszámaDataGridViewTextBoxColumn";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottNeveDataGridViewTextBoxColumn
            // 
            this.alkalmazottNeveDataGridViewTextBoxColumn.DataPropertyName = "Alkalmazott neve";
            this.alkalmazottNeveDataGridViewTextBoxColumn.HeaderText = "Alkalmazott neve";
            this.alkalmazottNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottNeveDataGridViewTextBoxColumn.Name = "alkalmazottNeveDataGridViewTextBoxColumn";
            this.alkalmazottNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezelésMegnevezéseDataGridViewTextBoxColumn
            // 
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.DataPropertyName = "Kezelés megnevezése";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.HeaderText = "Kezelés megnevezése";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.Name = "kezelésMegnevezéseDataGridViewTextBoxColumn";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szakmakBindingSource1
            // 
            this.szakmakBindingSource1.DataMember = "szakmak";
            this.szakmakBindingSource1.DataSource = this.szepsegszalonDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1029, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAllDataForTable;
        private szepsegszalonDataSet szepsegszalonDataSet;
        private szepsegszalonDataSetTableAdapters.AllDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource szakmakBindingSource;
        private szepsegszalonDataSetTableAdapters.szakmakTableAdapter szakmakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésMegnevezéseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottTelefonszámaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottSzakmájaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeltVendégNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeltVendégTelefonszámaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésIdőpontjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésÁraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource szakmakBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

