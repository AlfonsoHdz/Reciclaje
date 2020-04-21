namespace Reciclaje
{
    partial class Compra_Bien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_Bien));
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.cboTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionDelProducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.comboBox2);
            this.grpProducto.Controls.Add(this.label3);
            this.grpProducto.Controls.Add(this.comboBox1);
            this.grpProducto.Controls.Add(this.label2);
            this.grpProducto.Controls.Add(this.comboBox3);
            this.grpProducto.Controls.Add(this.label1);
            this.grpProducto.Controls.Add(this.picProducto);
            this.grpProducto.Controls.Add(this.cboTipoDeProducto);
            this.grpProducto.Controls.Add(this.txtCodigo);
            this.grpProducto.Controls.Add(this.txtDescripcionDelProducto);
            this.grpProducto.Controls.Add(this.lblDescripcionDelProducto);
            this.grpProducto.Controls.Add(this.lblCodigo);
            this.grpProducto.Controls.Add(this.lblTipoDeProducto);
            this.grpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProducto.Location = new System.Drawing.Point(61, 37);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(678, 377);
            this.grpProducto.TabIndex = 6;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Compra";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "Pet",
            "Carton",
            "Vidrio",
            "Metal"});
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(156, 140);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(188, 26);
            this.comboBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.cboTipoDeProducto.Location = new System.Drawing.Point(156, 91);
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
            this.txtDescripcionDelProducto.Location = new System.Drawing.Point(9, 347);
            this.txtDescripcionDelProducto.Name = "txtDescripcionDelProducto";
            this.txtDescripcionDelProducto.Size = new System.Drawing.Size(583, 24);
            this.txtDescripcionDelProducto.TabIndex = 5;
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(6, 308);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(173, 18);
            this.lblDescripcionDelProducto.TabIndex = 0;
            this.lblDescripcionDelProducto.Text = "Descripción del producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(85, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(6, 94);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(125, 18);
            this.lblTipoDeProducto.TabIndex = 1;
            this.lblTipoDeProducto.Text = "Tipo De Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Pet",
            "Carton",
            "Vidrio",
            "Metal"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 26);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio Unitario";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Pet",
            "Carton",
            "Vidrio",
            "Metal"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 26);
            this.comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad";
            // 
            // Compra_Bien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpProducto);
            this.Name = "Compra_Bien";
            this.Text = "Compra_Bien";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.ComboBox cboTipoDeProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcionDelProducto;
        private System.Windows.Forms.Label lblDescripcionDelProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}