using BLL;
using BOL;
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
    public partial class frmMCategoria : DevExpress.XtraEditors.XtraForm
    {

        private int idCategoria;
        private CategoriaBLL categoriaBLL = CategoriaBLL.Instance();

        public frmMCategoria()
        {
            InitializeComponent();
        }

        public frmMCategoria(int idCategoria)
        {
            InitializeComponent();
            this.idCategoria = idCategoria;

        }


        private void frmMCategoria_Load(object sender, EventArgs e)
        {
            //Consultar la categoria por el ID Seleccionado
            Categoria categoria = categoriaBLL.GetByID(new Categoria() { idCategoria = this.idCategoria});
            txtDescripcion.Text = categoria.descripcion;
            CenterToScreen();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (categoriaBLL.Update(new Categoria(){
               idCategoria = this.idCategoria,
               descripcion = txtDescripcion.Text
            }
           
            ))
            {

            }
        }
    }
}