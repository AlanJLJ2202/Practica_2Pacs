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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        private CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        private MarcaBLL marcaBLL = MarcaBLL.Instance();
        private ProductoBLL productoBLL = ProductoBLL.Instance();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            productosBindingSource1.DataSource = productoBLL.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void gcProductos_Click(object sender, EventArgs e)
        {

        }
    }
}