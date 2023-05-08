
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlEntrada.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.LightCyan;
            this.btnEntrada.Location = new System.Drawing.Point(37, 34);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(291, 68);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalida.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSalida.Location = new System.Drawing.Point(37, 114);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(291, 68);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPresencia.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPresencia.Location = new System.Drawing.Point(37, 193);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(291, 68);
            this.btnPresencia.TabIndex = 2;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPermanencia.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPermanencia.Location = new System.Drawing.Point(37, 273);
            this.btnPermanencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(291, 68);
            this.btnPermanencia.TabIndex = 3;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.LightCyan;
            this.btnMantenimiento.Location = new System.Drawing.Point(37, 350);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(291, 68);
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
            this.mtbDni.BackColor = System.Drawing.Color.AliceBlue;
            this.mtbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mtbDni.Location = new System.Drawing.Point(108, 77);
            this.mtbDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbDni.Mask = "00000000-L";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(540, 98);
            this.mtbDni.TabIndex = 8;
            this.mtbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDni.TextChanged += new System.EventHandler(this.mtbdni_TextChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(56, 210);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(627, 370);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFecha.Location = new System.Drawing.Point(159, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 25);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReloj.Location = new System.Drawing.Point(9, 46);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(134, 54);
            this.lblReloj.TabIndex = 10;
            this.lblReloj.Text = "Reloj";
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.Controls.Add(this.txtInfo);
            this.pnlEntrada.Controls.Add(this.btnVolver);
            this.pnlEntrada.Location = new System.Drawing.Point(56, 210);
            this.pnlEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(643, 370);
            this.pnlEntrada.TabIndex = 12;
            this.pnlEntrada.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(20, 16);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(605, 278);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnVolver.Location = new System.Drawing.Point(237, 309);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(151, 49);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEntrada);
            this.panel1.Controls.Add(this.btnSalida);
            this.panel1.Controls.Add(this.btnPresencia);
            this.panel1.Controls.Add(this.btnPermanencia);
            this.panel1.Controls.Add(this.btnMantenimiento);
            this.panel1.Location = new System.Drawing.Point(792, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 453);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblReloj);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Location = new System.Drawing.Point(829, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 150);
            this.panel2.TabIndex = 14;
            // 
            // pbSalir
            // 
            this.pbSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(1184, 12);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(39, 36);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 15;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1240, 702);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEntrada);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.mtbDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlEntrada.ResumeLayout(false);
            this.pnlEntrada.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

