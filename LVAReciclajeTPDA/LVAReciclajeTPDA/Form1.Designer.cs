﻿using System;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnEmpleado = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.lblNombreCompleto = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtNumberPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.lblLugarNacimiento = new MetroFramework.Controls.MetroLabel();
            this.lblEstadoCivil = new MetroFramework.Controls.MetroLabel();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.lblSeguroSocial = new MetroFramework.Controls.MetroLabel();
            this.rbnMasculino = new MetroFramework.Controls.MetroRadioButton();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.txtNumeroCalle = new MetroFramework.Controls.MetroTextBox();
            this.lblNumeroCalle = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoPotal = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigoPostal = new MetroFramework.Controls.MetroLabel();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.lblAdress = new MetroFramework.Controls.MetroLabel();
            this.rbnFemenino = new MetroFramework.Controls.MetroRadioButton();
            this.rbnDivorciado = new MetroFramework.Controls.MetroRadioButton();
            this.rbnCasado = new MetroFramework.Controls.MetroRadioButton();
            this.rbnSoltero = new MetroFramework.Controls.MetroRadioButton();
            this.rbnISSSTE = new MetroFramework.Controls.MetroRadioButton();
            this.rbnIMSS = new MetroFramework.Controls.MetroRadioButton();
            this.cbmLugarNacimiento = new MetroFramework.Controls.MetroComboBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnVerificar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.cbmCiudad = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.pnEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(LVAReciclajeTPDA.Data.Employee);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(LVAReciclajeTPDA.Data.Employee);
            // 
            // pnEmpleado
            // 
            this.pnEmpleado.Controls.Add(this.cbmCiudad);
            this.pnEmpleado.Controls.Add(this.cbmLugarNacimiento);
            this.pnEmpleado.Controls.Add(this.rbnISSSTE);
            this.pnEmpleado.Controls.Add(this.rbnIMSS);
            this.pnEmpleado.Controls.Add(this.rbnSoltero);
            this.pnEmpleado.Controls.Add(this.rbnDivorciado);
            this.pnEmpleado.Controls.Add(this.rbnCasado);
            this.pnEmpleado.Controls.Add(this.rbnFemenino);
            this.pnEmpleado.Controls.Add(this.lblCiudad);
            this.pnEmpleado.Controls.Add(this.txtNumeroCalle);
            this.pnEmpleado.Controls.Add(this.lblNumeroCalle);
            this.pnEmpleado.Controls.Add(this.txtCodigoPotal);
            this.pnEmpleado.Controls.Add(this.lblCodigoPostal);
            this.pnEmpleado.Controls.Add(this.txtAdress);
            this.pnEmpleado.Controls.Add(this.lblAdress);
            this.pnEmpleado.Controls.Add(this.rbnMasculino);
            this.pnEmpleado.Controls.Add(this.lblSeguroSocial);
            this.pnEmpleado.Controls.Add(this.lblLugarNacimiento);
            this.pnEmpleado.Controls.Add(this.lblEstadoCivil);
            this.pnEmpleado.Controls.Add(this.lblGenero);
            this.pnEmpleado.Controls.Add(this.txtEmail);
            this.pnEmpleado.Controls.Add(this.lblEmail);
            this.pnEmpleado.Controls.Add(this.txtNumberPhone);
            this.pnEmpleado.Controls.Add(this.lblTelefono);
            this.pnEmpleado.Controls.Add(this.txtFullName);
            this.pnEmpleado.Controls.Add(this.lblNombreCompleto);
            this.pnEmpleado.Controls.Add(this.txtId);
            this.pnEmpleado.Controls.Add(this.lblId);
            this.pnEmpleado.HorizontalScrollbarBarColor = true;
            this.pnEmpleado.HorizontalScrollbarHighlightOnWheel = false;
            this.pnEmpleado.HorizontalScrollbarSize = 10;
            this.pnEmpleado.Location = new System.Drawing.Point(220, 63);
            this.pnEmpleado.Name = "pnEmpleado";
            this.pnEmpleado.Size = new System.Drawing.Size(610, 282);
            this.pnEmpleado.TabIndex = 2;
            this.pnEmpleado.VerticalScrollbarBarColor = true;
            this.pnEmpleado.VerticalScrollbarHighlightOnWheel = false;
            this.pnEmpleado.VerticalScrollbarSize = 10;
            this.pnEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEmpleado_Paint);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.numberPhoneDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.placeOfBirthDataGridViewTextBoxColumn,
            this.healthInsuranceDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.employeeBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(211, 282);
            this.metroGrid1.TabIndex = 3;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataSource = typeof(LVAReciclajeTPDA.Data.Employee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // numberPhoneDataGridViewTextBoxColumn
            // 
            this.numberPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumberPhone";
            this.numberPhoneDataGridViewTextBoxColumn.HeaderText = "NumberPhone";
            this.numberPhoneDataGridViewTextBoxColumn.Name = "numberPhoneDataGridViewTextBoxColumn";
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            // 
            // placeOfBirthDataGridViewTextBoxColumn
            // 
            this.placeOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.HeaderText = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.Name = "placeOfBirthDataGridViewTextBoxColumn";
            // 
            // healthInsuranceDataGridViewTextBoxColumn
            // 
            this.healthInsuranceDataGridViewTextBoxColumn.DataPropertyName = "HealthInsurance";
            this.healthInsuranceDataGridViewTextBoxColumn.HeaderText = "HealthInsurance";
            this.healthInsuranceDataGridViewTextBoxColumn.Name = "healthInsuranceDataGridViewTextBoxColumn";
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(145, 13);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(129, 23);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FullName", true));
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(145, 44);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(129, 23);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(23, 44);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(122, 19);
            this.lblNombreCompleto.TabIndex = 4;
            this.lblNombreCompleto.Text = "Nombre Completo";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ContactEmail", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(145, 106);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(129, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtNumberPhone
            // 
            // 
            // 
            // 
            this.txtNumberPhone.CustomButton.Image = null;
            this.txtNumberPhone.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtNumberPhone.CustomButton.Name = "";
            this.txtNumberPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumberPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumberPhone.CustomButton.TabIndex = 1;
            this.txtNumberPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumberPhone.CustomButton.UseSelectable = true;
            this.txtNumberPhone.CustomButton.Visible = false;
            this.txtNumberPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "NumberPhone", true));
            this.txtNumberPhone.Lines = new string[0];
            this.txtNumberPhone.Location = new System.Drawing.Point(145, 75);
            this.txtNumberPhone.MaxLength = 32767;
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.SelectionLength = 0;
            this.txtNumberPhone.SelectionStart = 0;
            this.txtNumberPhone.ShortcutsEnabled = true;
            this.txtNumberPhone.Size = new System.Drawing.Size(129, 23);
            this.txtNumberPhone.TabIndex = 7;
            this.txtNumberPhone.UseSelectable = true;
            this.txtNumberPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumberPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 75);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 19);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblLugarNacimiento
            // 
            this.lblLugarNacimiento.AutoSize = true;
            this.lblLugarNacimiento.Location = new System.Drawing.Point(280, 115);
            this.lblLugarNacimiento.Name = "lblLugarNacimiento";
            this.lblLugarNacimiento.Size = new System.Drawing.Size(113, 19);
            this.lblLugarNacimiento.TabIndex = 22;
            this.lblLugarNacimiento.Text = "Lugar Nacimiento";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(280, 44);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(76, 19);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(280, 13);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 19);
            this.lblGenero.TabIndex = 18;
            this.lblGenero.Text = "Genero";
            // 
            // lblSeguroSocial
            // 
            this.lblSeguroSocial.AutoSize = true;
            this.lblSeguroSocial.Location = new System.Drawing.Point(280, 77);
            this.lblSeguroSocial.Name = "lblSeguroSocial";
            this.lblSeguroSocial.Size = new System.Drawing.Size(89, 38);
            this.lblSeguroSocial.TabIndex = 24;
            this.lblSeguroSocial.Text = "Seguro Social\r\n";
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "Gender", true));
            this.rbnMasculino.Location = new System.Drawing.Point(361, 16);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 15);
            this.rbnMasculino.TabIndex = 26;
            this.rbnMasculino.Text = "Maculino";
            this.rbnMasculino.UseSelectable = true;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(23, 228);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 33;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtNumeroCalle
            // 
            // 
            // 
            // 
            this.txtNumeroCalle.CustomButton.Image = null;
            this.txtNumeroCalle.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtNumeroCalle.CustomButton.Name = "";
            this.txtNumeroCalle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroCalle.CustomButton.TabIndex = 1;
            this.txtNumeroCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroCalle.CustomButton.UseSelectable = true;
            this.txtNumeroCalle.CustomButton.Visible = false;
            this.txtNumeroCalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "StreetNumber", true));
            this.txtNumeroCalle.Lines = new string[0];
            this.txtNumeroCalle.Location = new System.Drawing.Point(145, 197);
            this.txtNumeroCalle.MaxLength = 32767;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.PasswordChar = '\0';
            this.txtNumeroCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroCalle.SelectedText = "";
            this.txtNumeroCalle.SelectionLength = 0;
            this.txtNumeroCalle.SelectionStart = 0;
            this.txtNumeroCalle.ShortcutsEnabled = true;
            this.txtNumeroCalle.Size = new System.Drawing.Size(129, 23);
            this.txtNumeroCalle.TabIndex = 32;
            this.txtNumeroCalle.UseSelectable = true;
            this.txtNumeroCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(23, 197);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(91, 19);
            this.lblNumeroCalle.TabIndex = 31;
            this.lblNumeroCalle.Text = "Número Calle";
            // 
            // txtCodigoPotal
            // 
            // 
            // 
            // 
            this.txtCodigoPotal.CustomButton.Image = null;
            this.txtCodigoPotal.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtCodigoPotal.CustomButton.Name = "";
            this.txtCodigoPotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigoPotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoPotal.CustomButton.TabIndex = 1;
            this.txtCodigoPotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoPotal.CustomButton.UseSelectable = true;
            this.txtCodigoPotal.CustomButton.Visible = false;
            this.txtCodigoPotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ZipCode", true));
            this.txtCodigoPotal.Lines = new string[0];
            this.txtCodigoPotal.Location = new System.Drawing.Point(145, 166);
            this.txtCodigoPotal.MaxLength = 32767;
            this.txtCodigoPotal.Name = "txtCodigoPotal";
            this.txtCodigoPotal.PasswordChar = '\0';
            this.txtCodigoPotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoPotal.SelectedText = "";
            this.txtCodigoPotal.SelectionLength = 0;
            this.txtCodigoPotal.SelectionStart = 0;
            this.txtCodigoPotal.ShortcutsEnabled = true;
            this.txtCodigoPotal.Size = new System.Drawing.Size(129, 23);
            this.txtCodigoPotal.TabIndex = 30;
            this.txtCodigoPotal.UseSelectable = true;
            this.txtCodigoPotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoPotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(23, 166);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(91, 19);
            this.lblCodigoPostal.TabIndex = 29;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // txtAdress
            // 
            // 
            // 
            // 
            this.txtAdress.CustomButton.Image = null;
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(145, 135);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(129, 23);
            this.txtAdress.TabIndex = 28;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(23, 135);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 19);
            this.lblAdress.TabIndex = 27;
            this.lblAdress.Text = "Dirección";
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "Gender", true));
            this.rbnFemenino.Location = new System.Drawing.Point(440, 16);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(76, 15);
            this.rbnFemenino.TabIndex = 35;
            this.rbnFemenino.Text = "Femenino";
            this.rbnFemenino.UseSelectable = true;
            // 
            // rbnDivorciado
            // 
            this.rbnDivorciado.AutoSize = true;
            this.rbnDivorciado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "MaritalStatus", true));
            this.rbnDivorciado.Location = new System.Drawing.Point(441, 48);
            this.rbnDivorciado.Name = "rbnDivorciado";
            this.rbnDivorciado.Size = new System.Drawing.Size(80, 15);
            this.rbnDivorciado.TabIndex = 37;
            this.rbnDivorciado.Text = "Divorciado";
            this.rbnDivorciado.UseSelectable = true;
            // 
            // rbnCasado
            // 
            this.rbnCasado.AutoSize = true;
            this.rbnCasado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "MaritalStatus", true));
            this.rbnCasado.Location = new System.Drawing.Point(362, 47);
            this.rbnCasado.Name = "rbnCasado";
            this.rbnCasado.Size = new System.Drawing.Size(62, 15);
            this.rbnCasado.TabIndex = 36;
            this.rbnCasado.Text = "Casado";
            this.rbnCasado.UseSelectable = true;
            // 
            // rbnSoltero
            // 
            this.rbnSoltero.AutoSize = true;
            this.rbnSoltero.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "MaritalStatus", true));
            this.rbnSoltero.Location = new System.Drawing.Point(527, 48);
            this.rbnSoltero.Name = "rbnSoltero";
            this.rbnSoltero.Size = new System.Drawing.Size(60, 15);
            this.rbnSoltero.TabIndex = 38;
            this.rbnSoltero.Text = "Soltero";
            this.rbnSoltero.UseSelectable = true;
            // 
            // rbnISSSTE
            // 
            this.rbnISSSTE.AutoSize = true;
            this.rbnISSSTE.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "HealthInsurance", true));
            this.rbnISSSTE.Location = new System.Drawing.Point(454, 79);
            this.rbnISSSTE.Name = "rbnISSSTE";
            this.rbnISSSTE.Size = new System.Drawing.Size(56, 15);
            this.rbnISSSTE.TabIndex = 40;
            this.rbnISSSTE.Text = "ISSSTE";
            this.rbnISSSTE.UseSelectable = true;
            // 
            // rbnIMSS
            // 
            this.rbnIMSS.AutoSize = true;
            this.rbnIMSS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.employeeBindingSource, "HealthInsurance", true));
            this.rbnIMSS.Location = new System.Drawing.Point(375, 79);
            this.rbnIMSS.Name = "rbnIMSS";
            this.rbnIMSS.Size = new System.Drawing.Size(49, 15);
            this.rbnIMSS.TabIndex = 39;
            this.rbnIMSS.Text = "IMSS";
            this.rbnIMSS.UseSelectable = true;
            // 
            // cbmLugarNacimiento
            // 
            this.cbmLugarNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "PlaceOfBirth", true));
            this.cbmLugarNacimiento.FormattingEnabled = true;
            this.cbmLugarNacimiento.ItemHeight = 23;
            this.cbmLugarNacimiento.Items.AddRange(new object[] {
            "Acatlán de Osorio",
            "Amozoc",
            "Atlixco",
            "Ciudad Serdán",
            "Cuautlancingo",
            "Huauchinango",
            "Izúcar de Matamoros",
            "Puebla (Heroica Puebla)",
            "San Andrés Cholula",
            "San Martín Texmelucan de Labastida",
            "San Pedro Cholula",
            "Tecamachalco",
            "Tehuacan",
            "Tepeaca",
            "Teziutlan",
            "Xicotepec",
            "Zacatlán"});
            this.cbmLugarNacimiento.Location = new System.Drawing.Point(409, 115);
            this.cbmLugarNacimiento.Name = "cbmLugarNacimiento";
            this.cbmLugarNacimiento.Size = new System.Drawing.Size(121, 29);
            this.cbmLugarNacimiento.TabIndex = 41;
            this.cbmLugarNacimiento.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(346, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(475, 379);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(110, 38);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseSelectable = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(604, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            // 
            // cbmCiudad
            // 
            this.cbmCiudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "City", true));
            this.cbmCiudad.FormattingEnabled = true;
            this.cbmCiudad.ItemHeight = 23;
            this.cbmCiudad.Items.AddRange(new object[] {
            "Acatlán de Osorio",
            "Amozoc",
            "Atlixco",
            "Ciudad Serdán",
            "Cuautlancingo",
            "Huauchinango",
            "Izúcar de Matamoros",
            "Puebla (Heroica Puebla)",
            "San Andrés Cholula",
            "San Martín Texmelucan de Labastida",
            "San Pedro Cholula",
            "Tecamachalco",
            "Tehuacan",
            "Tepeaca",
            "Teziutlan",
            "Xicotepec",
            "Zacatlán"});
            this.cbmCiudad.Location = new System.Drawing.Point(145, 226);
            this.cbmCiudad.Name = "cbmCiudad";
            this.cbmCiudad.Size = new System.Drawing.Size(163, 29);
            this.cbmCiudad.TabIndex = 42;
            this.cbmCiudad.UseSelectable = true;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 490);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.pnEmpleado);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.pnEmpleado.ResumeLayout(false);
            this.pnEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private MetroFramework.Controls.MetroPanel pnEmpleado;
        private MetroFramework.Controls.MetroRadioButton rbnISSSTE;
        private MetroFramework.Controls.MetroRadioButton rbnIMSS;
        private MetroFramework.Controls.MetroRadioButton rbnSoltero;
        private MetroFramework.Controls.MetroRadioButton rbnDivorciado;
        private MetroFramework.Controls.MetroRadioButton rbnCasado;
        private MetroFramework.Controls.MetroRadioButton rbnFemenino;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroTextBox txtNumeroCalle;
        private MetroFramework.Controls.MetroLabel lblNumeroCalle;
        private MetroFramework.Controls.MetroTextBox txtCodigoPotal;
        private MetroFramework.Controls.MetroLabel lblCodigoPostal;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroRadioButton rbnMasculino;
        private MetroFramework.Controls.MetroLabel lblSeguroSocial;
        private MetroFramework.Controls.MetroLabel lblLugarNacimiento;
        private MetroFramework.Controls.MetroLabel lblEstadoCivil;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtNumberPhone;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroLabel lblNombreCompleto;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private MetroFramework.Controls.MetroComboBox cbmLugarNacimiento;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnVerificar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroComboBox cbmCiudad;
    }
}

