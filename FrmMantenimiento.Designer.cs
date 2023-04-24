
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
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbGestionEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
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
            this.gpbGestionEmpleados.Location = new System.Drawing.Point(823, 68);
            this.gpbGestionEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGestionEmpleados.Name = "gpbGestionEmpleados";
            this.gpbGestionEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGestionEmpleados.Size = new System.Drawing.Size(415, 420);
            this.gpbGestionEmpleados.TabIndex = 0;
            this.gpbGestionEmpleados.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(235, 336);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 42);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(44, 336);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 42);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Enabled = false;
            this.txtContrasenya.Location = new System.Drawing.Point(119, 270);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.PasswordChar = '*';
            this.txtContrasenya.Size = new System.Drawing.Size(231, 22);
            this.txtContrasenya.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.Location = new System.Drawing.Point(119, 222);
            this.chkAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(133, 22);
            this.chkAdministrador.TabIndex = 7;
            this.chkAdministrador.Text = "Administrador/a";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            this.chkAdministrador.CheckedChanged += new System.EventHandler(this.chkAdministrador_CheckedChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(119, 171);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(231, 22);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 128);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(119, 86);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(139, 22);
            this.txtNIF.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(33, 171);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(71, 18);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 130);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(72, 92);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(35, 18);
            this.lblNIF.TabIndex = 1;
            this.lblNIF.Text = "NIF:";
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.Location = new System.Drawing.Point(109, 37);
            this.lblGestionEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(220, 20);
            this.lblGestionEmpleados.TabIndex = 0;
            this.lblGestionEmpleados.Text = "Gestión de EMPLEADOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(957, 556);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(137, 42);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(33, 68);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(739, 274);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(33, 389);
            this.dgvFichajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.RowTemplate.Height = 24;
            this.dgvFichajes.Size = new System.Drawing.Size(739, 271);
            this.dgvFichajes.TabIndex = 14;
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.Location = new System.Drawing.Point(29, 47);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(232, 18);
            this.lblInfoEmpleados.TabIndex = 15;
            this.lblInfoEmpleados.Text = "Información de EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.Location = new System.Drawing.Point(29, 368);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(209, 18);
            this.lblInfoFichajes.TabIndex = 16;
            this.lblInfoFichajes.Text = "Información de FICHAJES:";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 694);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gpbGestionEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMantenimiento";
            this.Text = "Funcionalidades de Mantenimiento (Perfil Administrador)";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.gpbGestionEmpleados.ResumeLayout(false);
            this.gpbGestionEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}