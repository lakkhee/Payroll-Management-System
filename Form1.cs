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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String rName;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TVMDDN6\SQLEXPRESS;Initial Catalog=Grifindo_toys;Integrated Security=True");
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCl_Click(object sender, EventArgs e)
        {// code for clear button
            txtUName.Text = "";
            txtPW.Text = "";
            txtUName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { // code for the login button
            String un = txtUName.Text;
            String pw = txtPW.Text;

            if( un=="" || pw=="")
            {
                MessageBox.Show("Username or Password cannot be Blank!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUName.Focus();
            }
            else
            {
                try
                {
                    String quelog = " SELECT RealName FROM login WHERE Username='" + un + "' AND Password='" + pw + "'";

                    conn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(quelog, conn);
                    DataTable Dt = new DataTable();
                    sqlDa.Fill(Dt);

                    if (Dt.Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand(quelog, conn);
                        SqlDataReader Rd = cmd.ExecuteReader();

                        if (Rd.Read())
                        {
                            rName = Rd.GetValue(0).ToString();
                            MessageBox.Show("You have successfully logged In!", "LOGIN SUCCESSFULL!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        Form3 frm = new Form3();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login credentials, please check Username and Password and try again.", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtPW.Text = "";
                        txtUName.Text = "";
                        txtUName.Focus();
                    }
                    conn.Close();
                }
                catch(Exception logErr)
                {
                    MessageBox.Show("Error while Login.." + Environment.NewLine + logErr.Message);
                }
            }
        }

        private void btnCl_MouseHover(object sender, EventArgs e)
        {  //change the button colour
            btnCl.BackColor = SystemColors.ControlLight;
            btnCl.ForeColor = SystemColors.ControlText;
        }

        private void btnCl_MouseLeave(object sender, EventArgs e)
        {
            btnCl.BackColor = Color.Red;
            btnCl.ForeColor = Color.White;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.ForeColor = SystemColors.ControlText;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Navy;
            btnLogin.ForeColor = Color.White;
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
