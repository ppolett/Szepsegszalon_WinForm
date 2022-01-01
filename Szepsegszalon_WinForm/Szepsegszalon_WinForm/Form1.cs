using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Szepsegszalon_WinForm
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-UTPLK6L;Initial Catalog=szepsegszalon;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.szakmak' table. You can move, or remove it, as needed.
            this.szakmakTableAdapter.Fill(this.szepsegszalonDataSet.szakmak);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.kezelesek' table. You can move, or remove it, as needed.
            this.kezelesekTableAdapter.Fill(this.szepsegszalonDataSet.kezelesek);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.szepsegszalonDataSet.AllData);
            Size = new Size(1000, 500);
        }

        private void szures_Click(object sender, EventArgs e)
        {
            DateTime timeFirst = (DateTime)Convert.ToDateTime(dateTimePicker1.Value);
            DateTime timeSecond = (DateTime)Convert.ToDateTime(dateTimePicker2.Value);

            connect.Open();
            SqlCommand sqlcom = connect.CreateCommand();
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = "SELECT * FROM AllData WHERE KezelésMegnevezése = ('"+ this.kezelesek.SelectedValue + "') ORDER BY KezelésÁra DESC";
           /* sqlcom.CommandText = "SELECT * FROM AllData WHERE KezelésMegnevezése = ('" + this.kezelesek.SelectedValue + "') AND KezelésIdőpontja BETWEEN ('" + timeFirst + "') AND ('" + timeSecond + "') ORDER BY KezelésÁra DESC";*/
            sqlcom.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sqlcom);
            adapt.Fill(data);
            dataGridView1.DataSource = data;
            connect.Close();
        }

        private void felvetel_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void export_Click(object sender, EventArgs e)
        {
            DateTime timeFirst = (DateTime)Convert.ToDateTime(dateTimePicker1.Value);
            DateTime timeSecond = (DateTime)Convert.ToDateTime(dateTimePicker2.Value);

            if(folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string fileName = Path.Combine(folderBrowserDialog1.SelectedPath, $"kezelesek_{DateTime.Now:yyyy-MM-dd_H-m}.csv");
            File.WriteAllLines(fileName,
                szepsegszalonDataSet.AllData.Select(x => string.Join(";", x.ItemArray))
                );
        }

        private void szuresKi_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sqlcom = connect.CreateCommand();
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = "SELECT * FROM AllData ORDER BY KezelésIdőpontja, AlkalmazottNeve";
            sqlcom.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sqlcom);
            adapt.Fill(data);
            dataGridView1.DataSource = data;
            connect.Close();
        }
    }
}
