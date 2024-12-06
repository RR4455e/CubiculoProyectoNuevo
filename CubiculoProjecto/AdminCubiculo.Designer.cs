namespace CubiculoProyectoNuevo
{
    partial class AdminCubiculo
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
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.btnExportarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Dia",
            "Semana",
            "Mes"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(103, 136);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReporte.TabIndex = 0;
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(103, 183);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReporte.TabIndex = 1;
            // 
            // btnExportarReporte
            // 
            this.btnExportarReporte.Location = new System.Drawing.Point(103, 227);
            this.btnExportarReporte.Name = "btnExportarReporte";
            this.btnExportarReporte.Size = new System.Drawing.Size(121, 23);
            this.btnExportarReporte.TabIndex = 2;
            this.btnExportarReporte.Text = "Genera Reporte";
            this.btnExportarReporte.UseVisualStyleBackColor = true;
            this.btnExportarReporte.Click += new System.EventHandler(this.btnExportarReporte_Click);
            // 
            // AdminCubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportarReporte);
            this.Controls.Add(this.dtpFechaReporte);
            this.Controls.Add(this.cmbTipoReporte);
            this.Name = "AdminCubiculo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaReporte;
        private System.Windows.Forms.Button btnExportarReporte;
    }
}