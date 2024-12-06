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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.tabAdminTablas = new System.Windows.Forms.TabPage();
            this.btnExportarReporte = new System.Windows.Forms.Button();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.tabAgregaUser = new System.Windows.Forms.TabPage();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReportes);
            this.tabControl1.Controls.Add(this.tabAdminTablas);
            this.tabControl1.Controls.Add(this.tabAgregaUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.cmbTabla);
            this.tabReportes.Controls.Add(this.btnExportarReporte);
            this.tabReportes.Controls.Add(this.dtpFechaReporte);
            this.tabReportes.Controls.Add(this.cmbTipoReporte);
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(366, 400);
            this.tabReportes.TabIndex = 0;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // tabAdminTablas
            // 
            this.tabAdminTablas.Location = new System.Drawing.Point(4, 22);
            this.tabAdminTablas.Name = "tabAdminTablas";
            this.tabAdminTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminTablas.Size = new System.Drawing.Size(366, 400);
            this.tabAdminTablas.TabIndex = 1;
            this.tabAdminTablas.Text = "Administracion de tablas";
            this.tabAdminTablas.UseVisualStyleBackColor = true;
            // 
            // btnExportarReporte
            // 
            this.btnExportarReporte.Location = new System.Drawing.Point(87, 163);
            this.btnExportarReporte.Name = "btnExportarReporte";
            this.btnExportarReporte.Size = new System.Drawing.Size(121, 23);
            this.btnExportarReporte.TabIndex = 8;
            this.btnExportarReporte.Text = "Genera Reporte";
            this.btnExportarReporte.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(87, 127);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReporte.TabIndex = 7;
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Día",
            "Semana",
            "Mes"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(87, 72);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReporte.TabIndex = 6;
            // 
            // tabAgregaUser
            // 
            this.tabAgregaUser.Location = new System.Drawing.Point(4, 22);
            this.tabAgregaUser.Name = "tabAgregaUser";
            this.tabAgregaUser.Size = new System.Drawing.Size(366, 400);
            this.tabAgregaUser.TabIndex = 2;
            this.tabAgregaUser.Text = "Usuarios";
            this.tabAgregaUser.UseVisualStyleBackColor = true;
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Alumnos",
            "Personal",
            "Externos",
            "Todas"});
            this.cmbTabla.Location = new System.Drawing.Point(87, 100);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(121, 21);
            this.cmbTabla.TabIndex = 9;
            // 
            // AdminCubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminCubiculo";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.Button btnExportarReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaReporte;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.TabPage tabAdminTablas;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.TabPage tabAgregaUser;
    }
}