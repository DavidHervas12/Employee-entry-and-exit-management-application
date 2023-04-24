
namespace AEV7_David_Alberto
{
    partial class FrmPrincipal
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
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.timReloj = new System.Windows.Forms.Timer(this.components);
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.pnlSeccion = new System.Windows.Forms.Panel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlSeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(789, 177);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(219, 54);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(789, 258);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(219, 54);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnPresencia
            // 
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(789, 336);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(219, 54);
            this.btnPresencia.TabIndex = 2;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = true;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(789, 416);
            this.btnPermanencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(219, 54);
            this.btnPermanencia.TabIndex = 3;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = true;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(780, 496);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(245, 54);
            this.btnMantenimiento.TabIndex = 4;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // timReloj
            // 
            this.timReloj.Tick += new System.EventHandler(this.timReloj_Tick);
            // 
            // mtbDni
            // 
            this.mtbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDni.Location = new System.Drawing.Point(89, 53);
            this.mtbDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbDni.Mask = "00000000-L";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(500, 98);
            this.mtbDni.TabIndex = 8;
            this.mtbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDni.TextChanged += new System.EventHandler(this.mtbdni_TextChanged);
            // 
            // pnlSeccion
            // 
            this.pnlSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSeccion.Controls.Add(this.lblReloj);
            this.pnlSeccion.Controls.Add(this.lblFecha);
            this.pnlSeccion.Location = new System.Drawing.Point(747, 25);
            this.pnlSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSeccion.Name = "pnlSeccion";
            this.pnlSeccion.Size = new System.Drawing.Size(279, 127);
            this.pnlSeccion.TabIndex = 9;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblReloj.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(84, 70);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(93, 38);
            this.lblReloj.TabIndex = 10;
            this.lblReloj.Text = "Reloj";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(101, 14);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 32);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 601);
            this.Controls.Add(this.pnlSeccion);
            this.Controls.Add(this.mtbDni);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlSeccion.ResumeLayout(false);
            this.pnlSeccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Timer timReloj;
        private System.Windows.Forms.MaskedTextBox mtbDni;
        private System.Windows.Forms.Panel pnlSeccion;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
    }
}

