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
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.btnExportarReporte = new System.Windows.Forms.Button();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.tabAdminTablas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReExternos = new System.Windows.Forms.Button();
            this.btnRePersonal = new System.Windows.Forms.Button();
            this.btnReAlumnos = new System.Windows.Forms.Button();
            this.tabAgregaUser = new System.Windows.Forms.TabPage();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuarioACambiar = new System.Windows.Forms.TextBox();
            this.txtContraExistente = new System.Windows.Forms.TextBox();
            this.txtContraCambiada = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabAdminTablas.SuspendLayout();
            this.tabAgregaUser.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(363, 426);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
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
            this.tabReportes.Size = new System.Drawing.Size(355, 400);
            this.tabReportes.TabIndex = 0;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(55, 103);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(121, 21);
            this.cmbTabla.TabIndex = 9;
            // 
            // btnExportarReporte
            // 
            this.btnExportarReporte.Location = new System.Drawing.Point(55, 166);
            this.btnExportarReporte.Name = "btnExportarReporte";
            this.btnExportarReporte.Size = new System.Drawing.Size(121, 23);
            this.btnExportarReporte.TabIndex = 8;
            this.btnExportarReporte.Text = "Genera Reporte";
            this.btnExportarReporte.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(55, 130);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReporte.TabIndex = 7;
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(55, 75);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReporte.TabIndex = 6;
            // 
            // tabAdminTablas
            // 
            this.tabAdminTablas.Controls.Add(this.label1);
            this.tabAdminTablas.Controls.Add(this.btnReExternos);
            this.tabAdminTablas.Controls.Add(this.btnRePersonal);
            this.tabAdminTablas.Controls.Add(this.btnReAlumnos);
            this.tabAdminTablas.Location = new System.Drawing.Point(4, 22);
            this.tabAdminTablas.Name = "tabAdminTablas";
            this.tabAdminTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminTablas.Size = new System.Drawing.Size(355, 400);
            this.tabAdminTablas.TabIndex = 1;
            this.tabAdminTablas.Text = "Administracion de tablas";
            this.tabAdminTablas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATTENCIÓN: REINICIAR UNA TABLA BORRARA TODA LA \r\nINFORMACÍON QUE CONTIENE, SOLO R" +
    "EINICIE TABLAS SI \r\nESTA COMPLETAMENTE SEGURO DE QUE LO QUIERE HACER!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnReExternos
            // 
            this.btnReExternos.Location = new System.Drawing.Point(56, 286);
            this.btnReExternos.Name = "btnReExternos";
            this.btnReExternos.Size = new System.Drawing.Size(250, 95);
            this.btnReExternos.TabIndex = 2;
            this.btnReExternos.Text = "Reiniciar Externos";
            this.btnReExternos.UseVisualStyleBackColor = true;
            this.btnReExternos.Click += new System.EventHandler(this.btnReExternos_Click);
            // 
            // btnRePersonal
            // 
            this.btnRePersonal.Location = new System.Drawing.Point(56, 185);
            this.btnRePersonal.Name = "btnRePersonal";
            this.btnRePersonal.Size = new System.Drawing.Size(250, 95);
            this.btnRePersonal.TabIndex = 1;
            this.btnRePersonal.Text = "Reiniciar Personal";
            this.btnRePersonal.UseVisualStyleBackColor = true;
            this.btnRePersonal.Click += new System.EventHandler(this.btnRePersonal_Click);
            // 
            // btnReAlumnos
            // 
            this.btnReAlumnos.Location = new System.Drawing.Point(56, 84);
            this.btnReAlumnos.Name = "btnReAlumnos";
            this.btnReAlumnos.Size = new System.Drawing.Size(250, 95);
            this.btnReAlumnos.TabIndex = 0;
            this.btnReAlumnos.Text = "Reiniciar Alumnos";
            this.btnReAlumnos.UseVisualStyleBackColor = true;
            this.btnReAlumnos.Click += new System.EventHandler(this.btnReAlumnos_Click);
            // 
            // tabAgregaUser
            // 
            this.tabAgregaUser.Controls.Add(this.btnCambiarContraseña);
            this.tabAgregaUser.Controls.Add(this.btnAgregarUsuario);
            this.tabAgregaUser.Controls.Add(this.txtContraCambiada);
            this.tabAgregaUser.Controls.Add(this.txtContraExistente);
            this.tabAgregaUser.Controls.Add(this.txtUsuarioACambiar);
            this.tabAgregaUser.Controls.Add(this.txtContraseñaNuevoUsuario);
            this.tabAgregaUser.Controls.Add(this.txtNuevoUsuario);
            this.tabAgregaUser.Location = new System.Drawing.Point(4, 22);
            this.tabAgregaUser.Name = "tabAgregaUser";
            this.tabAgregaUser.Size = new System.Drawing.Size(355, 400);
            this.tabAgregaUser.TabIndex = 2;
            this.tabAgregaUser.Text = "Usuarios";
            this.tabAgregaUser.UseVisualStyleBackColor = true;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(100, 75);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtNuevoUsuario.TabIndex = 0;
            // 
            // txtContraseñaNuevoUsuario
            // 
            this.txtContraseñaNuevoUsuario.Location = new System.Drawing.Point(100, 101);
            this.txtContraseñaNuevoUsuario.Name = "txtContraseñaNuevoUsuario";
            this.txtContraseñaNuevoUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtContraseñaNuevoUsuario.TabIndex = 1;
            // 
            // txtUsuarioACambiar
            // 
            this.txtUsuarioACambiar.Location = new System.Drawing.Point(103, 190);
            this.txtUsuarioACambiar.Name = "txtUsuarioACambiar";
            this.txtUsuarioACambiar.Size = new System.Drawing.Size(148, 20);
            this.txtUsuarioACambiar.TabIndex = 2;
            // 
            // txtContraExistente
            // 
            this.txtContraExistente.Location = new System.Drawing.Point(103, 216);
            this.txtContraExistente.Name = "txtContraExistente";
            this.txtContraExistente.Size = new System.Drawing.Size(148, 20);
            this.txtContraExistente.TabIndex = 3;
            // 
            // txtContraCambiada
            // 
            this.txtContraCambiada.Location = new System.Drawing.Point(103, 242);
            this.txtContraCambiada.Name = "txtContraCambiada";
            this.txtContraCambiada.Size = new System.Drawing.Size(148, 20);
            this.txtContraCambiada.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(139, 127);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(139, 268);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarContraseña.TabIndex = 6;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // AdminCubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AdminCubiculo";
            this.tabControl1.ResumeLayout(false);
            this.tabReportes.ResumeLayout(false);
            this.tabAdminTablas.ResumeLayout(false);
            this.tabAdminTablas.PerformLayout();
            this.tabAgregaUser.ResumeLayout(false);
            this.tabAgregaUser.PerformLayout();
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
        private System.Windows.Forms.Button btnReExternos;
        private System.Windows.Forms.Button btnRePersonal;
        private System.Windows.Forms.Button btnReAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtContraCambiada;
        private System.Windows.Forms.TextBox txtContraExistente;
        private System.Windows.Forms.TextBox txtUsuarioACambiar;
        private System.Windows.Forms.TextBox txtContraseñaNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
    }
}