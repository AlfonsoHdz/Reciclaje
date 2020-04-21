namespace Reciclaje
{
    partial class frmReciclaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReciclaje));
            this.grpDatosP = new System.Windows.Forms.GroupBox();
            this.lblCudadProv = new System.Windows.Forms.Label();
            this.cboCiudadProov = new System.Windows.Forms.ComboBox();
            this.txtWebProv = new System.Windows.Forms.TextBox();
            this.txtCorreoProv = new System.Windows.Forms.TextBox();
            this.txtCelularProv = new System.Windows.Forms.TextBox();
            this.txtTelefonoProv = new System.Windows.Forms.TextBox();
            this.txtCodigoProv = new System.Windows.Forms.TextBox();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.lblWebProv = new System.Windows.Forms.Label();
            this.lblCorreoProv = new System.Windows.Forms.Label();
            this.lblCelularProv = new System.Windows.Forms.Label();
            this.lblTelefonoProv = new System.Windows.Forms.Label();
            this.lblCodigoProv = new System.Windows.Forms.Label();
            this.lblDireccionProv = new System.Windows.Forms.Label();
            this.lblMarcaProveedor = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.picProveedores = new System.Windows.Forms.PictureBox();
            this.grpDatosP.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosP
            // 
            this.grpDatosP.Controls.Add(this.lblCudadProv);
            this.grpDatosP.Controls.Add(this.cboCiudadProov);
            this.grpDatosP.Controls.Add(this.txtWebProv);
            this.grpDatosP.Controls.Add(this.txtCorreoProv);
            this.grpDatosP.Controls.Add(this.txtCelularProv);
            this.grpDatosP.Controls.Add(this.txtTelefonoProv);
            this.grpDatosP.Controls.Add(this.txtCodigoProv);
            this.grpDatosP.Controls.Add(this.txtDireccionProv);
            this.grpDatosP.Controls.Add(this.txtNombreProv);
            this.grpDatosP.Controls.Add(this.lblWebProv);
            this.grpDatosP.Controls.Add(this.lblCorreoProv);
            this.grpDatosP.Controls.Add(this.lblCelularProv);
            this.grpDatosP.Controls.Add(this.lblTelefonoProv);
            this.grpDatosP.Controls.Add(this.lblCodigoProv);
            this.grpDatosP.Controls.Add(this.lblDireccionProv);
            this.grpDatosP.Controls.Add(this.lblMarcaProveedor);
            this.grpDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosP.Location = new System.Drawing.Point(33, 110);
            this.grpDatosP.Name = "grpDatosP";
            this.grpDatosP.Size = new System.Drawing.Size(757, 279);
            this.grpDatosP.TabIndex = 0;
            this.grpDatosP.TabStop = false;
            this.grpDatosP.Text = "Datos del Proveedor";
            // 
            // lblCudadProv
            // 
            this.lblCudadProv.AutoSize = true;
            this.lblCudadProv.Location = new System.Drawing.Point(118, 133);
            this.lblCudadProv.Name = "lblCudadProv";
            this.lblCudadProv.Size = new System.Drawing.Size(59, 20);
            this.lblCudadProv.TabIndex = 15;
            this.lblCudadProv.Text = "Ciudad";
            // 
            // cboCiudadProov
            // 
            this.cboCiudadProov.FormattingEnabled = true;
            this.cboCiudadProov.Items.AddRange(new object[] {
            " Aguascalientes \t    ",
            " Baja California \t      ",
            " Baja California Sur \t   ",
            " Campeche \t     ",
            " Chiapas \t      ",
            " Chihuahua \t    ",
            " Ciudad de México \t   ",
            " Coahuila de Zaragoza \t    ",
            " Colima \t      ",
            " Durango \t     ",
            " Estado de México \t      ",
            " Guanajuato \t      ",
            " Guerrero \t     ",
            " Hidalgo \t     ",
            " Jalisco \t     ",
            " Michoacán de Ocampo \t     ",
            " Morelos \t     ",
            " Nayarit \t   ",
            " Nuevo León \t ",
            " Oaxaca \t     ",
            " Puebla \t      ",
            " Querétaro \t    ",
            " Quintana Roo \t     ",
            " San Luis Potosí \t   ",
            " Sin Localidad \t  ",
            " Sinaloa \t    ",
            " Sonora \t   ",
            " Tabasco \t     ",
            " Tamaulipas \t ",
            " Tlaxcala \t      ",
            " Veracruz  ",
            " Yucatán \t     ",
            " Zacatecas"});
            this.cboCiudadProov.Location = new System.Drawing.Point(205, 127);
            this.cboCiudadProov.Name = "cboCiudadProov";
            this.cboCiudadProov.Size = new System.Drawing.Size(121, 28);
            this.cboCiudadProov.TabIndex = 14;
            this.cboCiudadProov.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // txtWebProv
            // 
            this.txtWebProv.Location = new System.Drawing.Point(559, 127);
            this.txtWebProv.Name = "txtWebProv";
            this.txtWebProv.Size = new System.Drawing.Size(179, 26);
            this.txtWebProv.TabIndex = 13;
            // 
            // txtCorreoProv
            // 
            this.txtCorreoProv.Location = new System.Drawing.Point(559, 86);
            this.txtCorreoProv.Name = "txtCorreoProv";
            this.txtCorreoProv.Size = new System.Drawing.Size(179, 26);
            this.txtCorreoProv.TabIndex = 12;
            // 
            // txtCelularProv
            // 
            this.txtCelularProv.Location = new System.Drawing.Point(559, 43);
            this.txtCelularProv.Name = "txtCelularProv";
            this.txtCelularProv.Size = new System.Drawing.Size(179, 26);
            this.txtCelularProv.TabIndex = 11;
            // 
            // txtTelefonoProv
            // 
            this.txtTelefonoProv.Location = new System.Drawing.Point(205, 217);
            this.txtTelefonoProv.Name = "txtTelefonoProv";
            this.txtTelefonoProv.Size = new System.Drawing.Size(151, 26);
            this.txtTelefonoProv.TabIndex = 10;
            // 
            // txtCodigoProv
            // 
            this.txtCodigoProv.Location = new System.Drawing.Point(205, 173);
            this.txtCodigoProv.Name = "txtCodigoProv";
            this.txtCodigoProv.Size = new System.Drawing.Size(151, 26);
            this.txtCodigoProv.TabIndex = 9;
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(205, 89);
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(241, 26);
            this.txtDireccionProv.TabIndex = 8;
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(205, 46);
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(241, 26);
            this.txtNombreProv.TabIndex = 7;
            // 
            // lblWebProv
            // 
            this.lblWebProv.AutoSize = true;
            this.lblWebProv.Location = new System.Drawing.Point(507, 127);
            this.lblWebProv.Name = "lblWebProv";
            this.lblWebProv.Size = new System.Drawing.Size(46, 20);
            this.lblWebProv.TabIndex = 6;
            this.lblWebProv.Text = "Web:";
            // 
            // lblCorreoProv
            // 
            this.lblCorreoProv.AutoSize = true;
            this.lblCorreoProv.Location = new System.Drawing.Point(492, 89);
            this.lblCorreoProv.Name = "lblCorreoProv";
            this.lblCorreoProv.Size = new System.Drawing.Size(61, 20);
            this.lblCorreoProv.TabIndex = 5;
            this.lblCorreoProv.Text = "Correo:";
            // 
            // lblCelularProv
            // 
            this.lblCelularProv.AutoSize = true;
            this.lblCelularProv.Location = new System.Drawing.Point(491, 49);
            this.lblCelularProv.Name = "lblCelularProv";
            this.lblCelularProv.Size = new System.Drawing.Size(62, 20);
            this.lblCelularProv.TabIndex = 4;
            this.lblCelularProv.Text = "Celular:";
            // 
            // lblTelefonoProv
            // 
            this.lblTelefonoProv.AutoSize = true;
            this.lblTelefonoProv.Location = new System.Drawing.Point(114, 223);
            this.lblTelefonoProv.Name = "lblTelefonoProv";
            this.lblTelefonoProv.Size = new System.Drawing.Size(75, 20);
            this.lblTelefonoProv.TabIndex = 3;
            this.lblTelefonoProv.Text = "Teléfono:";
            // 
            // lblCodigoProv
            // 
            this.lblCodigoProv.AutoSize = true;
            this.lblCodigoProv.Location = new System.Drawing.Point(78, 179);
            this.lblCodigoProv.Name = "lblCodigoProv";
            this.lblCodigoProv.Size = new System.Drawing.Size(111, 20);
            this.lblCodigoProv.TabIndex = 2;
            this.lblCodigoProv.Text = "Código Postal:";
            // 
            // lblDireccionProv
            // 
            this.lblDireccionProv.AutoSize = true;
            this.lblDireccionProv.Location = new System.Drawing.Point(110, 95);
            this.lblDireccionProv.Name = "lblDireccionProv";
            this.lblDireccionProv.Size = new System.Drawing.Size(79, 20);
            this.lblDireccionProv.TabIndex = 1;
            this.lblDireccionProv.Text = "Dirección:";
            // 
            // lblMarcaProveedor
            // 
            this.lblMarcaProveedor.AutoSize = true;
            this.lblMarcaProveedor.Location = new System.Drawing.Point(23, 49);
            this.lblMarcaProveedor.Name = "lblMarcaProveedor";
            this.lblMarcaProveedor.Size = new System.Drawing.Size(157, 20);
            this.lblMarcaProveedor.TabIndex = 0;
            this.lblMarcaProveedor.Text = "Marca Del Proveedor";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.Blue;
            this.lblProveedor.Location = new System.Drawing.Point(27, 38);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(335, 33);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Registro de Proveedores";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnVerificar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Location = new System.Drawing.Point(460, 409);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(330, 41);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(18, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 33);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(116, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(92, 33);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(214, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // picProveedores
            // 
            this.picProveedores.Image = ((System.Drawing.Image)(resources.GetObject("picProveedores.Image")));
            this.picProveedores.Location = new System.Drawing.Point(406, 38);
            this.picProveedores.Name = "picProveedores";
            this.picProveedores.Size = new System.Drawing.Size(73, 55);
            this.picProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProveedores.TabIndex = 2;
            this.picProveedores.TabStop = false;
            // 
            // frmReciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 579);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.picProveedores);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.grpDatosP);
            this.Name = "frmReciclaje";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmReciclaje_Load);
            this.grpDatosP.ResumeLayout(false);
            this.grpDatosP.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosP;
        private System.Windows.Forms.Label lblCudadProv;
        private System.Windows.Forms.ComboBox cboCiudadProov;
        private System.Windows.Forms.TextBox txtWebProv;
        private System.Windows.Forms.TextBox txtCorreoProv;
        private System.Windows.Forms.TextBox txtCelularProv;
        private System.Windows.Forms.TextBox txtTelefonoProv;
        private System.Windows.Forms.TextBox txtCodigoProv;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.Label lblWebProv;
        private System.Windows.Forms.Label lblCorreoProv;
        private System.Windows.Forms.Label lblCelularProv;
        private System.Windows.Forms.Label lblTelefonoProv;
        private System.Windows.Forms.Label lblCodigoProv;
        private System.Windows.Forms.Label lblDireccionProv;
        private System.Windows.Forms.Label lblMarcaProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.PictureBox picProveedores;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

