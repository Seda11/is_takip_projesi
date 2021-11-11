using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class frmGorev : DevExpress.XtraEditors.XtraForm
    {
        public frmGorev()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Gorevler t = new Tbl_Gorevler();
            t.Aciklama = txtAcıklama.Text;
            t.Durum = "1";
            t.GorevAlan = int.Parse(lookUpEditGorevAlan.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEditTarih.Text);
            t.GorevVeren = 1;
            db.Tbl_Gorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev tanımlandı", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void frmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Tbl_Personel
                            select new
                            {
                                x.ID,
                                AdSoyad= x.Ad +" "+ x.Soyad
                            }).ToList();

            lookUpEditGorevAlan.Properties.ValueMember = "ID";
            lookUpEditGorevAlan.Properties.DisplayMember = "AdSoyad";
            lookUpEditGorevAlan.Properties.DataSource = degerler;
        }
    }
}
