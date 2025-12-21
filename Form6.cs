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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TVMDDN6\SQLEXPRESS;Initial Catalog=Grifindo_toys;Integrated Security=True");

        String reg;


        private void button3_Click(object sender, EventArgs e)
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
            
            txtAb.Text = "";
            txtAll.Text = "";
            txtGOV.Text = "";
            txtHd.Text = "";
            txtMS.Text = "";
            txtWH.Text = "";
            txtWR.Text = "";
            cmbMo.SelectedIndex = 0;
            cmbReg.SelectedIndex = 0;
            lblBP.Text = "";
            lblGP.Text = "";
            lblNP.Text = "";
            txtLT.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Erase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//code for save
            try
            {


                if (cmbReg.SelectedIndex > 0)
                {
                    String quereg = "INSERT INTO salary (month,absentdays,allowance,overtimeworkhours,overtimeworkrate,GOVtax,Msalary,holidays,leavestaken,basepay,Nopay,Grosspay) VALUES('" + cmbMo.Text + "','" + txtAb.Text + "','" + txtAll.Text + "','" + txtWH.Text + "','" + txtWR.Text + "','" + txtGOV.Text + "','" + txtMS.Text + "','" + txtHd.Text + "','" + txtLT.Text + "','" + lblBP.Text + "','" + lblNP.Text + "','" + lblGP.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(quereg, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record Added Succesfully", "SALARY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Erase();
                }
                else
                {
                    MessageBox.Show("Register Number have to SELECT!", "SELECTION Compulsary!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbReg.Focus();
                }
            }

            catch (Exception regErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + regErr);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int dater = 1;
            int GOVtax = int.Parse(txtGOV.Text);
            decimal allowance = decimal.Parse(txtAll.Text);
            int absentdays = int.Parse(txtAb.Text);
            int owh = int.Parse(txtWH.Text);
            decimal owr = decimal.Parse(txtWR.Text);
            decimal Msalary = decimal.Parse(txtMS.Text);
            //calculate the salary
            decimal Basepay = Msalary + allowance + (owh * owr);
            decimal nopay = (Msalary / dater) * absentdays;
            decimal Grosspay = Basepay - (nopay + Basepay * GOVtax/100);

            lblBP.Text = Basepay.ToString("0.00");
            lblGP.Text = Grosspay.ToString("0.00");
            lblNP.Text = nopay.ToString("0.00");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                String queGet = "SELECT Reg FROM registrations";

                conn.Open();
                sqlDa = new SqlDataAdapter(queGet, conn);
                DataTable Dt = new DataTable();
                sqlDa.Fill(Dt);
                conn.Close();

                if (Dt.Rows.Count > 0)
                {
                    cmbReg.Items.Clear();
                    cmbReg.Items.Add("---SELECT---");
                    foreach (DataRow row in Dt.Rows)
                    {
                        cmbReg.Items.Add(row["reg"]);
                    }
                    cmbReg.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show(" No one has registered yet!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    cmbReg.Focus();
                }
                conn.Close();
            }
            catch (Exception seaErr)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + seaErr);
            }

            try
            {
                int dater = 0;
                String quecal = "SELECT date_range FROM settingsss";
                conn.Open();
                cmd = new SqlCommand(quecal, conn);
                SqlDataReader R = cmd.ExecuteReader();
                
                while (R.Read())
                {
                    dater = R.GetInt32(0);
                }
                conn.Close();
            }
            
                 catch(Exception err)
                {
                MessageBox.Show("Error while Search..." + Environment.NewLine + err);
                conn.Close();
            }
            {
                cmbMo.SelectedIndex = 0;
            } 
            }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.ForeColor = SystemColors.ControlText;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Green;
            btnSave.ForeColor = Color.White;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.ForeColor = SystemColors.ControlText;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {

            btnClear.BackColor = Color.Green;
            btnClear.ForeColor = Color.White;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.ForeColor = SystemColors.ControlText;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
        }
    }
    }

  
            
