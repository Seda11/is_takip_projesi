using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmDepartmanlar frmD;
        Formlar.frmPersoneller frmP;
        Formlar.frmPersonelIstatistik frmPI;
        Formlar.frmGorevListesi frmGL;
        Formlar.frmGorev frmGT;
        Formlar.frmGorevDetay frmGD;
        Formlar.frmAnasayfa frmA;
        Formlar.FrmAktifCagrilar fr;
        Formlar.frmFirmalar f;
        Formlar.frmHesap_Makinesi fhm;

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmD == null || frmD.IsDisposed)
            {
                frmD = new Formlar.FrmDepartmanlar();
                frmD.MdiParent = this;
                frmD.Show();
            }
            else
            {
                frmD.Close();
                frmD = new Formlar.FrmDepartmanlar();
                frmD.MdiParent = this;
                frmD.Show();
            }
        }

        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmP == null || frmP.IsDisposed)
            {
                frmP = new Formlar.frmPersoneller();
                frmP.MdiParent = this;
                frmP.Show();
            }
            else
            {
                frmP.Close();
                frmP = new Formlar.frmPersoneller();
                frmP.MdiParent = this;
                frmP.Show();
            }
        }

        private void btnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPI == null || frmPI.IsDisposed)
            {
                frmPI = new Formlar.frmPersonelIstatistik();
                frmPI.MdiParent = this;
                frmPI.Show();
            }
            else
            {
                frmPI.Close();
                frmPI = new Formlar.frmPersonelIstatistik();
                frmPI.MdiParent = this;
                frmPI.Show();
            }
        }

        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGL == null || frmGL.IsDisposed)
            {
                frmGL = new Formlar.frmGorevListesi();
                frmGL.MdiParent = this;
                frmGL.Show();
            }
            else
            {
                frmGL.Close();
                frmGL = new Formlar.frmGorevListesi();
                frmGL.MdiParent = this;
                frmGL.Show();
            }
        }

        private void btnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGT == null || frmGT.IsDisposed)
            {
                frmGT = new Formlar.frmGorev();
                frmGT.Show();
            }
            else
            {
                frmGT.Close();
                frmGT = new Formlar.frmGorev();
                frmGT.Show();
            }
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGD == null || frmGD.IsDisposed)
            {
                frmGD = new Formlar.frmGorevDetay();
                frmGD.Show();
            }
            else
            {
                frmGD.Close();
                frmGD = new Formlar.frmGorevDetay();
                frmGD.Show();
            }
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmA == null || frmA.IsDisposed)
            {
                frmA = new Formlar.frmAnasayfa();
                frmA.MdiParent = this;
                frmA.Show();
            }
            else
            {
                frmA.Close();
                frmA = new Formlar.frmAnasayfa();
                frmA.MdiParent = this;
                frmA.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (frmA == null || frmA.IsDisposed)
            {
                frmA = new Formlar.frmAnasayfa();
                frmA.MdiParent = this;
                frmA.Show();
            }
            else
            {
                frmA.Close();
                frmA = new Formlar.frmAnasayfa();
                frmA.MdiParent = this;
                frmA.Show();
            }
        }
        
        private void btnAktifCagri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                fr.Close();
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Login.frmLogin fl;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            fl = new Login.frmLogin();
            fl.Show();
        }

        private void btnFirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Formlar.frmFirmalar();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Close();
                f = new Formlar.frmFirmalar();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fhm == null || fhm.IsDisposed)
            {
                fhm = new Formlar.frmHesap_Makinesi();
                fhm.MdiParent = this;
                fhm.Show();
            }
            else
            {
                fhm.Close();
                fhm = new Formlar.frmHesap_Makinesi();
                fhm.MdiParent = this;
                fhm.Show();
            }
        }
    }
}
