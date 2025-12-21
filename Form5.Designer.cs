namespace grifindo_toys
{
    partial class Form5
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_toysDataSet1 = new grifindo_toys.Grifindo_toysDataSet1();
            this.registrationsTableAdapter = new grifindo_toys.Grifindo_toysDataSet1TableAdapters.registrationsTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_toysDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoDataGridViewTextBoxColumn,
            this.regDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.eAddressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.homeNoDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn,
            this.cStatusDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.registrationsBindingSource;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(409, 273);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDataGridViewTextBoxColumn
            // 
            this.regDataGridViewTextBoxColumn.DataPropertyName = "reg";
            this.regDataGridViewTextBoxColumn.HeaderText = "reg";
            this.regDataGridViewTextBoxColumn.Name = "regDataGridViewTextBoxColumn";
            this.regDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eAddressDataGridViewTextBoxColumn
            // 
            this.eAddressDataGridViewTextBoxColumn.DataPropertyName = "EAddress";
            this.eAddressDataGridViewTextBoxColumn.HeaderText = "EAddress";
            this.eAddressDataGridViewTextBoxColumn.Name = "eAddressDataGridViewTextBoxColumn";
            this.eAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeNoDataGridViewTextBoxColumn
            // 
            this.homeNoDataGridViewTextBoxColumn.DataPropertyName = "HomeNo";
            this.homeNoDataGridViewTextBoxColumn.HeaderText = "HomeNo";
            this.homeNoDataGridViewTextBoxColumn.Name = "homeNoDataGridViewTextBoxColumn";
            this.homeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nICDataGridViewTextBoxColumn
            // 
            this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
            this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
            this.nICDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cStatusDataGridViewTextBoxColumn
            // 
            this.cStatusDataGridViewTextBoxColumn.DataPropertyName = "CStatus";
            this.cStatusDataGridViewTextBoxColumn.HeaderText = "CStatus";
            this.cStatusDataGridViewTextBoxColumn.Name = "cStatusDataGridViewTextBoxColumn";
            this.cStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "registrations";
            this.registrationsBindingSource.DataSource = this.grifindo_toysDataSet1;
            // 
            // grifindo_toysDataSet1
            // 
            this.grifindo_toysDataSet1.DataSetName = "Grifindo_toysDataSet1";
            this.grifindo_toysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationsTableAdapter
            // 
            this.registrationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::grifindo_toys.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Close_Program1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(227, 373);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVA
            // 
            this.btnVA.BackColor = System.Drawing.Color.Green;
            this.btnVA.ForeColor = System.Drawing.Color.White;
            this.btnVA.Location = new System.Drawing.Point(65, 380);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(75, 23);
            this.btnVA.TabIndex = 20;
            this.btnVA.Text = "view all ";
            this.btnVA.UseVisualStyleBackColor = false;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::grifindo_toys.Properties.Resources.grifindor_toys;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(165, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 60);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grifindo_toys.Properties.Resources.p15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 423);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridViewEmployees);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "ALL Employee Details-Grifindo Toys";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_toysDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private Grifindo_toysDataSet1 grifindo_toysDataSet1;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private Grifindo_toysDataSet1TableAdapters.registrationsTableAdapter registrationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}