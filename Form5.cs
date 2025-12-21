using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace grifindo_toys
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_toysDataSet1.registrations' table. You can move, or remove it, as needed.
            this.registrationsTableAdapter.Fill(this.grifindo_toysDataSet1.registrations);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVMDDN6\SQLEXPRESS;Initial Catalog=Grifindo_toys;Integrated Security=True"))
                {
                    string query = "SELECT * FROM registrations";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewEmployees.DataSource = dataTable;
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
