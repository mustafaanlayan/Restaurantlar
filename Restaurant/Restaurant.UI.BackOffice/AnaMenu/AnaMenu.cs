using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Entity;
using Restaurant.UI.BackOffice.Urun;
using Restaurant.Core.Function;
using ConnectionStringInfo = Restaurant.Core.Function.ConnectionStringInfo;


namespace Restaurant.UI.BackOffice.AnaMenu
{
    public partial class AnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form = new FrmSetupConnection();
                form.ShowDialog();
            }
        }

        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrun forum = new FrmUrun();
            forum.MdiParent = this;
            forum.Show();
        }
    }
}
