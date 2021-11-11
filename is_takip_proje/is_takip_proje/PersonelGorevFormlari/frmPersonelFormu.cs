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
    public partial class frmPersonelFormu : DevExpress.XtraEditors.XtraForm
    {
        public frmPersonelFormu()
        {
            InitializeComponent();
        }
        PersonelGorevFormlari.frmAktifGorevler fr;
        PersonelGorevFormlari.frmPasifGorevler frp;
        PersonelGorevFormlari.frmCagriListesi frc;
        private void btnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new PersonelGorevFormlari.frmAktifGorevler();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                fr.Close();
                fr = new PersonelGorevFormlari.frmAktifGorevler();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frp == null || frp.IsDisposed)
            {
                frp = new PersonelGorevFormlari.frmPasifGorevler();
                frp.MdiParent = this;
                frp.Show();
            }
            else
            {
                frp.Close();
                frp = new PersonelGorevFormlari.frmPasifGorevler();
                frp.MdiParent = this;
                frp.Show();
            }
        }

        private void btnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frc == null || frc.IsDisposed)
            {
                frc = new PersonelGorevFormlari.frmCagriListesi();
                frc.MdiParent = this;
                frc.Show();
            }
            else
            {
                frc.Close();
                frc = new PersonelGorevFormlari.frmCagriListesi();
                frc.MdiParent = this;
                frc.Show();
            }
        }
        Login.frmLogin f;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            f = new Login.frmLogin();
            f.Show();
        }
    }
}
