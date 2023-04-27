
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.timReloj = new System.Windows.Forms.Timer(this.components);
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.pnlEntrada = new System.Windows.Forms.Panel();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.Honeydew;
            this.btnEntrada.Location = new System.Drawing.Point(592, 144);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(164, 44);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalida.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSalida.Location = new System.Drawing.Point(592, 210);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(164, 44);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPresencia.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.ForeColor = System.Drawing.Color.Honeydew;
            this.btnPresencia.Location = new System.Drawing.Point(592, 273);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(164, 44);
            this.btnPresencia.TabIndex = 2;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPermanencia.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.ForeColor = System.Drawing.Color.Honeydew;
            this.btnPermanencia.Location = new System.Drawing.Point(592, 338);
            this.btnPermanencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(164, 44);
            this.btnPermanencia.TabIndex = 3;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.Honeydew;
            this.btnMantenimiento.Location = new System.Drawing.Point(580, 400);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(191, 44);
            this.btnMantenimiento.TabIndex = 4;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // timReloj
            // 
            this.timReloj.Tick += new System.EventHandler(this.timReloj_Tick);
            // 
            // mtbDni
            // 
            this.mtbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDni.Location = new System.Drawing.Point(106, 40);
            this.mtbDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbDni.Mask = "00000000-L";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(357, 80);
            this.mtbDni.TabIndex = 8;
            this.mtbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDni.TextChanged += new System.EventHandler(this.mtbdni_TextChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(51, 144);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(454, 289);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Honeydew;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblFecha.Location = new System.Drawing.Point(632, 28);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(77, 26);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.Color.Honeydew;
            this.lblReloj.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblReloj.Location = new System.Drawing.Point(632, 62);
            this.lblReloj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(78, 29);
            this.lblReloj.TabIndex = 10;
            this.lblReloj.Text = "Reloj";
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.Controls.Add(this.rtxtInfo);
            this.pnlEntrada.Controls.Add(this.btnVolver);
            this.pnlEntrada.Location = new System.Drawing.Point(51, 144);
            this.pnlEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(454, 289);
            this.pnlEntrada.TabIndex = 12;
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Location = new System.Drawing.Point(68, 28);
            this.rtxtInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(334, 173);
            this.rtxtInfo.TabIndex = 2;
            this.rtxtInfo.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Honeydew;
            this.btnVolver.Location = new System.Drawing.Point(165, 228);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.pnlEntrada);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mtbDni);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlEntrada.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Panel pnlEntrada;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Button btnVolver;
    }
}

