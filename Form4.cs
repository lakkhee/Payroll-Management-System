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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TVMDDN6\SQLEXPRESS;Initial Catalog=Grifindo_toys;Integrated Security=True");

        String gen, reg;

        private void AutoNumGen()
        { //code for auto number generation
            try
            {
                int employee = 0;

                String queFind = "SELECT reg FROM registrations";
                conn.Open();
                sqlDa = new SqlDataAdapter(queFind, conn);
                DataTable Dt = new DataTable();
                sqlDa.Fill(Dt);

                if (Dt.Rows.Count >0)
                    {
                    String queMax = " SELECT MAX (SerialNo) FROM registrations";
                    cmd = new SqlCommand(queMax, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        employee = int.Parse(R.GetValue(0).ToString());
                    }
                    employee += 1;
                }
                else
                {
                    employee = 1;
                }
                conn.Close();
                
                if (employee < 10) { reg = "GTE-00000" + employee; }
                else if (employee < 100) { reg = "GTE-0000" + employee; }
                else if (employee < 1000) { reg = "GTE-000" + employee; }
                else if (employee < 10000) { reg = "GTE-00" + employee; }
                else if (employee < 100000) { reg = "GTE-0" + employee; }
                else if (employee < 1000000) { reg = "GTE-" + employee; }

                lblReg.Text = reg;
               
            }
            catch(Exception NumGenErr)
            {
                MessageBox.Show("Error while Auto Number Generation..." + Environment.NewLine + NumGenErr.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        { //code for update button
            try
            {
                
                if (rbF.Checked == true) { gen = "Female"; }
                else if (rbM.Checked == true) { gen = "Male"; }

                String queup = "UPDATE Registrations SET FName='" + txtFName.Text + "',LName='" + txtLName.Text + "',DOB='" + dtpDOB.Text + "',Gender='" + gen + "',EAddress='" + txtAdd.Text + "',Email='" + txtEmail.Text + "',MobileNo= '" + txtMP.Text + "',HomeNo='" + txtHP.Text + "',NIC='" + txtNIC.Text + "',CStatus='" + cmbCS.SelectedItem.ToString() + "' WHERE reg='" + cmbReg.SelectedItem.ToString() + "'";

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

        private void Erase()
        {//clear code

            txtAdd.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtHP.Text = "";
            txtLName.Text = "";
            txtMP.Text = "";
            txtNIC.Text = "";
            rbF.Checked = false;
            rbM.Checked = false;
            cmbCS.SelectedIndex = 0;
            dtpDOB.Text = "";
            btnReg.Visible = true;
            btnDel.Visible = false;
            btnUp.Visible = false;
            cmbReg.Visible = false;
            lblReg.Visible = true;
            AutoNumGen();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {//code for delete button
            try
            {
                reg = cmbReg.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Are you sure, Do you really want to Delete this Record....?", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    String queDel = "DELETE FROM Registrations WHERE Reg= '" + reg + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record Deleted Succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Erase();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while DELETE..." + Environment.NewLine + DelErr);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//code for cler button
            Erase();
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbReg.SelectedIndex > 0)
                {
                    reg = cmbReg.SelectedItem.ToString();
                    String queSel = "SELECT * FROM Registrations WHERE Reg = '" + reg + "'";
                    conn.Open();
                    cmd = new SqlCommand(queSel, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtFName.Text = R.GetValue(2).ToString();
                        txtLName.Text = R.GetValue(3).ToString();
                        dtpDOB.Text = R.GetValue(4).ToString();
                        gen = R.GetValue(5).ToString();
                        txtAdd.Text = R.GetValue(6).ToString();
                        txtEmail.Text = R.GetValue(7).ToString();
                        txtMP.Text =  R.GetValue(8).ToString();
                        txtHP.Text =  R.GetValue(9).ToString();
                        txtNIC.Text = R.GetValue(10).ToString();
                        cmbCS.SelectedItem = R.GetValue(11).ToString();
                       
                    }
                    if (gen.Equals("Male")) { rbM.Checked = true; }
                    else if (gen.Equals("Female")) { rbF.Checked = true; }

                    conn.Close();
                }
                else
                {
                    txtAdd.Text = "";
                    txtEmail.Text = "";
                    txtFName.Text = "";
                    txtHP.Text = "";
                    txtLName.Text = "";
                    txtMP.Text = "";
                    txtNIC.Text = "";
                    rbF.Checked = false;
                    rbM.Checked = false;
                    dtpDOB.Text = "";
                    cmbCS.SelectedIndex = 0;
                    
                }
            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + SelErr.Message);
            }
        }

        private void linkEx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "confirm to EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {


                Form3 frm = new Form3();
                frm.Show(); this.Hide();
            }
        }

        private void linkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            cmbCS.SelectedIndex = 0;
            AutoNumGen();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {//code for register button
            try
            {
                if (rbF.Checked == true) { gen = "Female"; }
                else if (rbM.Checked == true) { gen = "Male"; }

                if (cmbCS.SelectedIndex > 0)
                {
                    String quereg = "INSERT INTO registrations(reg,FName,LName,DOB,Gender,EAddress,Email,MobileNo,HomeNo,NIC,CStatus) VALUES('" + reg + "','" + txtFName.Text + "','" + txtLName.Text + "','" + dtpDOB.Text + "','" + gen + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtMP.Text + "','" + txtHP.Text + "','" + txtNIC.Text + "','" + cmbCS.SelectedItem.ToString() + "')";
                    conn.Open();
                    cmd = new SqlCommand(quereg, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Erase();
                }
                else
                {
                    MessageBox.Show("Civil Status have to SELECT!", "SELECTION Compulsary!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCS.Focus();
                }
            }

            catch (Exception regErr)
            {
                MessageBox.Show("Error while Save..." + Environment.NewLine + regErr.Message);
            }
           finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnReg_MouseHover(object sender, EventArgs e)
        {
            btnReg.BackColor = SystemColors.ControlLight;
            btnReg.ForeColor = SystemColors.ControlText;
        }

        private void btnReg_MouseLeave(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.Green;
            btnReg.ForeColor = Color.White;
        }

        private void btnUp_MouseHover(object sender, EventArgs e)
        {

            btnUp.BackColor = SystemColors.ControlLight;
            btnUp.ForeColor = SystemColors.ControlText;
        }

        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            btnUp.BackColor = Color.Green;
            btnUp.ForeColor = Color.White;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.ForeColor = SystemColors.ControlText;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
        }

        private void btnDel_MouseHover(object sender, EventArgs e)
        {
            btnDel.BackColor = SystemColors.ControlLight;
            btnDel.ForeColor = SystemColors.ControlText;
        }

        private void btnDel_MouseLeave(object sender, EventArgs e)
        {
            btnDel.BackColor = Color.Red;
            btnDel.ForeColor = Color.White;
        }

        private void txtMP_TextChanged(object sender, EventArgs e)
        {
            if (txtMP.TextLength < 10)
                txtMP.ForeColor = Color.Red;
            else
            {
                txtMP.ForeColor = Color.Green;
            }
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {//can input only 10 numbers
            if (txtHP.TextLength < 10)
                txtHP.ForeColor = Color.Red;
            else
            {
                txtHP.ForeColor = Color.Green;
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.TextLength == 10 || txtNIC.TextLength == 12)
                txtNIC.ForeColor = Color.Green;
            else
            {
                txtNIC.ForeColor = Color.Red;
            }
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
           
                Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void txtMP_KeyPress(object sender, KeyPressEventArgs e)
        {//can input only numbers 
            char sh = e.KeyChar;
            if(!char.IsDigit(sh) && sh !=8)
            {
                e.Handled = true;
            }
        }

        private void txtHP_KeyPress(object sender, KeyPressEventArgs e)
        {//can input only numbers
            char sh = e.KeyChar;
            if(!char.IsDigit(sh) && sh !=8)
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {//code for search button
            try
            {
                String queGet = "SELECT Reg FROM Registrations";

                conn.Open();
                sqlDa = new SqlDataAdapter(queGet, conn);
                DataTable Dt = new DataTable();
                sqlDa.Fill(Dt);
                

                if (Dt.Rows.Count > 0)
                {
                    cmbReg.Visible = true;
                    lblReg.Visible = false;
                    btnReg.Visible = false;
                    btnUp.Visible = true;
                    btnDel.Visible = true;
                    cmbReg.Items.Clear();
                    cmbReg.Items.Add("---SELECT---");
                    foreach (DataRow row in Dt.Rows)
                    {
                        cmbReg.Items.Add(row["Reg"]);
                    }
                    cmbReg.SelectedIndex = 0;

                    
                }
                else
                {
                    MessageBox.Show(" No one has registered yet!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Erase();
                }
                conn.Close();
            }
            catch (Exception seaErr)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + seaErr.Message);
            }
        }
    }
}
