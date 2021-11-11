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

namespace is_takip_proje.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var admindegeri = db.Tbl_Admin.Where(x => x.Kullanici == txtKullanıcı.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (admindegeri != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş yaptınız.Lütfen,tekrar deneyin.");
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var personel = db.Tbl_Personel.Where(x => x.Mail == txtKullanıcı.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                PersonelGorevFormlari.frmPersonelFormu fr = new PersonelGorevFormlari.frmPersonelFormu();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş yaptınız.Lütfen,tekrar deneyin.");
            }
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://localhost:44335/Login/Index"); 


        }
    }
}
