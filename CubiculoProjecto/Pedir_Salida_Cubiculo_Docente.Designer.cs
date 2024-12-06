namespace CubiculoProyectoNuevo
{
    partial class Pedir_Salida_Cubiculo_Docente
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
            this.lblNumeroCubiculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarSalidaDocente = new System.Windows.Forms.Button();
            this.txtNoTarjetaSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumeroCubiculo
            // 
            this.lblNumeroCubiculo.AutoSize = true;
            this.lblNumeroCubiculo.Location = new System.Drawing.Point(171, 64);
            this.lblNumeroCubiculo.Name = "lblNumeroCubiculo";
            this.lblNumeroCubiculo.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroCubiculo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cubiculo";
            // 
            // btnRegistrarSalidaDocente
            // 
            this.btnRegistrarSalidaDocente.Location = new System.Drawing.Point(169, 317);
            this.btnRegistrarSalidaDocente.Name = "btnRegistrarSalidaDocente";
            this.btnRegistrarSalidaDocente.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSalidaDocente.TabIndex = 5;
            this.btnRegistrarSalidaDocente.Text = "Registrar";
            this.btnRegistrarSalidaDocente.UseVisualStyleBackColor = true;
            // 
            // txtNoTarjetaSalida
            // 
            this.txtNoTarjetaSalida.Location = new System.Drawing.Point(159, 139);
            this.txtNoTarjetaSalida.Name = "txtNoTarjetaSalida";
            this.txtNoTarjetaSalida.Size = new System.Drawing.Size(100, 20);
            this.txtNoTarjetaSalida.TabIndex = 4;
            // 
            // Pedir_Salida_Cubiculo_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.lblNumeroCubiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarSalidaDocente);
            this.Controls.Add(this.txtNoTarjetaSalida);
            this.Name = "Pedir_Salida_Cubiculo_Docente";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCubiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarSalidaDocente;
        private System.Windows.Forms.TextBox txtNoTarjetaSalida;
    }
}