using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Core.Function
{
    public partial class FrmSetupConnection : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public bool Kaydedildi = false;
        public FrmSetupConnection()
        {
            InitializeComponent();
        }

        private void BaglantiCumlesiOlustur()
        {
            connectionStringBuilder.InitialCatalog = "master";
            connectionStringBuilder.DataSource = txtServer.Text;
            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtUser.Text;
                connectionStringBuilder.Password = txtpassword.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }
           
        }
       

        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtUser.Enabled = true;
                txtpassword.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtpassword.Enabled = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BaglantiCumlesiOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı Başarılı");
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumlesiOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = "Restaurant";
                ConnectionStringInfo.Set(connectionStringBuilder.ConnectionString);
                Kaydedildi = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}