﻿
namespace PV
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupCategorias = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colprecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupMarca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Editar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.LargeImage")));
            this.btnModificar.Name = "btnModificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(883, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(883, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(883, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // gcProductos
            // 
            this.gcProductos.DataSource = this.productosBindingSource1;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProductos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcProductos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcProductos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcProductos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcProductos.Location = new System.Drawing.Point(0, 30);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.MenuManager = this.barManager1;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupCategorias,
            this.rlupMarca});
            this.gcProductos.Size = new System.Drawing.Size(883, 481);
            this.gcProductos.TabIndex = 4;
            this.gcProductos.UseEmbeddedNavigator = true;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            this.gcProductos.Click += new System.EventHandler(this.gcProductos_Click);
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataSource = typeof(BOL.Productos);
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProducto,
            this.coldescripcion,
            this.colidCategoria,
            this.colprecioUnitario,
            this.colstock,
            this.colcodigo,
            this.colidMarca,
            this.colactivo});
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsView.ColumnAutoWidth = false;
            this.gvProductos.OptionsView.ShowAutoFilterRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "ID";
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 25;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            this.colidProducto.Width = 94;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.MinWidth = 25;
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 94;
            // 
            // colidCategoria
            // 
            this.colidCategoria.Caption = "Categoria";
            this.colidCategoria.ColumnEdit = this.rlupCategorias;
            this.colidCategoria.FieldName = "idCategoria";
            this.colidCategoria.MinWidth = 25;
            this.colidCategoria.Name = "colidCategoria";
            this.colidCategoria.Visible = true;
            this.colidCategoria.VisibleIndex = 2;
            this.colidCategoria.Width = 94;
            // 
            // rlupCategorias
            // 
            this.rlupCategorias.AutoHeight = false;
            this.rlupCategorias.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupCategorias.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Categoria", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupCategorias.DataSource = this.categoriasBindingSource;
            this.rlupCategorias.DisplayMember = "descripcion";
            this.rlupCategorias.Name = "rlupCategorias";
            this.rlupCategorias.ValueMember = "idCategoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(BOL.Categorias);
            // 
            // colprecioUnitario
            // 
            this.colprecioUnitario.Caption = "Precio Unitario";
            this.colprecioUnitario.FieldName = "precioUnitario";
            this.colprecioUnitario.MinWidth = 25;
            this.colprecioUnitario.Name = "colprecioUnitario";
            this.colprecioUnitario.Visible = true;
            this.colprecioUnitario.VisibleIndex = 5;
            this.colprecioUnitario.Width = 94;
            // 
            // colstock
            // 
            this.colstock.Caption = "Stock";
            this.colstock.FieldName = "stock";
            this.colstock.MinWidth = 25;
            this.colstock.Name = "colstock";
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 6;
            this.colstock.Width = 94;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.MinWidth = 25;
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 4;
            this.colcodigo.Width = 94;
            // 
            // colidMarca
            // 
            this.colidMarca.Caption = "Marca";
            this.colidMarca.ColumnEdit = this.rlupMarca;
            this.colidMarca.FieldName = "idMarca";
            this.colidMarca.MinWidth = 25;
            this.colidMarca.Name = "colidMarca";
            this.colidMarca.Visible = true;
            this.colidMarca.VisibleIndex = 3;
            this.colidMarca.Width = 94;
            // 
            // rlupMarca
            // 
            this.rlupMarca.AutoHeight = false;
            this.rlupMarca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupMarca.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Marca", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupMarca.DataSource = this.marcasBindingSource;
            this.rlupMarca.DisplayMember = "descripcion";
            this.rlupMarca.Name = "rlupMarca";
            this.rlupMarca.ValueMember = "idMarca";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataSource = typeof(BOL.Marcas);
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(BOL.Productos);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmProductos.IconOptions.LargeImage")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colidMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupCategorias;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupMarca;
        private System.Windows.Forms.BindingSource marcasBindingSource;
    }
}