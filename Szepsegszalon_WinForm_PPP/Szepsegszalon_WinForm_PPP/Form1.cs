using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szepsegszalon_WinForm_PPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.szakmak' table. You can move, or remove it, as needed.
            this.szakmakTableAdapter.Fill(this.szepsegszalonDataSet.szakmak);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.szepsegszalonDataSet.AllData);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceAllDataForTable.Filter = $"Kezelés megnevezése='{comboBox1.SelectedValue}'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourceAllDataForTable.Filter = "";
        }
    }
}
