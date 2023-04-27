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
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNIF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(364, 87);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(100, 22);
            this.txtFechaInicio.TabIndex = 0;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Location = new System.Drawing.Point(580, 87);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtFechaFinal.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcFecha,
            this.dgvHoraEntrada,
            this.dgvcHoraSalida,
            this.dgvcDuracion});
            this.dataGridView1.Location = new System.Drawing.Point(125, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 2;
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
            this.dgvcDuracion.Width = 125;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(122, 93);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(44, 16);
            this.lblNIF.TabIndex = 3;
            this.lblNIF.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(822, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.txtFechaInicio);
            this.Name = "FrmPermanencia";
            this.Text = "FrmPermanencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDuracion;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label label2;
    }
}