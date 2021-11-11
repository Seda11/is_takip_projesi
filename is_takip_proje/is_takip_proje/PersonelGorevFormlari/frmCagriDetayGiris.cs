using DevExpress.XtraEditors;
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

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class frmCagriDetayGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmCagriDetayGiris()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        public int id;
        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCagriDetayGiris_Load(object sender, EventArgs e)
        {
            txtCagriID.Enabled = false;
            txtCagriID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            dateEditTarih.Text = tarih;
            txtSaat.Text = saat;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_CagriDetay t = new Tbl_CagriDetay();
            t.Cagri = int.Parse(txtCagriID.Text);
            t.Saat = txtSaat.Text;
            t.Tarih = DateTime.Parse(dateEditTarih.Text);
            t.Aciklama = txtAcıklama.Text;
            db.Tbl_CagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı bir Şekilde Kaydedildi.");
        }
    }
}
