namespace AEV7_David_Alberto
{
    partial class FrmPermanencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermanencia));
            this.dgvInformacionFichajes = new System.Windows.Forms.DataGridView();
            this.dgvcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHoraSaiida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.errorProvFichajes = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformacionFichajes
            // 
            this.dgvInformacionFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacionFichajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcFecha,
            this.dgvHoraEntrada,
            this.dgvcHoraSalida,
            this.dgvcDuracion});
            this.dgvInformacionFichajes.Location = new System.Drawing.Point(57, 189);
            this.dgvInformacionFichajes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformacionFichajes.Name = "dgvInformacionFichajes";
            this.dgvInformacionFichajes.RowHeadersWidth = 51;
            this.dgvInformacionFichajes.RowTemplate.Height = 24;
            this.dgvInformacionFichajes.Size = new System.Drawing.Size(491, 134);
            this.dgvInformacionFichajes.TabIndex = 2;
            // 
            // dgvcFecha
            // 
            this.dgvcFecha.HeaderText = "Fecha";
            this.dgvcFecha.MinimumWidth = 6;
            this.dgvcFecha.Name = "dgvcFecha";
            this.dgvcFecha.Width = 125;
            // 
            // dgvHoraEntrada
            // 
            this.dgvHoraEntrada.HeaderText = "Hora_Entrada";
            this.dgvHoraEntrada.MinimumWidth = 6;
            this.dgvHoraEntrada.Name = "dgvHoraEntrada";
            this.dgvHoraEntrada.Width = 125;
            // 
            // dgvcHoraSalida
            // 
            this.dgvcHoraSalida.HeaderText = "Hora_Salida";
            this.dgvcHoraSalida.MinimumWidth = 6;
            this.dgvcHoraSalida.Name = "dgvcHoraSalida";
            this.dgvcHoraSalida.Width = 125;
            // 
            // dgvcDuracion
            // 
            this.dgvcDuracion.HeaderText = "Duracion";
            this.dgvcDuracion.MinimumWidth = 6;
            this.dgvcDuracion.Name = "dgvcDuracion";
            this.dgvcDuracion.Width = 75;
            // 
            // lblHoraSaiida
            // 
            this.lblHoraSaiida.AutoSize = true;
            this.lblHoraSaiida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaiida.Location = new System.Drawing.Point(86, 79);
            this.lblHoraSaiida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraSaiida.Name = "lblHoraSaiida";
            this.lblHoraSaiida.Size = new System.Drawing.Size(133, 18);
            this.lblHoraSaiida.TabIndex = 4;
            this.lblHoraSaiida.Text = "FECHA INICIAL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "FECHA FINAL: ";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(224, 77);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(95, 24);
            this.dtpFechaInicial.TabIndex = 7;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(224, 118);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(95, 24);
            this.dtpFechaFinal.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnFiltrar.Location = new System.Drawing.Point(249, 346);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(110, 33);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(100, 35);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(39, 18);
            this.lblNIF.TabIndex = 10;
            this.lblNIF.Text = "NIF:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(146, 35);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(175, 20);
            this.txtNIF.TabIndex = 11;
            // 
            // errorProvFichajes
            // 
            this.errorProvFichajes.ContainerControl = this;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(385, 41);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(440, 38);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 26);
            this.txtTotal.TabIndex = 13;
            // 
            // pbSalir
            // 
            this.pbSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(575, 9);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(2);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(30, 30);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 18;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(616, 391);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoraSaiida);
            this.Controls.Add(this.dgvInformacionFichajes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPermanencia";
            this.Text = "FrmPermanencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInformacionFichajes;
        private System.Windows.Forms.Label lblHoraSaiida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.ErrorProvider errorProvFichajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDuracion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pbSalir;
    }
}