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
    public partial class FrmAktifCagrilar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            DB_IsTakipEntities db = new DB_IsTakipEntities();

            var degerler = (from x in db.Tbl_Cagri
                            select new
                            {
                                x.ID,
                                x.Tbl_Firmalar.Ad,
                                x.Tbl_Firmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                personel = x.Tbl_Personel.Ad,
                                x.Durum
                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmCagriAtama fr = new frmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
