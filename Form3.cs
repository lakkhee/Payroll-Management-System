using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grifindo_toys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Exit???", "confirm to EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblDis.Text = "Welcome to GRIFINDO TOYS!";
        }

        private void mtpEmpR_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void mtpSS_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void mtpSal_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mtpER_Click(object sender, EventArgs e)
        {

        }

        private void txtMMa_Click(object sender, EventArgs e)
        {

        }

        private void mtpSe_Click(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mtpCal_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDis_Click(object sender, EventArgs e)
        {

        }
    }
}
