
namespace Szepsegszalon_WinForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kezelésMegnevezéseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeltVendégNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezelésIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezelésÁraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAllDataForTable = new System.Windows.Forms.BindingSource(this.components);
            this.szepsegszalonDataSet = new Szepsegszalon_WinForm.szepsegszalonDataSet();
            this.szures = new System.Windows.Forms.Button();
            this.kezelesek = new System.Windows.Forms.ComboBox();
            this.kezelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.export = new System.Windows.Forms.Button();
            this.felvetel = new System.Windows.Forms.Button();
            this.szuresKi = new System.Windows.Forms.Button();
            this.allDataTableAdapter = new Szepsegszalon_WinForm.szepsegszalonDataSetTableAdapters.AllDataTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.kezelesekTableAdapter = new Szepsegszalon_WinForm.szepsegszalonDataSetTableAdapters.kezelesekTableAdapter();
            this.szakmakTableAdapter = new Szepsegszalon_WinForm.szepsegszalonDataSetTableAdapters.szakmakTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kezelesekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.szures, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.kezelesek, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.export, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.felvetel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.szuresKi, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 438);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.DataSource = this.bindingSourceAllDataForTable;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 3);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 310);
            this.dataGridView1.TabIndex = 1;
            // 
            // kezelésMegnevezéseDataGridViewTextBoxColumn
            // 
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.DataPropertyName = "KezelésMegnevezése";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.HeaderText = "KezelésMegnevezése";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.Name = "kezelésMegnevezéseDataGridViewTextBoxColumn";
            this.kezelésMegnevezéseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottNeveDataGridViewTextBoxColumn
            // 
            this.alkalmazottNeveDataGridViewTextBoxColumn.DataPropertyName = "AlkalmazottNeve";
            this.alkalmazottNeveDataGridViewTextBoxColumn.HeaderText = "AlkalmazottNeve";
            this.alkalmazottNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottNeveDataGridViewTextBoxColumn.Name = "alkalmazottNeveDataGridViewTextBoxColumn";
            this.alkalmazottNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottTelefonszámaDataGridViewTextBoxColumn
            // 
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.DataPropertyName = "AlkalmazottTelefonszáma";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.HeaderText = "AlkalmazottTelefonszáma";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.Name = "alkalmazottTelefonszámaDataGridViewTextBoxColumn";
            this.alkalmazottTelefonszámaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alkalmazottSzakmájaDataGridViewTextBoxColumn
            // 
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.DataPropertyName = "AlkalmazottSzakmája";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.HeaderText = "AlkalmazottSzakmája";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.Name = "alkalmazottSzakmájaDataGridViewTextBoxColumn";
            this.alkalmazottSzakmájaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezeltVendégNeveDataGridViewTextBoxColumn
            // 
            this.kezeltVendégNeveDataGridViewTextBoxColumn.DataPropertyName = "KezeltVendégNeve";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.HeaderText = "KezeltVendégNeve";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezeltVendégNeveDataGridViewTextBoxColumn.Name = "kezeltVendégNeveDataGridViewTextBoxColumn";
            this.kezeltVendégNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezeltVendégTelefonszámaDataGridViewTextBoxColumn
            // 
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.DataPropertyName = "KezeltVendégTelefonszáma";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.HeaderText = "KezeltVendégTelefonszáma";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.Name = "kezeltVendégTelefonszámaDataGridViewTextBoxColumn";
            this.kezeltVendégTelefonszámaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezelésIdőpontjaDataGridViewTextBoxColumn
            // 
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "KezelésIdőpontja";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.HeaderText = "KezelésIdőpontja";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.Name = "kezelésIdőpontjaDataGridViewTextBoxColumn";
            this.kezelésIdőpontjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kezelésÁraDataGridViewTextBoxColumn
            // 
            this.kezelésÁraDataGridViewTextBoxColumn.DataPropertyName = "KezelésÁra";
            this.kezelésÁraDataGridViewTextBoxColumn.HeaderText = "KezelésÁra";
            this.kezelésÁraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kezelésÁraDataGridViewTextBoxColumn.Name = "kezelésÁraDataGridViewTextBoxColumn";
            this.kezelésÁraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceAllDataForTable
            // 
            this.bindingSourceAllDataForTable.DataMember = "AllData";
            this.bindingSourceAllDataForTable.DataSource = this.szepsegszalonDataSet;
            this.bindingSourceAllDataForTable.Sort = "KezelésIdőpontja, AlkalmazottNeve";
            // 
            // szepsegszalonDataSet
            // 
            this.szepsegszalonDataSet.DataSetName = "szepsegszalonDataSet";
            this.szepsegszalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szures
            // 
            this.szures.Location = new System.Drawing.Point(886, 4);
            this.szures.Margin = new System.Windows.Forms.Padding(4);
            this.szures.Name = "szures";
            this.szures.Size = new System.Drawing.Size(72, 62);
            this.szures.TabIndex = 4;
            this.szures.Text = "Szűrés";
            this.szures.UseVisualStyleBackColor = true;
            this.szures.Click += new System.EventHandler(this.szures_Click);
            // 
            // kezelesek
            // 
            this.kezelesek.DataSource = this.kezelesekBindingSource;
            this.kezelesek.DisplayMember = "nev";
            this.kezelesek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kezelesek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kezelesek.FormattingEnabled = true;
            this.kezelesek.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.kezelesek.Location = new System.Drawing.Point(636, 4);
            this.kezelesek.Margin = new System.Windows.Forms.Padding(4);
            this.kezelesek.Name = "kezelesek";
            this.kezelesek.Size = new System.Drawing.Size(242, 24);
            this.kezelesek.TabIndex = 5;
            this.kezelesek.ValueMember = "nev";
            // 
            // kezelesekBindingSource
            // 
            this.kezelesekBindingSource.DataMember = "szakmak";
            this.kezelesekBindingSource.DataSource = this.szepsegszalonDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(636, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2016, 5, 2, 11, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Location = new System.Drawing.Point(636, 240);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2017, 5, 2, 10, 0, 0, 0);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(886, 240);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(67, 70);
            this.export.TabIndex = 6;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // felvetel
            // 
            this.felvetel.Location = new System.Drawing.Point(886, 122);
            this.felvetel.Margin = new System.Windows.Forms.Padding(4);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(75, 53);
            this.felvetel.TabIndex = 7;
            this.felvetel.Text = "Kezelés felvétele";
            this.felvetel.UseVisualStyleBackColor = true;
            this.felvetel.Click += new System.EventHandler(this.felvetel_Click);
            // 
            // szuresKi
            // 
            this.szuresKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szuresKi.Location = new System.Drawing.Point(885, 317);
            this.szuresKi.Name = "szuresKi";
            this.szuresKi.Size = new System.Drawing.Size(77, 78);
            this.szuresKi.TabIndex = 8;
            this.szuresKi.Text = "Szűrés ki";
            this.szuresKi.UseVisualStyleBackColor = true;
            this.szuresKi.Click += new System.EventHandler(this.szuresKi_Click);
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSourceAllDataForTable;
            this.comboBox1.DisplayMember = "KezelésMegnevezése";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(198, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "KezelésMegnevezése";
            // 
            // kezelesekTableAdapter
            // 
            this.kezelesekTableAdapter.ClearBeforeFill = true;
            // 
            // szakmakTableAdapter
            // 
            this.szakmakTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kezelesekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSourceAllDataForTable;
        private szepsegszalonDataSet szepsegszalonDataSet;
        private szepsegszalonDataSetTableAdapters.AllDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésMegnevezéseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottTelefonszámaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottSzakmájaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeltVendégNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeltVendégTelefonszámaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésIdőpontjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezelésÁraDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button szures;
        private System.Windows.Forms.ComboBox kezelesek;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button felvetel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button szuresKi;
        private System.Windows.Forms.BindingSource kezelesekBindingSource;
        private szepsegszalonDataSetTableAdapters.kezelesekTableAdapter kezelesekTableAdapter;
        private szepsegszalonDataSetTableAdapters.szakmakTableAdapter szakmakTableAdapter;
    }
}

