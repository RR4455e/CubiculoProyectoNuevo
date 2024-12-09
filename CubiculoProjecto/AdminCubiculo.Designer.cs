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
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtContraCambiada = new System.Windows.Forms.TextBox();
            this.txtContraExistente = new System.Windows.Forms.TextBox();
            this.txtUsuarioACambiar = new System.Windows.Forms.TextBox();
            this.txtContraseñaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 426);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.label4);
            this.tabReportes.Controls.Add(this.label3);
            this.tabReportes.Controls.Add(this.label2);
            this.tabReportes.Controls.Add(this.cmbTabla);
            this.tabReportes.Controls.Add(this.btnExportarReporte);
            this.tabReportes.Controls.Add(this.dtpFechaReporte);
            this.tabReportes.Controls.Add(this.cmbTipoReporte);
            this.tabReportes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbTabla.Location = new System.Drawing.Point(116, 75);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(121, 21);
            this.cmbTabla.TabIndex = 9;
            // 
            // btnExportarReporte
            // 
            this.btnExportarReporte.Location = new System.Drawing.Point(94, 145);
            this.btnExportarReporte.Name = "btnExportarReporte";
            this.btnExportarReporte.Size = new System.Drawing.Size(161, 59);
            this.btnExportarReporte.TabIndex = 8;
            this.btnExportarReporte.Text = "Genera Reporte";
            this.btnExportarReporte.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(116, 103);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(217, 22);
            this.dtpFechaReporte.TabIndex = 7;
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(116, 48);
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
            this.tabAdminTablas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnReExternos.BackColor = System.Drawing.Color.Red;
            this.btnReExternos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReExternos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReExternos.Location = new System.Drawing.Point(56, 286);
            this.btnReExternos.Name = "btnReExternos";
            this.btnReExternos.Size = new System.Drawing.Size(250, 95);
            this.btnReExternos.TabIndex = 2;
            this.btnReExternos.Text = "Reiniciar Externos";
            this.btnReExternos.UseVisualStyleBackColor = false;
            this.btnReExternos.Click += new System.EventHandler(this.btnReExternos_Click);
            // 
            // btnRePersonal
            // 
            this.btnRePersonal.BackColor = System.Drawing.Color.Red;
            this.btnRePersonal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRePersonal.Location = new System.Drawing.Point(56, 185);
            this.btnRePersonal.Name = "btnRePersonal";
            this.btnRePersonal.Size = new System.Drawing.Size(250, 95);
            this.btnRePersonal.TabIndex = 1;
            this.btnRePersonal.Text = "Reiniciar Personal";
            this.btnRePersonal.UseVisualStyleBackColor = false;
            this.btnRePersonal.Click += new System.EventHandler(this.btnRePersonal_Click);
            // 
            // btnReAlumnos
            // 
            this.btnReAlumnos.BackColor = System.Drawing.Color.Red;
            this.btnReAlumnos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReAlumnos.Location = new System.Drawing.Point(56, 84);
            this.btnReAlumnos.Name = "btnReAlumnos";
            this.btnReAlumnos.Size = new System.Drawing.Size(250, 95);
            this.btnReAlumnos.TabIndex = 0;
            this.btnReAlumnos.Text = "Reiniciar Alumnos";
            this.btnReAlumnos.UseVisualStyleBackColor = false;
            this.btnReAlumnos.Click += new System.EventHandler(this.btnReAlumnos_Click);
            // 
            // tabAgregaUser
            // 
            this.tabAgregaUser.Controls.Add(this.label9);
            this.tabAgregaUser.Controls.Add(this.label8);
            this.tabAgregaUser.Controls.Add(this.label7);
            this.tabAgregaUser.Controls.Add(this.label6);
            this.tabAgregaUser.Controls.Add(this.label5);
            this.tabAgregaUser.Controls.Add(this.btnCambiarContraseña);
            this.tabAgregaUser.Controls.Add(this.btnAgregarUsuario);
            this.tabAgregaUser.Controls.Add(this.txtContraCambiada);
            this.tabAgregaUser.Controls.Add(this.txtContraExistente);
            this.tabAgregaUser.Controls.Add(this.txtUsuarioACambiar);
            this.tabAgregaUser.Controls.Add(this.txtContraseñaNuevoUsuario);
            this.tabAgregaUser.Controls.Add(this.txtNuevoUsuario);
            this.tabAgregaUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAgregaUser.Location = new System.Drawing.Point(4, 22);
            this.tabAgregaUser.Name = "tabAgregaUser";
            this.tabAgregaUser.Size = new System.Drawing.Size(355, 400);
            this.tabAgregaUser.TabIndex = 2;
            this.tabAgregaUser.Text = "Usuarios";
            this.tabAgregaUser.UseVisualStyleBackColor = true;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.Location = new System.Drawing.Point(152, 298);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarContraseña.TabIndex = 6;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(152, 128);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtContraCambiada
            // 
            this.txtContraCambiada.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraCambiada.Location = new System.Drawing.Point(114, 272);
            this.txtContraCambiada.Name = "txtContraCambiada";
            this.txtContraCambiada.Size = new System.Drawing.Size(148, 22);
            this.txtContraCambiada.TabIndex = 4;
            // 
            // txtContraExistente
            // 
            this.txtContraExistente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraExistente.Location = new System.Drawing.Point(114, 246);
            this.txtContraExistente.Name = "txtContraExistente";
            this.txtContraExistente.Size = new System.Drawing.Size(148, 22);
            this.txtContraExistente.TabIndex = 3;
            // 
            // txtUsuarioACambiar
            // 
            this.txtUsuarioACambiar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioACambiar.Location = new System.Drawing.Point(114, 220);
            this.txtUsuarioACambiar.Name = "txtUsuarioACambiar";
            this.txtUsuarioACambiar.Size = new System.Drawing.Size(148, 22);
            this.txtUsuarioACambiar.TabIndex = 2;
            // 
            // txtContraseñaNuevoUsuario
            // 
            this.txtContraseñaNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNuevoUsuario.Location = new System.Drawing.Point(116, 102);
            this.txtContraseñaNuevoUsuario.Name = "txtContraseñaNuevoUsuario";
            this.txtContraseñaNuevoUsuario.Size = new System.Drawing.Size(148, 22);
            this.txtContraseñaNuevoUsuario.TabIndex = 1;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUsuario.Location = new System.Drawing.Point(116, 76);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(148, 22);
            this.txtNuevoUsuario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rango de reporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tabla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "AGREGAR USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "REINICIAR CONTRASEÑA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre de usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Contraseña actual:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nueva contraseña:";
            // 
            // AdminCubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AdminCubiculo";
            this.ShowIcon = false;
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}