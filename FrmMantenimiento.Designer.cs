
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
            this.gpbGestionEmpleados = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblGestionEmpleados = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.lblInfoEmpleados = new System.Windows.Forms.Label();
            this.lblInfoFichajes = new System.Windows.Forms.Label();
            this.gpbGestionEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGestionEmpleados
            // 
            this.gpbGestionEmpleados.Controls.Add(this.btnEliminar);
            this.gpbGestionEmpleados.Controls.Add(this.btnAgregar);
            this.gpbGestionEmpleados.Controls.Add(this.txtContrasenya);
            this.gpbGestionEmpleados.Controls.Add(this.label1);
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
            this.gpbGestionEmpleados.Location = new System.Drawing.Point(617, 55);
            this.gpbGestionEmpleados.Name = "gpbGestionEmpleados";
            this.gpbGestionEmpleados.Size = new System.Drawing.Size(311, 341);
            this.gpbGestionEmpleados.TabIndex = 0;
            this.gpbGestionEmpleados.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(176, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(89, 219);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.PasswordChar = '*';
            this.txtContrasenya.Size = new System.Drawing.Size(174, 20);
            this.txtContrasenya.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.Location = new System.Drawing.Point(89, 180);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(112, 19);
            this.chkAdministrador.TabIndex = 7;
            this.chkAdministrador.Text = "Administrador/a";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(89, 139);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(174, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(89, 70);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(105, 20);
            this.txtNIF.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(25, 139);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(60, 15);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(54, 75);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(29, 15);
            this.lblNIF.TabIndex = 1;
            this.lblNIF.Text = "NIF:";
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.Location = new System.Drawing.Point(82, 30);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(179, 16);
            this.lblGestionEmpleados.TabIndex = 0;
            this.lblGestionEmpleados.Text = "Gestión de EMPLEADOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(718, 452);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 34);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 55);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(554, 223);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(25, 316);
            this.dgvFichajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.RowTemplate.Height = 24;
            this.dgvFichajes.Size = new System.Drawing.Size(554, 220);
            this.dgvFichajes.TabIndex = 14;
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.Location = new System.Drawing.Point(22, 38);
            this.lblInfoEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(195, 15);
            this.lblInfoEmpleados.TabIndex = 15;
            this.lblInfoEmpleados.Text = "Información de EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.Location = new System.Drawing.Point(22, 299);
            this.lblInfoFichajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(175, 15);
            this.lblInfoFichajes.TabIndex = 16;
            this.lblInfoFichajes.Text = "Información de FICHAJES:";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 564);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gpbGestionEmpleados);
            this.Name = "FrmMantenimiento";
            this.Text = "Funcionalidades de Mantenimiento (Perfil Administrador)";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.gpbGestionEmpleados.ResumeLayout(false);
            this.gpbGestionEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.Label lblInfoEmpleados;
        private System.Windows.Forms.Label lblInfoFichajes;
    }
}