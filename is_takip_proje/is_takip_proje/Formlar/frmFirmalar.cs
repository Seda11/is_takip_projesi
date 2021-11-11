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

namespace is_takip_proje.Formlar
{
    public partial class frmFirmalar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        
        void listele()
        {
            var degerler = from x in db.Tbl_Firmalar
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Yetkili,
                               x.Sektor,
                               x.Telefon,
                               x.Mail,
                               x.Sifre,
                               x.il,
                               x.ilçe,
                               x.Adres
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        //void il()
        //{
        //    var il = (from x in db.Tbl_İl
        //                        select new
        //                        {
        //                            x.ID,
        //                            x.Ad
        //                        }).ToList();
        //    lookUpEdit1.Properties.ValueMember = "ID";
        //    lookUpEdit1.Properties.DisplayMember = "Ad";
        //    lookUpEdit1.Properties.DataSource = departmanlar;
        //}
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try{ 
            //txtMail.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail").ToString();
            txtFirmaAdi.EditValue = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtYetkili.EditValue = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            txtSektor.EditValue= gridView1.GetFocusedRowCellValue("Sektor").ToString();
            txtTel.EditValue= gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtMail.EditValue= gridView1.GetFocusedRowCellValue("Mail").ToString();    
            txtAdres.EditValue= gridView1.GetFocusedRowCellValue("Adres").ToString();
            }
            catch
            {
                XtraMessageBox.Show("Hata");
            }
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tbl_Firmalar t = new Tbl_Firmalar();
            t.Ad = txtFirmaAdi.EditValue.ToString();
            t.Yetkili = txtYetkili.EditValue.ToString();
            t.Sektor = txtSektor.EditValue.ToString();
            t.Telefon =txtTel.EditValue.ToString();
            t.Mail = txtMail.EditValue.ToString();
            t.Sifre = txtSifre.EditValue.ToString();
            t.Adres = txtAdres.EditValue.ToString();
            db.Tbl_Firmalar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Firma Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var t = db.Tbl_Firmalar.Find(x);
            t.Ad = txtFirmaAdi.EditValue.ToString();
            t.Yetkili = txtYetkili.EditValue.ToString();
            t.Sektor = txtSektor.EditValue.ToString();
            t.Telefon = txtTel.EditValue.ToString();
            t.Mail = txtMail.EditValue.ToString();
            t.Sifre = txtSifre.EditValue.ToString();
            t.Adres = txtAdres.EditValue.ToString();
            db.SaveChanges();
            XtraMessageBox.Show("Personel Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.Tbl_Firmalar.Find(x);
            db.Tbl_Firmalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Firma Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
