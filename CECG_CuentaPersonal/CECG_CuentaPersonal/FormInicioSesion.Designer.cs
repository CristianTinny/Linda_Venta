
namespace WindowsFormsApplication4
{
    partial class FormInicioSesion
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
            this.labelNumeroCuenta = new System.Windows.Forms.Label();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumeroCuenta
            // 
            this.labelNumeroCuenta.AutoSize = true;
            this.labelNumeroCuenta.Location = new System.Drawing.Point(27, 28);
            this.labelNumeroCuenta.Name = "labelNumeroCuenta";
            this.labelNumeroCuenta.Size = new System.Drawing.Size(99, 13);
            this.labelNumeroCuenta.TabIndex = 0;
            this.labelNumeroCuenta.Text = "Numero de Cuenta:";
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(30, 63);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(37, 13);
            this.labelClave.TabIndex = 1;
            this.labelClave.Text = "Clave:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(132, 21);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 2;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(73, 56);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(159, 20);
            this.textBoxClave.TabIndex = 3;
            this.textBoxClave.UseSystemPasswordChar = true;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(100, 87);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 4;
            this.buttonValidar.Text = "Validar Acceso";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 122);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelNumeroCuenta);
            this.Name = "FormInicioSesion";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroCuenta;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Button buttonValidar;
    }
}