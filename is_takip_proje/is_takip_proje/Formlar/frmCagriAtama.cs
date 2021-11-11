using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class frmCagriAtama : DevExpress.XtraEditors.XtraForm
    {
        public frmCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void frmCagriAtama_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Tbl_Personel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEditGorevAlan.Properties.ValueMember = "ID";
            lookUpEditGorevAlan.Properties.DisplayMember = "AdSoyad";
            lookUpEditGorevAlan.Properties.DataSource = degerler;

            txtCagriID.Text = id.ToString();
            var gelenveri = db.Tbl_Cagri.Find(id);
            txtAcıklama.Text = gelenveri.Aciklama;
            dateEditTarih.Text = gelenveri.Tarih.ToString();
            txtKonu.Text = gelenveri.Konu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var gelenveri = db.Tbl_Cagri.Find(id);
            gelenveri.Konu = txtKonu.Text;
            gelenveri.Tarih = Convert.ToDateTime(dateEditTarih.Text);
            gelenveri.Aciklama = txtAcıklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEditGorevAlan.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
