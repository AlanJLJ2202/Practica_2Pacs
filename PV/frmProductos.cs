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

        private ProductoBLL productoBLL = ProductoBLL.Instance();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            gcProductos.DataSource = productoBLL.GetAll();
            gvProductos.BestFitColumns();
        }
    }
}