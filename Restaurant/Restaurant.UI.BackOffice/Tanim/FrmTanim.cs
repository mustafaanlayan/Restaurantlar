using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Business.Worker;
using Restaurant.Entites.Enums;

namespace Restaurant.UI.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        private RestaurantWorker worker = new RestaurantWorker();
        public Entites.Tables.Base.Tanim tanimEntity;
        public bool secildi = false;
        private TanimTip _tanimtip;
        public FrmTanim(TanimTip tanimTip)
        {
            InitializeComponent();
            _tanimtip = tanimTip;
            worker.TanimServices.Load(c=>c.TanimTip==tanimTip);
            gridControlTanim.DataSource = worker.TanimServices.BindingList();
        }

        void TanimBinding()
        {
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtTanim.DataBindings.Add("Text", tanimEntity, "Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", tanimEntity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);

        }

        private void controlMenu_EkleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            grupTanimBilgi.Visible = true;
            tanimEntity = new Entites.Tables.Base.Tanim();
            tanimEntity.Id = Guid.NewGuid();
            TanimBinding();
        }

        private void controlMenu_DuzenleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            grupTanimBilgi.Visible = true;
            tanimEntity =(Entites.Tables.Base.Tanim) gridTanim.GetFocusedRow();
            TanimBinding();
        }

        private void controlMenu_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
            }
        }

        private void controlMenu_KaydetClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = false;
            grupTanimBilgi.Visible = false;
            tanimEntity.TanimTip = _tanimtip;
            worker.TanimServices.AddOrUpdate(tanimEntity);
            worker.Commit();
        }

        private void controlMenu_VazgeçClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = false;
            grupTanimBilgi.Visible = false;
        }

        private void controlMenu_KapatClick(object sender, EventArgs e)
        {
            Close();
        }

        private void controlMenu_SecClick(object sender, EventArgs e)
        {
            secildi = true;
            tanimEntity = (Entites.Tables.Base.Tanim)gridTanim.GetFocusedRow();
            Close();
        }
    }
}