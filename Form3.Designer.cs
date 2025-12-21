namespace grifindo_toys
{
    partial class Form3
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
            this.lblDis = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mtpER = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpEmpR = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMMa = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpSe = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpSS = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpCal = new System.Windows.Forms.ToolStripMenuItem();
            this.mtpSal = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.BackColor = System.Drawing.Color.Transparent;
            this.lblDis.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(176, 36);
            this.lblDis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(0, 26);
            this.lblDis.TabIndex = 10;
            this.lblDis.Click += new System.EventHandler(this.lblDis_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(29, 279);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 15);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "label1";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtpER,
            this.txtMMa,
            this.mtpSe,
            this.systemToolStripMenuItem,
            this.mtpCal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(641, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mtpER
            // 
            this.mtpER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtpEmpR});
            this.mtpER.Name = "mtpER";
            this.mtpER.Size = new System.Drawing.Size(61, 19);
            this.mtpER.Text = "Register";
            this.mtpER.Click += new System.EventHandler(this.mtpER_Click);
            // 
            // mtpEmpR
            // 
            this.mtpEmpR.Name = "mtpEmpR";
            this.mtpEmpR.Size = new System.Drawing.Size(192, 22);
            this.mtpEmpR.Text = "Employee Registration";
            this.mtpEmpR.Click += new System.EventHandler(this.mtpEmpR_Click);
            // 
            // txtMMa
            // 
            this.txtMMa.Name = "txtMMa";
            this.txtMMa.Size = new System.Drawing.Size(12, 19);
            this.txtMMa.Click += new System.EventHandler(this.txtMMa_Click);
            // 
            // mtpSe
            // 
            this.mtpSe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtpSS});
            this.mtpSe.Name = "mtpSe";
            this.mtpSe.Size = new System.Drawing.Size(64, 19);
            this.mtpSe.Text = " Settings";
            this.mtpSe.Click += new System.EventHandler(this.mtpSe_Click);
            // 
            // mtpSS
            // 
            this.mtpSS.Name = "mtpSS";
            this.mtpSS.Size = new System.Drawing.Size(152, 22);
            this.mtpSS.Text = "Salary Settings";
            this.mtpSS.Click += new System.EventHandler(this.mtpSS_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(12, 19);
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // mtpCal
            // 
            this.mtpCal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtpSal});
            this.mtpCal.Name = "mtpCal";
            this.mtpCal.Size = new System.Drawing.Size(84, 19);
            this.mtpCal.Text = "Calculations";
            this.mtpCal.Click += new System.EventHandler(this.mtpCal_Click);
            // 
            // mtpSal
            // 
            this.mtpSal.Name = "mtpSal";
            this.mtpSal.Size = new System.Drawing.Size(168, 22);
            this.mtpSal.Text = "Salary Calculation";
            this.mtpSal.Click += new System.EventHandler(this.mtpSal_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(29, 313);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 15);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "label2";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::grifindo_toys.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Close_Program_256;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(577, 36);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grifindo_toys.Properties.Resources.p11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnExit);
            this.Name = "Form3";
            this.Text = "Main Menu-Grifindo Toys";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mtpER;
        private System.Windows.Forms.ToolStripMenuItem mtpEmpR;
        private System.Windows.Forms.ToolStripMenuItem txtMMa;
        private System.Windows.Forms.ToolStripMenuItem mtpSe;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem mtpSS;
        private System.Windows.Forms.ToolStripMenuItem mtpCal;
        private System.Windows.Forms.ToolStripMenuItem mtpSal;
    }
}