
namespace Szepsegszalon_WinForm
{
    partial class Form2
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
            this.comboBox1Form2 = new System.Windows.Forms.ComboBox();
            this.alkalmazottakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szepsegszalonDataSet = new Szepsegszalon_WinForm.szepsegszalonDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2Form2 = new System.Windows.Forms.ComboBox();
            this.vendegekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1Form2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alkalmazottakTableAdapter = new Szepsegszalon_WinForm.szepsegszalonDataSetTableAdapters.alkalmazottakTableAdapter();
            this.vendegekTableAdapter = new Szepsegszalon_WinForm.szepsegszalonDataSetTableAdapters.vendegekTableAdapter();
            this.hozzaad = new System.Windows.Forms.Button();
            this.numericUpDown1Form2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Form2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1Form2
            // 
            this.comboBox1Form2.DataSource = this.alkalmazottakBindingSource;
            this.comboBox1Form2.DisplayMember = "nev";
            this.comboBox1Form2.FormattingEnabled = true;
            this.comboBox1Form2.Location = new System.Drawing.Point(163, 47);
            this.comboBox1Form2.Name = "comboBox1Form2";
            this.comboBox1Form2.Size = new System.Drawing.Size(121, 24);
            this.comboBox1Form2.TabIndex = 0;
            // 
            // alkalmazottakBindingSource
            // 
            this.alkalmazottakBindingSource.DataMember = "alkalmazottak";
            this.alkalmazottakBindingSource.DataSource = this.szepsegszalonDataSet;
            // 
            // szepsegszalonDataSet
            // 
            this.szepsegszalonDataSet.DataSetName = "szepsegszalonDataSet";
            this.szepsegszalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alkalmazott neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendég neve:";
            // 
            // comboBox2Form2
            // 
            this.comboBox2Form2.DataSource = this.vendegekBindingSource;
            this.comboBox2Form2.DisplayMember = "nev";
            this.comboBox2Form2.FormattingEnabled = true;
            this.comboBox2Form2.Location = new System.Drawing.Point(163, 92);
            this.comboBox2Form2.Name = "comboBox2Form2";
            this.comboBox2Form2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2Form2.TabIndex = 2;
            // 
            // vendegekBindingSource
            // 
            this.vendegekBindingSource.DataMember = "vendegek";
            this.vendegekBindingSource.DataSource = this.szepsegszalonDataSet;
            // 
            // dateTimePicker1Form2
            // 
            this.dateTimePicker1Form2.Location = new System.Drawing.Point(163, 137);
            this.dateTimePicker1Form2.Name = "dateTimePicker1Form2";
            this.dateTimePicker1Form2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1Form2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Időpont választás:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kezelés ára:";
            // 
            // alkalmazottakTableAdapter
            // 
            this.alkalmazottakTableAdapter.ClearBeforeFill = true;
            // 
            // vendegekTableAdapter
            // 
            this.vendegekTableAdapter.ClearBeforeFill = true;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(63, 230);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(150, 32);
            this.hozzaad.TabIndex = 8;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // numericUpDown1Form2
            // 
            this.numericUpDown1Form2.Location = new System.Drawing.Point(164, 179);
            this.numericUpDown1Form2.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown1Form2.Name = "numericUpDown1Form2";
            this.numericUpDown1Form2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1Form2.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1Form2);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1Form2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2Form2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1Form2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szepsegszalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendegekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Form2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Form2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2Form2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Form2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private szepsegszalonDataSet szepsegszalonDataSet;
        private System.Windows.Forms.BindingSource alkalmazottakBindingSource;
        private szepsegszalonDataSetTableAdapters.alkalmazottakTableAdapter alkalmazottakTableAdapter;
        private System.Windows.Forms.BindingSource vendegekBindingSource;
        private szepsegszalonDataSetTableAdapters.vendegekTableAdapter vendegekTableAdapter;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.NumericUpDown numericUpDown1Form2;
    }
}