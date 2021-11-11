using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using is_takip_proje.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace is_takip_proje.Formlar
{
    public partial class FrmDepartmanlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        void listele() {
            var degerler= (from x in db.Tbl_Departmanlar
                          select new
                          {
                              x.ID,
                              x.Ad
                          }).ToList();
            gridControl1.DataSource = degerler;
        
        } 
        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Departmanlar t = new Tbl_Departmanlar();
            t.Ad = txtDepartmanAd.Text;
            db.Tbl_Departmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman kaydı yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDepartmanId.Text);
            var deger = db.Tbl_Departmanlar.Find(x);
            db.Tbl_Departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmanId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDepartmanId.Text);
            var deger = db.Tbl_Departmanlar.Find(x);
            deger.Ad = txtDepartmanAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
