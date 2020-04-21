namespace Reciclaje
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.lblDescripcionDelProducto = new System.Windows.Forms.Label();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.cboTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalVendido = new System.Windows.Forms.Label();
            this.txtTotalVendido = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(6, 284);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(173, 18);
            this.lblDescripcionDelProducto.TabIndex = 0;
            this.lblDescripcionDelProducto.Text = "Descripción del producto";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(6, 104);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(125, 18);
            this.lblTipoDeProducto.TabIndex = 1;
            this.lblTipoDeProducto.Text = "Tipo De Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(75, 62);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.txtTotalVendido);
            this.grpProducto.Controls.Add(this.lblTotalVendido);
            this.grpProducto.Controls.Add(this.lblCantidad);
            this.grpProducto.Controls.Add(this.picProducto);
            this.grpProducto.Controls.Add(this.cboTipoDeProducto);
            this.grpProducto.Controls.Add(this.txtCodigo);
            this.grpProducto.Controls.Add(this.txtDescripcionDelProducto);
            this.grpProducto.Controls.Add(this.lblDescripcionDelProducto);
            this.grpProducto.Controls.Add(this.lblCodigo);
            this.grpProducto.Controls.Add(this.lblTipoDeProducto);
            this.grpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProducto.Location = new System.Drawing.Point(24, 22);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(678, 377);
            this.grpProducto.TabIndex = 5;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            this.grpProducto.Enter += new System.EventHandler(this.grpProducto_Enter);
            // 
            // picProducto
            // 
            this.picProducto.Image = ((System.Drawing.Image)(resources.GetObject("picProducto.Image")));
            this.picProducto.Location = new System.Drawing.Point(382, 36);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(210, 181);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProducto.TabIndex = 6;
            this.picProducto.TabStop = false;
            // 
            // cboTipoDeProducto
            // 
            this.cboTipoDeProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Pet",
            "Carton",
            "Vidrio",
            "Metal"});
            this.cboTipoDeProducto.FormattingEnabled = true;
            this.cboTipoDeProducto.Location = new System.Drawing.Point(156, 96);
            this.cboTipoDeProducto.Name = "cboTipoDeProducto";
            this.cboTipoDeProducto.Size = new System.Drawing.Size(188, 26);
            this.cboTipoDeProducto.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(156, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(188, 24);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtDescripcionDelProducto
            // 
            this.txtDescripcionDelProducto.Location = new System.Drawing.Point(38, 337);
            this.txtDescripcionDelProducto.Name = "txtDescripcionDelProducto";
            this.txtDescripcionDelProducto.Size = new System.Drawing.Size(583, 24);
            this.txtDescripcionDelProducto.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(65, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalVendido
            // 
            this.lblTotalVendido.AutoSize = true;
            this.lblTotalVendido.Location = new System.Drawing.Point(33, 194);
            this.lblTotalVendido.Name = "lblTotalVendido";
            this.lblTotalVendido.Size = new System.Drawing.Size(98, 18);
            this.lblTotalVendido.TabIndex = 11;
            this.lblTotalVendido.Text = "Total Vendido";
            // 
            // txtTotalVendido
            // 
            this.txtTotalVendido.Location = new System.Drawing.Point(156, 188);
            this.txtTotalVendido.Name = "txtTotalVendido";
            this.txtTotalVendido.Size = new System.Drawing.Size(188, 24);
            this.txtTotalVendido.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(156, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(188, 24);
            this.txtCantidad.TabIndex = 13;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpProducto);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionDelProducto;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.ComboBox cboTipoDeProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcionDelProducto;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalVendido;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTotalVendido;
    }
}