namespace grifindo_toys
{
    partial class Form4
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
            this.registrationsTableAdapter = new grifindo_toys.Grifindo_toysDataSetTableAdapters.registrationsTableAdapter();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_toysDataSet = new grifindo_toys.Grifindo_toysDataSet();
            this.linkL = new System.Windows.Forms.LinkLabel();
            this.linkEx = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReg = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.linkLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_toysDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationsTableAdapter
            // 
            this.registrationsTableAdapter.ClearBeforeFill = true;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "registrations";
            // 
            // grifindo_toysDataSet
            // 
            this.grifindo_toysDataSet.DataSetName = "Grifindo_toysDataSet";
            this.grifindo_toysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkL
            // 
            this.linkL.AutoSize = true;
            this.linkL.Location = new System.Drawing.Point(12, 10);
            this.linkL.Name = "linkL";
            this.linkL.Size = new System.Drawing.Size(40, 14);
            this.linkL.TabIndex = 23;
            this.linkL.TabStop = true;
            this.linkL.Text = "Logout";
            this.linkL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL_LinkClicked);
            // 
            // linkEx
            // 
            this.linkEx.AutoSize = true;
            this.linkEx.Location = new System.Drawing.Point(485, 574);
            this.linkEx.Name = "linkEx";
            this.linkEx.Size = new System.Drawing.Size(26, 14);
            this.linkEx.TabIndex = 20;
            this.linkEx.TabStop = true;
            this.linkEx.Text = "Exit";
            this.linkEx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEx_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Grifindo Toys";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(127, 34);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 14);
            this.lblReg.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblReg);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbReg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 534);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Registration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(6, 164);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(24, 14);
            this.lblNIC.TabIndex = 20;
            this.lblNIC.Text = "NIC";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(95, 164);
            this.txtNIC.MaxLength = 12;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(116, 22);
            this.txtNIC.TabIndex = 19;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNIC);
            this.groupBox3.Controls.Add(this.lblNIC);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAdd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtMP);
            this.groupBox3.Controls.Add(this.txtHP);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(13, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 198);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reg No";
            // 
            // cmbReg
            // 
            this.cmbReg.FormattingEnabled = true;
            this.cmbReg.Items.AddRange(new object[] {
            "-SELECT-"});
            this.cmbReg.Location = new System.Drawing.Point(130, 31);
            this.cmbReg.MaxLength = 12;
            this.cmbReg.Name = "cmbReg";
            this.cmbReg.Size = new System.Drawing.Size(121, 22);
            this.cmbReg.TabIndex = 0;
            this.cmbReg.Visible = false;
            this.cmbReg.SelectedIndexChanged += new System.EventHandler(this.cmbReg_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::grifindo_toys.Properties.Resources.Aha_Soft_Large_Business_Zoom_512;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(282, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 43);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Green;
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(0, 489);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 25);
            this.btnReg.TabIndex = 13;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            this.btnReg.MouseLeave += new System.EventHandler(this.btnReg_MouseLeave);
            this.btnReg.MouseHover += new System.EventHandler(this.btnReg_MouseHover);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Green;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(103, 489);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 25);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            this.btnUp.MouseLeave += new System.EventHandler(this.btnUp_MouseLeave);
            this.btnUp.MouseHover += new System.EventHandler(this.btnUp_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(300, 489);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(381, 489);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.MouseLeave += new System.EventHandler(this.btnDel_MouseLeave);
            this.btnDel.MouseHover += new System.EventHandler(this.btnDel_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Home Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mobile Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(117, 85);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(117, 24);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(293, 22);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(117, 54);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(293, 22);
            this.txtLName.TabIndex = 2;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(117, 126);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(50, 18);
            this.rbM.TabIndex = 4;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(245, 126);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(62, 18);
            this.rbF.TabIndex = 5;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Civil Status";
            // 
            // cmbCS
            // 
            this.cmbCS.FormattingEnabled = true;
            this.cmbCS.Items.AddRange(new object[] {
            "---SELECT---",
            "Married",
            "Single"});
            this.cmbCS.Location = new System.Drawing.Point(117, 160);
            this.cmbCS.MaxLength = 10;
            this.cmbCS.Name = "cmbCS";
            this.cmbCS.Size = new System.Drawing.Size(121, 22);
            this.cmbCS.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.rbF);
            this.groupBox2.Controls.Add(this.rbM);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(313, 123);
            this.txtHP.MaxLength = 10;
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(116, 22);
            this.txtHP.TabIndex = 9;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            this.txtHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHP_KeyPress);
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(95, 123);
            this.txtMP.MaxLength = 10;
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(116, 22);
            this.txtMP.TabIndex = 8;
            this.txtMP.TextChanged += new System.EventHandler(this.txtMP_TextChanged);
            this.txtMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMP_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(116, 17);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(293, 61);
            this.txtAdd.TabIndex = 6;
            // 
            // linkLog
            // 
            this.linkLog.AutoSize = true;
            this.linkLog.Location = new System.Drawing.Point(42, -16);
            this.linkLog.Name = "linkLog";
            this.linkLog.Size = new System.Drawing.Size(40, 14);
            this.linkLog.TabIndex = 22;
            this.linkLog.TabStop = true;
            this.linkLog.Text = "Logout";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grifindo_toys.Properties.Resources.p15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 622);
            this.ControlBox = false;
            this.Controls.Add(this.linkL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkEx);
            this.Controls.Add(this.linkLog);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration-Grifindo Toys";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_toysDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grifindo_toysDataSetTableAdapters.registrationsTableAdapter registrationsTableAdapter;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private Grifindo_toysDataSet grifindo_toysDataSet;
        private System.Windows.Forms.LinkLabel linkL;
        private System.Windows.Forms.LinkLabel linkEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLog;
    }
}