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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHoraSaiida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcFecha,
            this.dgvHoraEntrada,
            this.dgvcHoraSalida,
            this.dgvcDuracion});
            this.dataGridView1.Location = new System.Drawing.Point(116, 221);
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
            // lblHoraSaiida
            // 
            this.lblHoraSaiida.AutoSize = true;
            this.lblHoraSaiida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaiida.Location = new System.Drawing.Point(90, 69);
            this.lblHoraSaiida.Name = "lblHoraSaiida";
            this.lblHoraSaiida.Size = new System.Drawing.Size(167, 24);
            this.lblHoraSaiida.TabIndex = 4;
            this.lblHoraSaiida.Text = "FECHA INICIAL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "FECHA FINAL: ";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(276, 66);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(125, 28);
            this.dtpFechaInicial.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 28);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(822, 468);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoraSaiida);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPermanencia";
            this.Text = "FrmPermanencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDuracion;
        private System.Windows.Forms.Label lblHoraSaiida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}