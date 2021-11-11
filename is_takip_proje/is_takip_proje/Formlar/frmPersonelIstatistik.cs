using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class frmPersonelIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public frmPersonelIstatistik()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void frmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.Tbl_Departmanlar.Count().ToString();
            lblFirmaSayisi.Text = db.Tbl_Firmalar.Count().ToString();
            lblToplamPersonel.Text = db.Tbl_Personel.Count().ToString();
            lblAktifIsSayisi.Text = db.Tbl_Gorevler.Count(x => x.Durum == "1").ToString();
            lblPasifIsSayisi.Text = db.Tbl_Gorevler.Count(x => x.Durum == "0").ToString();
            lblSonGörev.Text = db.Tbl_Gorevler.OrderByDescending(x=> x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblIsYapilanSehir.Text = db.Tbl_Firmalar.Select(x => x.il).Distinct().Count().ToString();
            lblSektörSayisi.Text = db.Tbl_Firmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunkuGörevler.Text = db.Tbl_Gorevler.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.Tbl_Gorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.Tbl_Personel.Where(x => x.ID == d1).Select(y => y.Ad+" "+ y.Soyad).FirstOrDefault().ToString();
            lblAyinDepartmani.Text = db.Tbl_Departmanlar.Where(x => x.ID == db.Tbl_Personel.Where(t=>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
            lblSonGorevDetay.Text = db.Tbl_Gorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
        }
    }
}
