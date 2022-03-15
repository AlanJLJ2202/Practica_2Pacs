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
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {

        private CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        private MarcaBLL marcaBLL = MarcaBLL.Instance();

        public frmNProducto()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNProducto_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            marcasBindingSource.DataSource = marcaBLL.GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El id de categoria es: " + lupCategoria.EditValue);
        }
    }
}