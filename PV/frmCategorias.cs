using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        private CategoriaBLL categoriaBLL = CategoriaBLL.Instance(); 

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            gcCategorias.DataSource = categoriaBLL.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void gcCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idCategoria = (int)gvCategorias.GetFocusedRowCellValue("idCategoria");
            new frmMCategoria(idCategoria).ShowDialog();
            
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcCategorias.DataSource = categoriaBLL.GetAll();
            gvCategorias.BestFitColumns();
        }
    }
}