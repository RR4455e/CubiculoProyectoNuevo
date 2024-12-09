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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumControl
            // 
            this.txtNumControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumControl.Location = new System.Drawing.Point(151, 85);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(100, 22);
            this.txtNumControl.TabIndex = 0;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.Location = new System.Drawing.Point(111, 137);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(179, 61);
            this.btnRegistrarSalida.TabIndex = 1;
            this.btnRegistrarSalida.Text = "Registrar";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUBICULO";
            // 
            // lblNumeroCubiculo
            // 
            this.lblNumeroCubiculo.AutoSize = true;
            this.lblNumeroCubiculo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCubiculo.Location = new System.Drawing.Point(145, 18);
            this.lblNumeroCubiculo.Name = "lblNumeroCubiculo";
            this.lblNumeroCubiculo.Size = new System.Drawing.Size(0, 30);
            this.lblNumeroCubiculo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de control";
            // 
            // Pedir_Salida_Cubiculo_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroCubiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.txtNumControl);
            this.Name = "Pedir_Salida_Cubiculo_Alumno";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroCubiculo;
        private System.Windows.Forms.Label label2;
    }
}