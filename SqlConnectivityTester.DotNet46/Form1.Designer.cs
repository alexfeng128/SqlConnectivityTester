namespace SqlConnectivityTester.DotNet46
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAuthentication = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbColumnEncryption = new System.Windows.Forms.CheckBox();
            this.cbMultiSubnetFailover = new System.Windows.Forms.CheckBox();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectionPooling = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConnectionTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDBM = new System.Windows.Forms.TabPage();
            this.txtFailoverPartner = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabAG = new System.Windows.Forms.TabPage();
            this.rBtnReadOnly = new System.Windows.Forms.RadioButton();
            this.rBtnReadWrite = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tabSslEncryption = new System.Windows.Forms.TabPage();
            this.txtTrustServerCertificate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSslEncrypt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMoreInformation = new System.Windows.Forms.TextBox();
            this.btnTestConnectivity = new System.Windows.Forms.Button();
            this.txtConnectionResult = new System.Windows.Forms.TextBox();
            this.btnGenerateConnectionString = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDBM.SuspendLayout();
            this.tabAG.SuspendLayout();
            this.tabSslEncryption.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAuthentication);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDataSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required";
            // 
            // cbxAuthentication
            // 
            this.cbxAuthentication.FormattingEnabled = true;
            this.cbxAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication",
            "Active Directory Password Authentication",
            "Active Directory Integrated Authentication"});
            this.cbxAuthentication.Location = new System.Drawing.Point(101, 69);
            this.cbxAuthentication.Name = "cbxAuthentication";
            this.cbxAuthentication.Size = new System.Drawing.Size(268, 19);
            this.cbxAuthentication.TabIndex = 9;
            this.cbxAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbxAuthentication_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 11);
            this.label5.TabIndex = 8;
            this.label5.Text = "Authentication";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(219, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 11);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(219, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 11);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(101, 38);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(268, 23);
            this.txtDatabase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(101, 9);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(268, 23);
            this.txtDataSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbColumnEncryption);
            this.groupBox2.Controls.Add(this.cbMultiSubnetFailover);
            this.groupBox2.Controls.Add(this.txtApplicationName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtConnectionPooling);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtConnectionTimeout);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(383, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optional";
            // 
            // cbColumnEncryption
            // 
            this.cbColumnEncryption.AutoSize = true;
            this.cbColumnEncryption.Location = new System.Drawing.Point(8, 131);
            this.cbColumnEncryption.Name = "cbColumnEncryption";
            this.cbColumnEncryption.Size = new System.Drawing.Size(240, 15);
            this.cbColumnEncryption.TabIndex = 17;
            this.cbColumnEncryption.Text = "Column Encryption (SQL Server 2016+)";
            this.cbColumnEncryption.UseVisualStyleBackColor = true;
            // 
            // cbMultiSubnetFailover
            // 
            this.cbMultiSubnetFailover.AutoSize = true;
            this.cbMultiSubnetFailover.Location = new System.Drawing.Point(8, 102);
            this.cbMultiSubnetFailover.Name = "cbMultiSubnetFailover";
            this.cbMultiSubnetFailover.Size = new System.Drawing.Size(264, 15);
            this.cbMultiSubnetFailover.TabIndex = 16;
            this.cbMultiSubnetFailover.Text = "Multi-Subnet Failover (SQL Server 2012+)";
            this.cbMultiSubnetFailover.UseVisualStyleBackColor = true;
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(167, 35);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(111, 23);
            this.txtApplicationName.TabIndex = 15;
            this.txtApplicationName.Text = "MyApp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 11);
            this.label8.TabIndex = 14;
            this.label8.Text = "Application Name";
            // 
            // txtConnectionPooling
            // 
            this.txtConnectionPooling.Location = new System.Drawing.Point(167, 65);
            this.txtConnectionPooling.Name = "txtConnectionPooling";
            this.txtConnectionPooling.Size = new System.Drawing.Size(111, 23);
            this.txtConnectionPooling.TabIndex = 13;
            this.txtConnectionPooling.Text = "false";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 11);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pooling";
            // 
            // txtConnectionTimeout
            // 
            this.txtConnectionTimeout.Location = new System.Drawing.Point(167, 9);
            this.txtConnectionTimeout.Name = "txtConnectionTimeout";
            this.txtConnectionTimeout.Size = new System.Drawing.Size(111, 23);
            this.txtConnectionTimeout.TabIndex = 11;
            this.txtConnectionTimeout.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 11);
            this.label6.TabIndex = 10;
            this.label6.Text = "Connection Timeout ( Sec)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDBM);
            this.tabControl1.Controls.Add(this.tabAG);
            this.tabControl1.Controls.Add(this.tabSslEncryption);
            this.tabControl1.Location = new System.Drawing.Point(2, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 77);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDBM
            // 
            this.tabDBM.Controls.Add(this.txtFailoverPartner);
            this.tabDBM.Controls.Add(this.label11);
            this.tabDBM.Location = new System.Drawing.Point(4, 21);
            this.tabDBM.Name = "tabDBM";
            this.tabDBM.Padding = new System.Windows.Forms.Padding(3);
            this.tabDBM.Size = new System.Drawing.Size(655, 52);
            this.tabDBM.TabIndex = 0;
            this.tabDBM.Text = "Database Mirroring";
            this.tabDBM.UseVisualStyleBackColor = true;
            // 
            // txtFailoverPartner
            // 
            this.txtFailoverPartner.Location = new System.Drawing.Point(110, 15);
            this.txtFailoverPartner.Name = "txtFailoverPartner";
            this.txtFailoverPartner.Size = new System.Drawing.Size(250, 23);
            this.txtFailoverPartner.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 11);
            this.label11.TabIndex = 10;
            this.label11.Text = "Failover Partner";
            // 
            // tabAG
            // 
            this.tabAG.Controls.Add(this.rBtnReadOnly);
            this.tabAG.Controls.Add(this.rBtnReadWrite);
            this.tabAG.Controls.Add(this.label12);
            this.tabAG.Location = new System.Drawing.Point(4, 21);
            this.tabAG.Name = "tabAG";
            this.tabAG.Padding = new System.Windows.Forms.Padding(3);
            this.tabAG.Size = new System.Drawing.Size(655, 52);
            this.tabAG.TabIndex = 1;
            this.tabAG.Text = "Availability Groups";
            this.tabAG.UseVisualStyleBackColor = true;
            // 
            // rBtnReadOnly
            // 
            this.rBtnReadOnly.AutoSize = true;
            this.rBtnReadOnly.Location = new System.Drawing.Point(206, 16);
            this.rBtnReadOnly.Name = "rBtnReadOnly";
            this.rBtnReadOnly.Size = new System.Drawing.Size(71, 15);
            this.rBtnReadOnly.TabIndex = 14;
            this.rBtnReadOnly.Text = "ReadOnly";
            this.rBtnReadOnly.UseVisualStyleBackColor = true;
            // 
            // rBtnReadWrite
            // 
            this.rBtnReadWrite.AutoSize = true;
            this.rBtnReadWrite.Checked = true;
            this.rBtnReadWrite.Location = new System.Drawing.Point(123, 16);
            this.rBtnReadWrite.Name = "rBtnReadWrite";
            this.rBtnReadWrite.Size = new System.Drawing.Size(77, 15);
            this.rBtnReadWrite.TabIndex = 13;
            this.rBtnReadWrite.TabStop = true;
            this.rBtnReadWrite.Text = "ReadWrite";
            this.rBtnReadWrite.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 11);
            this.label12.TabIndex = 12;
            this.label12.Text = "Application Intent";
            // 
            // tabSslEncryption
            // 
            this.tabSslEncryption.Controls.Add(this.txtTrustServerCertificate);
            this.tabSslEncryption.Controls.Add(this.label14);
            this.tabSslEncryption.Controls.Add(this.txtSslEncrypt);
            this.tabSslEncryption.Controls.Add(this.label13);
            this.tabSslEncryption.Location = new System.Drawing.Point(4, 21);
            this.tabSslEncryption.Name = "tabSslEncryption";
            this.tabSslEncryption.Size = new System.Drawing.Size(655, 52);
            this.tabSslEncryption.TabIndex = 4;
            this.tabSslEncryption.Text = "SSL Encryption";
            this.tabSslEncryption.UseVisualStyleBackColor = true;
            // 
            // txtTrustServerCertificate
            // 
            this.txtTrustServerCertificate.Location = new System.Drawing.Point(456, 15);
            this.txtTrustServerCertificate.Name = "txtTrustServerCertificate";
            this.txtTrustServerCertificate.Size = new System.Drawing.Size(170, 23);
            this.txtTrustServerCertificate.TabIndex = 21;
            this.txtTrustServerCertificate.Text = "true";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 11);
            this.label14.TabIndex = 20;
            this.label14.Text = "Trust Server Certificate";
            // 
            // txtSslEncrypt
            // 
            this.txtSslEncrypt.Location = new System.Drawing.Point(97, 15);
            this.txtSslEncrypt.Name = "txtSslEncrypt";
            this.txtSslEncrypt.Size = new System.Drawing.Size(150, 23);
            this.txtSslEncrypt.TabIndex = 19;
            this.txtSslEncrypt.Text = "false";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 11);
            this.label13.TabIndex = 18;
            this.label13.Text = "Encrypt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMoreInformation);
            this.groupBox3.Location = new System.Drawing.Point(2, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "More Information";
            // 
            // txtMoreInformation
            // 
            this.txtMoreInformation.Location = new System.Drawing.Point(4, 22);
            this.txtMoreInformation.Multiline = true;
            this.txtMoreInformation.Name = "txtMoreInformation";
            this.txtMoreInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMoreInformation.Size = new System.Drawing.Size(655, 121);
            this.txtMoreInformation.TabIndex = 0;
            // 
            // btnTestConnectivity
            // 
            this.btnTestConnectivity.Location = new System.Drawing.Point(6, 263);
            this.btnTestConnectivity.Name = "btnTestConnectivity";
            this.btnTestConnectivity.Size = new System.Drawing.Size(183, 23);
            this.btnTestConnectivity.TabIndex = 4;
            this.btnTestConnectivity.Text = "Test the connection";
            this.btnTestConnectivity.UseVisualStyleBackColor = true;
            this.btnTestConnectivity.Click += new System.EventHandler(this.btnTestConnectivity_Click);
            // 
            // txtConnectionResult
            // 
            this.txtConnectionResult.Location = new System.Drawing.Point(383, 262);
            this.txtConnectionResult.Name = "txtConnectionResult";
            this.txtConnectionResult.Size = new System.Drawing.Size(278, 23);
            this.txtConnectionResult.TabIndex = 5;
            // 
            // btnGenerateConnectionString
            // 
            this.btnGenerateConnectionString.Location = new System.Drawing.Point(195, 263);
            this.btnGenerateConnectionString.Name = "btnGenerateConnectionString";
            this.btnGenerateConnectionString.Size = new System.Drawing.Size(176, 23);
            this.btnGenerateConnectionString.TabIndex = 6;
            this.btnGenerateConnectionString.Text = "Generate connection string";
            this.btnGenerateConnectionString.UseVisualStyleBackColor = true;
            this.btnGenerateConnectionString.Click += new System.EventHandler(this.btnGenerateConnectionString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 447);
            this.Controls.Add(this.btnGenerateConnectionString);
            this.Controls.Add(this.txtConnectionResult);
            this.Controls.Add(this.btnTestConnectivity);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(686, 486);
            this.MinimumSize = new System.Drawing.Size(686, 486);
            this.Name = "Form1";
            this.Text = "SQL Connectivity Tester for .NET 4.6 (Build 2015.11.17)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDBM.ResumeLayout(false);
            this.tabDBM.PerformLayout();
            this.tabAG.ResumeLayout(false);
            this.tabAG.PerformLayout();
            this.tabSslEncryption.ResumeLayout(false);
            this.tabSslEncryption.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDBM;
        private System.Windows.Forms.TabPage tabAG;
        private System.Windows.Forms.TabPage tabSslEncryption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTestConnectivity;
        private System.Windows.Forms.TextBox txtConnectionResult;
        private System.Windows.Forms.ComboBox cbxAuthentication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionPooling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConnectionTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoreInformation;
        private System.Windows.Forms.TextBox txtFailoverPartner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rBtnReadOnly;
        private System.Windows.Forms.RadioButton rBtnReadWrite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbMultiSubnetFailover;
        private System.Windows.Forms.TextBox txtTrustServerCertificate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSslEncrypt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbColumnEncryption;
        private System.Windows.Forms.Button btnGenerateConnectionString;
    }
}

