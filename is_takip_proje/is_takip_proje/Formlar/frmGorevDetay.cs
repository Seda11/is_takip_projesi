using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class frmGorevDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmGorevDetay()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void frmGorevDetay_Load(object sender, EventArgs e)
        {
            db.Tbl_GorevDetaylar.Load();
            bindingSource1.DataSource = db.Tbl_GorevDetaylar.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
