using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Szepsegszalon_WinForm
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-UTPLK6L;Initial Catalog=szepsegszalon;Integrated Security=True");
        SqlCommand sqlAlkalmazott = new SqlCommand();
        SqlCommand sqlVendeg = new SqlCommand();
        SqlCommand sqlKezeles = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.vendegek' table. You can move, or remove it, as needed.
            this.vendegekTableAdapter.Fill(this.szepsegszalonDataSet.vendegek);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.alkalmazottak' table. You can move, or remove it, as needed.
            this.alkalmazottakTableAdapter.Fill(this.szepsegszalonDataSet.alkalmazottak);

        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            string alkalmazott = comboBox1Form2.SelectedValue.ToString();
            string vendeg = comboBox2Form2.SelectedValue.ToString();
            DateTime time = dateTimePicker1Form2.Value;
            int ar = (int)(numericUpDown1Form2.Value);

            if(alkalmazott == null || vendeg == null || time == null || ar ==  0)
            {
                MessageBox.Show("Nézze át az adatokat mégegyszer!");
            }
            else
            {
                sqlAlkalmazott.Connection = connect;
                sqlVendeg.Connection = connect;
                sqlKezeles.Connection = connect;
                connect.Open();

                sqlAlkalmazott.CommandText = @"INSERT INTO alkalmazottak (nev) VALUES (@anev)";
                sqlAlkalmazott.Parameters.AddWithValue("@anev", comboBox1Form2.SelectedValue);
                sqlAlkalmazott.ExecuteNonQuery();

                sqlVendeg.CommandText = @"INSERT INTO vendegek (nev) VALUES (@vnev)";
                sqlVendeg.Parameters.AddWithValue("@vnev", comboBox2Form2.SelectedValue);
                sqlVendeg.ExecuteNonQuery();

                sqlKezeles.CommandText = @"INSERT INTO kezelesek (datum) VALUES (@adatum)";
                sqlKezeles.Parameters.AddWithValue("@adatumm", dateTimePicker1Form2.Value.Date);
                sqlKezeles.ExecuteNonQuery();

                sqlKezeles.CommandText = @"INSERT INTO kezelesek (ar) VALUES (@azar)";
                sqlKezeles.Parameters.AddWithValue("@azar", numericUpDown1Form2.Value);
                sqlKezeles.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Sikeresen felvettük az adatokat!");

            }
        }
    }
}
