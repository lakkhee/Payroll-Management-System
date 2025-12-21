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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TVMDDN6\SQLEXPRESS;Initial Catalog=Grifindo_toys;Integrated Security=True");

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "confirm to EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {


                Form3 frm = new Form3();
                frm.Show(); this.Hide();
            }
        }

        private void Erase()
        {

            txtDR.Text = "";
            txtLY.Text = "";
            dtpBD.Text = "";
            dtpED.Text = "";
            txtDR.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Erase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String quereg = "INSERT INTO settingsss (date_range,begin_date,end_date,leaves_year) VALUES('" + txtDR.Text + "','" + dtpBD.Text + "','" + dtpED.Text + "','" + txtLY.Text + "')";
                conn.Open();
                cmd = new SqlCommand(quereg, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record Added Succesfully", "SALARY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Erase();
            }
            catch (Exception regErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + regErr.Message);
            }
        }

        private void txtDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                String queup = "UPDATE settingsss SET date_range='" + txtDR.Text + "',begin_date='" + dtpBD.Text + "',end_date='" + dtpED.Text + "',leaves_year='" + txtLY.Text + "'";

                conn.Open();
                cmd = new SqlCommand(queup, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record updated Successfully!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Erase();

            }
            catch (Exception UpErr)
            {
                MessageBox.Show("Error while Update..." + Environment.NewLine + UpErr);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            btnUP.Visible = false;
                String queGet = "SELECT * FROM settingsss";

                conn.Open();
                sqlDa = new SqlDataAdapter(queGet, conn);
                DataTable Dt = new DataTable();
                sqlDa.Fill(Dt);
                conn.Close();

            if (Dt.Rows.Count > 0)
            {
                String queSel = "SELECT * FROM settingsss ";
                conn.Open();
                cmd = new SqlCommand(queSel, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    txtDR.Text = R.GetValue(0).ToString();
                    dtpBD.Text = R.GetValue(1).ToString();
                    dtpED.Text = R.GetValue(2).ToString();
                    txtLY.Text = R.GetValue(3).ToString();
                    
                }
                btnUP.Visible = true;
                btnSave.Visible = false;
                conn.Close();
            }
            else
                btnSave.Visible = true;
             

                }

            }
}
