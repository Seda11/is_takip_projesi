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
    public partial class frmCagriListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCagriListesi()
        {
            InitializeComponent();
        }
        DB_IsTakipEntities db = new DB_IsTakipEntities();
        private void frmCagriListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Cagri
                                       select new
                                       {
                                           x.ID,
                                           x.Tbl_Firmalar.Ad,
                                           x.Tbl_Firmalar.Telefon,
                                           x.Tbl_Firmalar.Mail,
                                           x.Aciklama,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmCagriDetayGiris fr = new frmCagriDetayGiris();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
