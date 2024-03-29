﻿
namespace AEV7_David_Alberto
{
    partial class FrmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.gpbGestionEmpleados = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblGestionEmpleados = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.lblInfoEmpleados = new System.Windows.Forms.Label();
            this.lblInfoFichajes = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.gpbGestionEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGestionEmpleados
            // 
            this.gpbGestionEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gpbGestionEmpleados.Controls.Add(this.btnEliminar);
            this.gpbGestionEmpleados.Controls.Add(this.btnAgregar);
            this.gpbGestionEmpleados.Controls.Add(this.txtContrasenya);
            this.gpbGestionEmpleados.Controls.Add(this.lblContrasenya);
            this.gpbGestionEmpleados.Controls.Add(this.chkAdministrador);
            this.gpbGestionEmpleados.Controls.Add(this.txtApellidos);
            this.gpbGestionEmpleados.Controls.Add(this.txtNombre);
            this.gpbGestionEmpleados.Controls.Add(this.txtNIF);
            this.gpbGestionEmpleados.Controls.Add(this.lblApellidos);
            this.gpbGestionEmpleados.Controls.Add(this.lblNombre);
            this.gpbGestionEmpleados.Controls.Add(this.lblNIF);
            this.gpbGestionEmpleados.Controls.Add(this.lblGestionEmpleados);
            this.gpbGestionEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbGestionEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbGestionEmpleados.Location = new System.Drawing.Point(611, 55);
            this.gpbGestionEmpleados.Name = "gpbGestionEmpleados";
            this.gpbGestionEmpleados.Size = new System.Drawing.Size(346, 368);
            this.gpbGestionEmpleados.TabIndex = 0;
            this.gpbGestionEmpleados.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEliminar.Location = new System.Drawing.Point(186, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 45);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.Location = new System.Drawing.Point(33, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 45);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Enabled = false;
            this.txtContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenya.Location = new System.Drawing.Point(118, 233);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.PasswordChar = '*';
            this.txtContrasenya.Size = new System.Drawing.Size(174, 23);
            this.txtContrasenya.TabIndex = 9;
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenya.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblContrasenya.Location = new System.Drawing.Point(28, 236);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(96, 17);
            this.lblContrasenya.TabIndex = 8;
            this.lblContrasenya.Text = "Contraseña:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkAdministrador.Location = new System.Drawing.Point(118, 195);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(131, 22);
            this.chkAdministrador.TabIndex = 7;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            this.chkAdministrador.CheckedChanged += new System.EventHandler(this.chkAdministrador_CheckedChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(118, 153);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(174, 23);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(118, 85);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(105, 23);
            this.txtNIF.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblApellidos.Location = new System.Drawing.Point(42, 156);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(79, 17);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombre.Location = new System.Drawing.Point(51, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNIF.Location = new System.Drawing.Point(78, 87);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(37, 17);
            this.lblNIF.TabIndex = 1;
            this.lblNIF.Text = "NIF:";
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGestionEmpleados.Location = new System.Drawing.Point(28, 25);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(311, 26);
            this.lblGestionEmpleados.TabIndex = 0;
            this.lblGestionEmpleados.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnVolver.Location = new System.Drawing.Point(718, 452);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 45);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 55);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(554, 223);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvFichajes.Location = new System.Drawing.Point(25, 316);
            this.dgvFichajes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.RowTemplate.Height = 24;
            this.dgvFichajes.Size = new System.Drawing.Size(554, 220);
            this.dgvFichajes.TabIndex = 14;
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInfoEmpleados.Location = new System.Drawing.Point(22, 36);
            this.lblInfoEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(232, 18);
            this.lblInfoEmpleados.TabIndex = 15;
            this.lblInfoEmpleados.Text = "Información de EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInfoFichajes.Location = new System.Drawing.Point(22, 297);
            this.lblInfoFichajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(209, 18);
            this.lblInfoFichajes.TabIndex = 16;
            this.lblInfoFichajes.Text = "Información de FICHAJES:";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // pbSalir
            // 
            this.pbSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(940, 9);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(2);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(30, 30);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 17;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbGestionEmpleados);
            this.Name = "FrmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionalidades de Mantenimiento (Perfil Administrador)";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.gpbGestionEmpleados.ResumeLayout(false);
            this.gpbGestionEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGestionEmpleados;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblGestionEmpleados;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.Label lblInfoEmpleados;
        private System.Windows.Forms.Label lblInfoFichajes;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.PictureBox pbSalir;
    }
}