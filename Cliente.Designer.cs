namespace Reciclaje
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.lblApellidoMaCliente = new System.Windows.Forms.Label();
            this.lblApellidoPaCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreClient = new System.Windows.Forms.Label();
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
            this.txtNoInterior = new System.Windows.Forms.TextBox();
            this.lblNoInterior = new System.Windows.Forms.Label();
            this.cboCiudadProv = new System.Windows.Forms.ComboBox();
            this.txtNoExterior = new System.Windows.Forms.TextBox();
            this.lblNoExterior = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.txtNoCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDatosGenerales.SuspendLayout();
            this.grpDomicilio.SuspendLayout();
            this.grpVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Blue;
            this.lblCliente.Location = new System.Drawing.Point(11, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(106, 33);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.lblProveedor_Click);
            // 
            // grpDatosGenerales
            // 
            this.grpDatosGenerales.Controls.Add(this.txtCurp);
            this.grpDatosGenerales.Controls.Add(this.lblCurp);
            this.grpDatosGenerales.Controls.Add(this.txtRfc);
            this.grpDatosGenerales.Controls.Add(this.lblRfc);
            this.grpDatosGenerales.Controls.Add(this.txtApellidoM);
            this.grpDatosGenerales.Controls.Add(this.txtApellidoP);
            this.grpDatosGenerales.Controls.Add(this.lblApellidoMaCliente);
            this.grpDatosGenerales.Controls.Add(this.lblApellidoPaCliente);
            this.grpDatosGenerales.Controls.Add(this.txtNombre);
            this.grpDatosGenerales.Controls.Add(this.lblNombreClient);
            this.grpDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosGenerales.Location = new System.Drawing.Point(12, 105);
            this.grpDatosGenerales.Name = "grpDatosGenerales";
            this.grpDatosGenerales.Size = new System.Drawing.Size(340, 318);
            this.grpDatosGenerales.TabIndex = 3;
            this.grpDatosGenerales.TabStop = false;
            this.grpDatosGenerales.Text = "Datos Generales";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(154, 213);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(166, 24);
            this.txtCurp.TabIndex = 15;
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(71, 219);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(55, 18);
            this.lblCurp.TabIndex = 14;
            this.lblCurp.Text = "CURP:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(154, 174);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(166, 24);
            this.txtRfc.TabIndex = 13;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(83, 180);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(43, 18);
            this.lblRfc.TabIndex = 12;
            this.lblRfc.Text = "RFC:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(154, 136);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(166, 24);
            this.txtApellidoM.TabIndex = 11;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(154, 92);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(166, 24);
            this.txtApellidoP.TabIndex = 10;
            // 
            // lblApellidoMaCliente
            // 
            this.lblApellidoMaCliente.AutoSize = true;
            this.lblApellidoMaCliente.Location = new System.Drawing.Point(4, 139);
            this.lblApellidoMaCliente.Name = "lblApellidoMaCliente";
            this.lblApellidoMaCliente.Size = new System.Drawing.Size(122, 18);
            this.lblApellidoMaCliente.TabIndex = 9;
            this.lblApellidoMaCliente.Text = "Apellido Materno:";
            // 
            // lblApellidoPaCliente
            // 
            this.lblApellidoPaCliente.AutoSize = true;
            this.lblApellidoPaCliente.Location = new System.Drawing.Point(7, 95);
            this.lblApellidoPaCliente.Name = "lblApellidoPaCliente";
            this.lblApellidoPaCliente.Size = new System.Drawing.Size(119, 18);
            this.lblApellidoPaCliente.TabIndex = 8;
            this.lblApellidoPaCliente.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 24);
            this.txtNombre.TabIndex = 7;
            // 
            // lblNombreClient
            // 
            this.lblNombreClient.AutoSize = true;
            this.lblNombreClient.Location = new System.Drawing.Point(60, 52);
            this.lblNombreClient.Name = "lblNombreClient";
            this.lblNombreClient.Size = new System.Drawing.Size(66, 18);
            this.lblNombreClient.TabIndex = 0;
            this.lblNombreClient.Text = "Nombre:";
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.Controls.Add(this.txtNoInterior);
            this.grpDomicilio.Controls.Add(this.lblNoInterior);
            this.grpDomicilio.Controls.Add(this.cboCiudadProv);
            this.grpDomicilio.Controls.Add(this.txtNoExterior);
            this.grpDomicilio.Controls.Add(this.lblNoExterior);
            this.grpDomicilio.Controls.Add(this.lblCiudad);
            this.grpDomicilio.Controls.Add(this.txtDireccion);
            this.grpDomicilio.Controls.Add(this.lblDireccionCliente);
            this.grpDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDomicilio.Location = new System.Drawing.Point(383, 105);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Size = new System.Drawing.Size(335, 198);
            this.grpDomicilio.TabIndex = 6;
            this.grpDomicilio.TabStop = false;
            this.grpDomicilio.Text = "Domicilio";
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Location = new System.Drawing.Point(154, 153);
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Size = new System.Drawing.Size(166, 24);
            this.txtNoInterior.TabIndex = 17;
            // 
            // lblNoInterior
            // 
            this.lblNoInterior.AutoSize = true;
            this.lblNoInterior.Location = new System.Drawing.Point(7, 159);
            this.lblNoInterior.Name = "lblNoInterior";
            this.lblNoInterior.Size = new System.Drawing.Size(77, 18);
            this.lblNoInterior.TabIndex = 16;
            this.lblNoInterior.Text = "No.Interior";
            // 
            // cboCiudadProv
            // 
            this.cboCiudadProv.FormattingEnabled = true;
            this.cboCiudadProv.Items.AddRange(new object[] {
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
            this.cboCiudadProv.Location = new System.Drawing.Point(154, 79);
            this.cboCiudadProv.Name = "cboCiudadProv";
            this.cboCiudadProv.Size = new System.Drawing.Size(121, 26);
            this.cboCiudadProv.TabIndex = 15;
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.Location = new System.Drawing.Point(154, 117);
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Size = new System.Drawing.Size(166, 24);
            this.txtNoExterior.TabIndex = 11;
            // 
            // lblNoExterior
            // 
            this.lblNoExterior.AutoSize = true;
            this.lblNoExterior.Location = new System.Drawing.Point(7, 123);
            this.lblNoExterior.Name = "lblNoExterior";
            this.lblNoExterior.Size = new System.Drawing.Size(83, 18);
            this.lblNoExterior.TabIndex = 9;
            this.lblNoExterior.Text = "No.Exterior";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(36, 87);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(54, 18);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(154, 46);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(166, 24);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(19, 52);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(71, 18);
            this.lblDireccionCliente.TabIndex = 0;
            this.lblDireccionCliente.Text = "Direccion";
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.txtTarjeta);
            this.grpVenta.Controls.Add(this.lblTipoTarjeta);
            this.grpVenta.Controls.Add(this.txtNoCelular);
            this.grpVenta.Controls.Add(this.lblCelular);
            this.grpVenta.Controls.Add(this.txtCorreo);
            this.grpVenta.Controls.Add(this.lblCorreo);
            this.grpVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.Location = new System.Drawing.Point(383, 324);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(335, 175);
            this.grpVenta.TabIndex = 7;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Venta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(154, 137);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(151, 24);
            this.txtTarjeta.TabIndex = 13;
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(27, 143);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(57, 18);
            this.lblTipoTarjeta.TabIndex = 12;
            this.lblTipoTarjeta.Text = " Tarjeta";
            // 
            // txtNoCelular
            // 
            this.txtNoCelular.Location = new System.Drawing.Point(154, 92);
            this.txtNoCelular.Name = "txtNoCelular";
            this.txtNoCelular.Size = new System.Drawing.Size(151, 24);
            this.txtNoCelular.TabIndex = 11;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 92);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(78, 18);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "No.Celular";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(154, 47);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 24);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(36, 53);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 18);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo";
            // 
            // picCliente
            // 
            this.picCliente.Image = ((System.Drawing.Image)(resources.GetObject("picCliente.Image")));
            this.picCliente.Location = new System.Drawing.Point(143, 20);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(95, 69);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCliente.TabIndex = 8;
            this.picCliente.TabStop = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnVerificar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Location = new System.Drawing.Point(22, 458);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(337, 41);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(7, 5);
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
            this.btnVerificar.Location = new System.Drawing.Point(114, 5);
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
            this.btnGuardar.Location = new System.Drawing.Point(224, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 531);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.picCliente);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.grpDomicilio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.grpDatosGenerales);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.grpDatosGenerales.ResumeLayout(false);
            this.grpDatosGenerales.PerformLayout();
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grpDatosGenerales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreClient;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label lblApellidoMaCliente;
        private System.Windows.Forms.Label lblApellidoPaCliente;
        private System.Windows.Forms.GroupBox grpDomicilio;
        private System.Windows.Forms.TextBox txtNoExterior;
        private System.Windows.Forms.Label lblNoExterior;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.ComboBox cboCiudadProv;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txtNoInterior;
        private System.Windows.Forms.Label lblNoInterior;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.TextBox txtNoCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}