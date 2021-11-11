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
    public partial class frmGorevListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmGorevListesi()
        {
            InitializeComponent();
        }

        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void frmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Gorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();
            lblAktifGorevSayisi.Text = db.Tbl_Gorevler.Where(x => x.Durum == "1").Count().ToString();
            lblPasifGorev.Text = db.Tbl_Gorevler.Where(x => x.Durum == "0").Count().ToString();
            lblToplamDepartman.Text = db.Tbl_Departmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorevSayisi.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPasifGorev.Text));

        }
    }
}
