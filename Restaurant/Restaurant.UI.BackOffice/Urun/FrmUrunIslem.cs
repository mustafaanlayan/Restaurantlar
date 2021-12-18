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
using Restaurant.Entites.Tables.Base;
using Restaurant.UI.BackOffice.Tanim;

namespace Restaurant.UI.BackOffice
{
    public partial class FrmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        private RestaurantWorker worker = new RestaurantWorker();
        private Entites.Tables.Urun _urunEntity;
        private Porsiyon _porsiyonEntity;
        private EkMalzeme _ekmalzemeEntity;

        public FrmUrunIslem(Entites.Tables.Urun urunEntity)
        {
            InitializeComponent();
            _urunEntity = urunEntity;
            if (_urunEntity.Id == Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
            worker.PorsiyonServices.Load(c=>c.UrunId==urunEntity.Id);
            gridControlPorsiyon.DataSource = worker.PorsiyonServices.BindingList();
            worker.EkMalzemeServices.Load(c=>c.UrunId==urunEntity.Id);
            gridcontrolMalzeme.DataSource = worker.EkMalzemeServices.BindingList();
            UrunBinding();
        }

       

        void UrunBinding()
        {
            txtBarkod.DataBindings.Clear();
            txtUrunAdi.DataBindings.Clear();
            txtUrunAciklama.DataBindings.Clear();
            picUrunFoto.DataBindings.Clear();

            txtBarkod.DataBindings.Add("Text", _urunEntity, "Barkod",false,DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAdi.DataBindings.Add("Text", _urunEntity, "Adi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAciklama.DataBindings.Add("Text", _urunEntity, "Aciklama",false,DataSourceUpdateMode.OnPropertyChanged);
            picUrunFoto.DataBindings.Add("EditValue", _urunEntity, "Fotograf",false,DataSourceUpdateMode.OnPropertyChanged);
        }

        void PorsiyonBinding()
        {
            txtPorsiyonAdi.DataBindings.Clear();
            txtPorsiyonFiyat.DataBindings.Clear();
            txtMalzemeCarpan.DataBindings.Clear();
            txtPorsiyonAciklama.DataBindings.Clear();

            txtPorsiyonAdi.DataBindings.Add("Text", _porsiyonEntity, "Adi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPorsiyonFiyat.DataBindings.Add("Value", _porsiyonEntity, "Fiyat", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtMalzemeCarpan.DataBindings.Add("Value", _porsiyonEntity, "EkMalzemeCarpan", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPorsiyonAciklama.DataBindings.Add("Text", _porsiyonEntity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        void EkMalzemeBinding()
        {
            txtMalzemeAdi.DataBindings.Clear();
            txtMalzemeFiyat.DataBindings.Clear();
            txtMalzemeAciklama.DataBindings.Clear();

            txtMalzemeAdi.DataBindings.Add("Text", _ekmalzemeEntity, "Adi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtMalzemeFiyat.DataBindings.Add("Value", _ekmalzemeEntity, "Fiyat", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtMalzemeAciklama.DataBindings.Add("Text", _ekmalzemeEntity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuKayitPorsiyon_EkleClick(object sender, EventArgs e)
        {
            controlMenuKayitPorsiyon.KayitAc = true;
            grupPorsiyonBilgi.Visible = true;
            _porsiyonEntity = new Porsiyon();
            _porsiyonEntity.UrunId = _urunEntity.Id;
            PorsiyonBinding();
        }

        private void controlMenuKayitPorsiyon_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuKayitPorsiyon.KayitAc = true;
            grupPorsiyonBilgi.Visible = true;
            _porsiyonEntity =(Porsiyon) gridPorsiyon.GetFocusedRow();

        }

        private void controlMenuKayitPorsiyon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstermisiniz","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridPorsiyon.DeleteSelectedRows();
            }
        }

        private void controlMenuKayitPorsiyon_KaydetClick(object sender, EventArgs e)
        {
            controlMenuKayitPorsiyon.KayitAc = false;
            grupPorsiyonBilgi.Visible = false;
            worker.PorsiyonServices.AddOrUpdate(_porsiyonEntity);
        }

        private void controlMenuKayitPorsiyon_VazgeçClick(object sender, EventArgs e)
        {
            controlMenuKayitPorsiyon.KayitAc = false;
            grupPorsiyonBilgi.Visible = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.UrunServices.AddOrUpdate(_urunEntity);
            worker.Commit();
            Close();
        }

        private void controlMenuKayitEkMalzeme_EkleClick(object sender, EventArgs e)
        {
            controlMenuKayitEkMalzeme.KayitAc = true;
            grupEkMalzeme.Visible = true;
            _ekmalzemeEntity = new EkMalzeme();
            _ekmalzemeEntity.UrunId = _urunEntity.Id;
            EkMalzemeBinding();
        }

        private void controlMenuKayitEkMalzeme_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuKayitEkMalzeme.KayitAc = true;
            grupEkMalzeme.Visible = true;
            _ekmalzemeEntity =(EkMalzeme) gridMalzeme.GetFocusedRow();
            EkMalzemeBinding();
        }

        private void controlMenuKayitEkMalzeme_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMalzeme.DeleteSelectedRows();
            }
        }

        private void controlMenuKayitEkMalzeme_KaydetClick(object sender, EventArgs e)
        {
            controlMenuKayitEkMalzeme.KayitAc = false;
            grupEkMalzeme.Visible = false;
            worker.EkMalzemeServices.AddOrUpdate(_ekmalzemeEntity);
        }

        private void controlMenuKayitEkMalzeme_VazgeçClick(object sender, EventArgs e)
        {
            controlMenuKayitEkMalzeme.KayitAc = false;
            grupEkMalzeme.Visible = false;
        }

        private void txtKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.UrunGrup);
            form.ShowDialog();
            if (form.secildi)
            {
                txtKategori.Text = form.tanimEntity.Adi;
                _urunEntity.UrunGrupId = form.tanimEntity.Id;
            }
        }

        private void txtPorsiyonBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.Birim);
            form.ShowDialog();
            if (form.secildi)
            {
                txtPorsiyonBirim.Text = form.tanimEntity.Adi;
                _porsiyonEntity.BirimId = form.tanimEntity.Id;
            }
        }
    }


}