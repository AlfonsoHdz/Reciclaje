using System;

namespace LVAReciclajeTPDA
{
    partial class frmEmpleado
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
            this.lblRegistroEmpleado = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblRegistroEmpleado
            // 
            this.lblRegistroEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRegistroEmpleado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRegistroEmpleado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRegistroEmpleado.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegistroEmpleado.Location = new System.Drawing.Point(286, 40);
            this.lblRegistroEmpleado.Name = "lblRegistroEmpleado";
            this.lblRegistroEmpleado.Size = new System.Drawing.Size(201, 40);
            this.lblRegistroEmpleado.TabIndex = 0;
            this.lblRegistroEmpleado.Text = "Registro Empleado";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 364);
            this.Controls.Add(this.lblRegistroEmpleado);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblRegistroEmpleado;
    }
}

