namespace CubiculoProyectoNuevo
{
    partial class Pedir_Salida_Cubiculo_Alumno
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
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroCubiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumControl
            // 
            this.txtNumControl.Location = new System.Drawing.Point(150, 119);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(100, 20);
            this.txtNumControl.TabIndex = 0;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Location = new System.Drawing.Point(160, 297);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSalida.TabIndex = 1;
            this.btnRegistrarSalida.Text = "Registrar";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cubiculo";
            // 
            // lblNumeroCubiculo
            // 
            this.lblNumeroCubiculo.AutoSize = true;
            this.lblNumeroCubiculo.Location = new System.Drawing.Point(162, 44);
            this.lblNumeroCubiculo.Name = "lblNumeroCubiculo";
            this.lblNumeroCubiculo.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroCubiculo.TabIndex = 3;
            // 
            // Pedir_Salida_Cubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.lblNumeroCubiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.txtNumControl);
            this.Name = "Pedir_Salida_Cubiculo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroCubiculo;
    }
}