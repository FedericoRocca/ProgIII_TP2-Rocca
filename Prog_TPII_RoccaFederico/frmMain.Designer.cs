namespace Prog_TPII_RoccaFederico
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.ddbtnArticulos = new System.Windows.Forms.ToolStripDropDownButton();
            this.smiArticuloAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.smiArticuloListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiArticuloBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbtnCategorias = new System.Windows.Forms.ToolStripDropDownButton();
            this.smiCategoriaAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCategoriaListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCategoriaBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbtnMarcas = new System.Windows.Forms.ToolStripDropDownButton();
            this.smiMarcaAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.smiMarcaListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiMarcaBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbtnArticulos,
            this.ddbtnCategorias,
            this.ddbtnMarcas});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(800, 25);
            this.tspMenu.TabIndex = 0;
            this.tspMenu.Text = "Menu";
            // 
            // ddbtnArticulos
            // 
            this.ddbtnArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbtnArticulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiArticuloAlta,
            this.smiArticuloListar,
            this.smiArticuloBuscar});
            this.ddbtnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnArticulos.Image")));
            this.ddbtnArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnArticulos.Name = "ddbtnArticulos";
            this.ddbtnArticulos.Size = new System.Drawing.Size(67, 22);
            this.ddbtnArticulos.Text = "Artículos";
            // 
            // smiArticuloAlta
            // 
            this.smiArticuloAlta.Name = "smiArticuloAlta";
            this.smiArticuloAlta.Size = new System.Drawing.Size(109, 22);
            this.smiArticuloAlta.Text = "Alta";
            // 
            // smiArticuloListar
            // 
            this.smiArticuloListar.Name = "smiArticuloListar";
            this.smiArticuloListar.Size = new System.Drawing.Size(109, 22);
            this.smiArticuloListar.Text = "Listar";
            // 
            // smiArticuloBuscar
            // 
            this.smiArticuloBuscar.Name = "smiArticuloBuscar";
            this.smiArticuloBuscar.Size = new System.Drawing.Size(109, 22);
            this.smiArticuloBuscar.Text = "Buscar";
            // 
            // ddbtnCategorias
            // 
            this.ddbtnCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbtnCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiCategoriaAlta,
            this.smiCategoriaListar,
            this.smiCategoriaBuscar});
            this.ddbtnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnCategorias.Image")));
            this.ddbtnCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnCategorias.Name = "ddbtnCategorias";
            this.ddbtnCategorias.Size = new System.Drawing.Size(76, 22);
            this.ddbtnCategorias.Text = "Categorías";
            // 
            // smiCategoriaAlta
            // 
            this.smiCategoriaAlta.Name = "smiCategoriaAlta";
            this.smiCategoriaAlta.Size = new System.Drawing.Size(109, 22);
            this.smiCategoriaAlta.Text = "Alta";
            // 
            // smiCategoriaListar
            // 
            this.smiCategoriaListar.Name = "smiCategoriaListar";
            this.smiCategoriaListar.Size = new System.Drawing.Size(109, 22);
            this.smiCategoriaListar.Text = "Listar";
            // 
            // smiCategoriaBuscar
            // 
            this.smiCategoriaBuscar.Name = "smiCategoriaBuscar";
            this.smiCategoriaBuscar.Size = new System.Drawing.Size(109, 22);
            this.smiCategoriaBuscar.Text = "Buscar";
            // 
            // ddbtnMarcas
            // 
            this.ddbtnMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbtnMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiMarcaAlta,
            this.smiMarcaListar,
            this.smiMarcaBuscar});
            this.ddbtnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnMarcas.Image")));
            this.ddbtnMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnMarcas.Name = "ddbtnMarcas";
            this.ddbtnMarcas.Size = new System.Drawing.Size(58, 22);
            this.ddbtnMarcas.Text = "Marcas";
            // 
            // smiMarcaAlta
            // 
            this.smiMarcaAlta.Name = "smiMarcaAlta";
            this.smiMarcaAlta.Size = new System.Drawing.Size(180, 22);
            this.smiMarcaAlta.Text = "Alta";
            this.smiMarcaAlta.Click += new System.EventHandler(this.smiMarcaAlta_Click);
            // 
            // smiMarcaListar
            // 
            this.smiMarcaListar.Name = "smiMarcaListar";
            this.smiMarcaListar.Size = new System.Drawing.Size(180, 22);
            this.smiMarcaListar.Text = "Listar";
            this.smiMarcaListar.Click += new System.EventHandler(this.smiMarcaListar_Click);
            // 
            // smiMarcaBuscar
            // 
            this.smiMarcaBuscar.Name = "smiMarcaBuscar";
            this.smiMarcaBuscar.Size = new System.Drawing.Size(180, 22);
            this.smiMarcaBuscar.Text = "Buscar";
            this.smiMarcaBuscar.Click += new System.EventHandler(this.smiMarcaBuscar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prog_TPII_RoccaFederico.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tspMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Programación III - Trabajo práctico N° 2";
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnArticulos;
        private System.Windows.Forms.ToolStripMenuItem smiArticuloAlta;
        private System.Windows.Forms.ToolStripMenuItem smiArticuloListar;
        private System.Windows.Forms.ToolStripMenuItem smiArticuloBuscar;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnCategorias;
        private System.Windows.Forms.ToolStripMenuItem smiCategoriaAlta;
        private System.Windows.Forms.ToolStripMenuItem smiCategoriaListar;
        private System.Windows.Forms.ToolStripMenuItem smiCategoriaBuscar;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnMarcas;
        private System.Windows.Forms.ToolStripMenuItem smiMarcaAlta;
        private System.Windows.Forms.ToolStripMenuItem smiMarcaListar;
        private System.Windows.Forms.ToolStripMenuItem smiMarcaBuscar;
    }
}

