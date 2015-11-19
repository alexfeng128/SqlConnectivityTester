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
using SqlConnectivityTester.Common;

namespace SqlConnectivityTester.DotNet45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxAuthentication.SelectedIndex = 0;
        }

        private void btnTestConnectivity_Click(object sender, EventArgs e)
        {
            CleanAllText();

            string conString = FormConnectionString(true);

            LogMoreInformation("Connection String ====================================================", true);
            LogMoreInformation(FormConnectionString(false));

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    txtConnectionResult.Text = "Connection Succeeded!";

                    var serverProperty = Helper.GetSqlServerProperty(conString);

                    LogMoreInformation(string.Empty);
                    LogMoreInformation("Server Instance Information ==========================================");
                    LogMoreInformation(string.Format("Machine Name: {0}", serverProperty.MachineName));
                    LogMoreInformation(string.Format("Server Name: {0}", serverProperty.ServerName));
                    LogMoreInformation(string.Format("Instance Name: {0}", serverProperty.InstanceName));
                    LogMoreInformation(string.Format("Is Clustered: {0}", serverProperty.IsClustered.ToString()));
                    LogMoreInformation(string.Format("Computer Name Physical NetBIOS: {0}", serverProperty.ComputerNamePhysicalNetBIOS));
                    LogMoreInformation(string.Format("Edition: {0}", serverProperty.Edition));
                    LogMoreInformation(string.Format("Product Level: {0}", serverProperty.ProductLevel));
                    LogMoreInformation(string.Format("Product Version: {0}", serverProperty.ProductVersion));
                    LogMoreInformation(string.Format("Process ID: {0}", serverProperty.ProcessID.ToString()));
                    LogMoreInformation(string.Format("Collation: {0}", serverProperty.Collation));
                    LogMoreInformation(string.Format("Is Integrated Security: {0}", serverProperty.IsIntegratedSecurityOnly.ToString()));
                    LogMoreInformation(string.Format("Is Hadr Enabled: {0}", serverProperty.IsHadrEnabled.ToString()));
                    LogMoreInformation(string.Format("Hadr Manager Status: {0}", serverProperty.HadrManagerStatus));
                }
                catch (SqlException ex)
                {
                    txtConnectionResult.Text = "Connection Failed!";
                    LogMoreInformation(ex.Message);
                }
            }
        }

        private void cbxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxAuthentication.SelectedIndex;
            switch (index)
            {
                case 0:
                case 3:
                    EnableInputLogonUser(false);
                    break;

                case 1:
                case 2:
                    EnableInputLogonUser(true);
                    break;
            }
        }

        private string FormConnectionString(bool showPassword)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            // for required fields
            builder.DataSource = txtDataSource.Text.Trim();
            builder.InitialCatalog = txtDatabase.Text.Trim();

            // for authentication type
            AuthenticationMode mode = Helper.GetAuthenticaitonMode(cbxAuthentication.SelectedIndex);

            switch (mode)
            {
                case AuthenticationMode.Windows:
                    builder.IntegratedSecurity = true;
                    break;
                case AuthenticationMode.SQLServer:
                    builder.UserID = txtUserName.Text.Trim();

                    if (showPassword)
                    {
                        builder.Password = txtPassword.Text.Trim();
                    }
                    else
                    {
                        builder.Password = "Replace_With_Your_Password";
                    }
                    break;
                case AuthenticationMode.ActiveDirectoryPasswordAuthentication:
                    break;
                case AuthenticationMode.ActiveDirectoryIntegratedSecurity:
                    break;
            }

            // for optional fields
            builder.ConnectTimeout = Int32.Parse(txtConnectionTimeout.Text.Trim());
            builder.ApplicationName = txtApplicationName.Text.Trim();
            builder.Pooling = Helper.TransferBoolValue(txtConnectionPooling.Text.Trim());

            if (cbMultiSubnetFailover.Checked)
            {
                builder.MultiSubnetFailover = true;
            }

            // for advanced feature options

            string tabName = tabControl1.SelectedTab.Name;

            switch (tabName)
            {
                case "tabDBM": // for database mirroring
                    if (!string.IsNullOrEmpty(txtFailoverPartner.Text.Trim()))
                    {
                        builder.FailoverPartner = txtFailoverPartner.Text.Trim();
                    }
                    break;
                case "tabAG": // for AlwaysOn Availability Groups
                    if (rBtnReadWrite.Checked)
                    {
                        builder.ApplicationIntent = ApplicationIntent.ReadWrite;
                    }
                    else
                    {
                        builder.ApplicationIntent = ApplicationIntent.ReadOnly;
                    }
                    break;
                case "tabSslEncryption": // for SSL Encryption
                    builder.Encrypt = Helper.TransferBoolValue(txtSslEncrypt.Text.Trim());
                    builder.TrustServerCertificate = Helper.TransferBoolValue(txtTrustServerCertificate.Text.Trim());
                    break;
            }

            return builder.ConnectionString;
        }

        private void LogMoreInformation(string text, bool cleanExistingText = false)
        {
            if (cleanExistingText)
            {
                txtMoreInformation.Clear();
            }

            txtMoreInformation.AppendText(text);
            txtMoreInformation.AppendText(Environment.NewLine);
        }

        private void EnableInputLogonUser(bool enabled)
        {
            txtUserName.Enabled = enabled;
            txtPassword.Enabled = enabled;
        }

        private void btnGenerateConnectionString_Click(object sender, EventArgs e)
        {
            CleanAllText();

            string conString = FormConnectionString(false);

            LogMoreInformation("Connection String ====================================================", true);
            LogMoreInformation(conString);
        }

        private void CleanAllText()
        {
            txtConnectionResult.Clear();
            txtMoreInformation.Clear();
        }
    }
}
