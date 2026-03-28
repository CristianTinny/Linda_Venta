
namespace WindowsFormsApplication4
{
    partial class FormCuentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.textBoxSaldoInicial = new System.Windows.Forms.TextBox();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.labelInfoCuenta = new System.Windows.Forms.Label();
            this.buttonAbonar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.buttonConsultarHistorial = new System.Windows.Forms.Button();
            this.textBoxHistorial = new System.Windows.Forms.TextBox();
            this.labelBuscarNumero = new System.Windows.Forms.Label();
            this.textBoxBuscarNumero = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxGestionarCuentas = new System.Windows.Forms.GroupBox();
            this.groupBoxMovientos = new System.Windows.Forms.GroupBox();
            this.groupBoxGestionarCuentas.SuspendLayout();
            this.groupBoxMovientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(9, 37);
            this.labelTitular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(147, 20);
            this.labelTitular.TabIndex = 0;
            this.labelTitular.Text = "Titular de la cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo inicial:";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTitular.Location = new System.Drawing.Point(171, 25);
            this.textBoxTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(252, 26);
            this.textBoxTitular.TabIndex = 0;
            this.textBoxTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitular_KeyPress);
            // 
            // textBoxSaldoInicial
            // 
            this.textBoxSaldoInicial.Location = new System.Drawing.Point(117, 85);
            this.textBoxSaldoInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSaldoInicial.Name = "textBoxSaldoInicial";
            this.textBoxSaldoInicial.Size = new System.Drawing.Size(151, 26);
            this.textBoxSaldoInicial.TabIndex = 1;
            // 
            // buttonCrearCuenta
            // 
            this.buttonCrearCuenta.Location = new System.Drawing.Point(50, 138);
            this.buttonCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrearCuenta.Name = "buttonCrearCuenta";
            this.buttonCrearCuenta.Size = new System.Drawing.Size(162, 42);
            this.buttonCrearCuenta.TabIndex = 2;
            this.buttonCrearCuenta.Text = "Crear cuenta";
            this.buttonCrearCuenta.UseVisualStyleBackColor = true;
            this.buttonCrearCuenta.Click += new System.EventHandler(this.buttonCrearCuenta_Click);
            // 
            // labelInfoCuenta
            // 
            this.labelInfoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfoCuenta.Location = new System.Drawing.Point(434, 25);
            this.labelInfoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoCuenta.Name = "labelInfoCuenta";
            this.labelInfoCuenta.Size = new System.Drawing.Size(264, 91);
            this.labelInfoCuenta.TabIndex = 3;
            // 
            // buttonAbonar
            // 
            this.buttonAbonar.Location = new System.Drawing.Point(224, 28);
            this.buttonAbonar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbonar.Name = "buttonAbonar";
            this.buttonAbonar.Size = new System.Drawing.Size(94, 35);
            this.buttonAbonar.TabIndex = 4;
            this.buttonAbonar.Text = "Abonar";
            this.buttonAbonar.UseVisualStyleBackColor = true;
            this.buttonAbonar.Click += new System.EventHandler(this.buttonAbonar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(98, 31);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(115, 26);
            this.textBoxCantidad.TabIndex = 3;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(10, 35);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(77, 20);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(327, 26);
            this.buttonRetirar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(112, 35);
            this.buttonRetirar.TabIndex = 7;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // buttonConsultarHistorial
            // 
            this.buttonConsultarHistorial.Location = new System.Drawing.Point(448, 26);
            this.buttonConsultarHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConsultarHistorial.Name = "buttonConsultarHistorial";
            this.buttonConsultarHistorial.Size = new System.Drawing.Size(165, 35);
            this.buttonConsultarHistorial.TabIndex = 9;
            this.buttonConsultarHistorial.Text = "Consultar Historial";
            this.buttonConsultarHistorial.UseVisualStyleBackColor = true;
            this.buttonConsultarHistorial.Click += new System.EventHandler(this.buttonConsultarHistorial_Click);
            // 
            // textBoxHistorial
            // 
            this.textBoxHistorial.Location = new System.Drawing.Point(15, 77);
            this.textBoxHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHistorial.Multiline = true;
            this.textBoxHistorial.Name = "textBoxHistorial";
            this.textBoxHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistorial.Size = new System.Drawing.Size(678, 233);
            this.textBoxHistorial.TabIndex = 10;
            // 
            // labelBuscarNumero
            // 
            this.labelBuscarNumero.AutoSize = true;
            this.labelBuscarNumero.Location = new System.Drawing.Point(279, 149);
            this.labelBuscarNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscarNumero.Name = "labelBuscarNumero";
            this.labelBuscarNumero.Size = new System.Drawing.Size(147, 20);
            this.labelBuscarNumero.TabIndex = 11;
            this.labelBuscarNumero.Text = "Número de Cuenta:";
            // 
            // textBoxBuscarNumero
            // 
            this.textBoxBuscarNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBuscarNumero.Location = new System.Drawing.Point(434, 138);
            this.textBoxBuscarNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBuscarNumero.Name = "textBoxBuscarNumero";
            this.textBoxBuscarNumero.Size = new System.Drawing.Size(154, 26);
            this.textBoxBuscarNumero.TabIndex = 12;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(600, 138);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(93, 35);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxGestionarCuentas
            // 
            this.groupBoxGestionarCuentas.Controls.Add(this.labelTitular);
            this.groupBoxGestionarCuentas.Controls.Add(this.buttonBuscar);
            this.groupBoxGestionarCuentas.Controls.Add(this.label1);
            this.groupBoxGestionarCuentas.Controls.Add(this.textBoxBuscarNumero);
            this.groupBoxGestionarCuentas.Controls.Add(this.textBoxTitular);
            this.groupBoxGestionarCuentas.Controls.Add(this.labelBuscarNumero);
            this.groupBoxGestionarCuentas.Controls.Add(this.textBoxSaldoInicial);
            this.groupBoxGestionarCuentas.Controls.Add(this.buttonCrearCuenta);
            this.groupBoxGestionarCuentas.Controls.Add(this.labelInfoCuenta);
            this.groupBoxGestionarCuentas.Location = new System.Drawing.Point(18, 18);
            this.groupBoxGestionarCuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGestionarCuentas.Name = "groupBoxGestionarCuentas";
            this.groupBoxGestionarCuentas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGestionarCuentas.Size = new System.Drawing.Size(704, 188);
            this.groupBoxGestionarCuentas.TabIndex = 14;
            this.groupBoxGestionarCuentas.TabStop = false;
            this.groupBoxGestionarCuentas.Text = "Gestionar Cuentas";
            // 
            // groupBoxMovientos
            // 
            this.groupBoxMovientos.Controls.Add(this.buttonConsultarHistorial);
            this.groupBoxMovientos.Controls.Add(this.buttonAbonar);
            this.groupBoxMovientos.Controls.Add(this.textBoxHistorial);
            this.groupBoxMovientos.Controls.Add(this.textBoxCantidad);
            this.groupBoxMovientos.Controls.Add(this.labelCantidad);
            this.groupBoxMovientos.Controls.Add(this.buttonRetirar);
            this.groupBoxMovientos.Location = new System.Drawing.Point(18, 217);
            this.groupBoxMovientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMovientos.Name = "groupBoxMovientos";
            this.groupBoxMovientos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMovientos.Size = new System.Drawing.Size(704, 329);
            this.groupBoxMovientos.TabIndex = 15;
            this.groupBoxMovientos.TabStop = false;
            this.groupBoxMovientos.Text = "Movimientos";
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 576);
            this.Controls.Add(this.groupBoxMovientos);
            this.Controls.Add(this.groupBoxGestionarCuentas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCuentas";
            this.Text = "Cuentas Bancarias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCuentas_FormClosing);
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            this.groupBoxGestionarCuentas.ResumeLayout(false);
            this.groupBoxGestionarCuentas.PerformLayout();
            this.groupBoxMovientos.ResumeLayout(false);
            this.groupBoxMovientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.TextBox textBoxSaldoInicial;
        private System.Windows.Forms.Button buttonCrearCuenta;
        private System.Windows.Forms.Label labelInfoCuenta;
        private System.Windows.Forms.Button buttonAbonar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.Button buttonConsultarHistorial;
        private System.Windows.Forms.TextBox textBoxHistorial;
        private System.Windows.Forms.Label labelBuscarNumero;
        private System.Windows.Forms.TextBox textBoxBuscarNumero;
        private System.Windows.Forms.Button buttonBuscar;
        public System.Windows.Forms.GroupBox groupBoxGestionarCuentas;
        public System.Windows.Forms.GroupBox groupBoxMovientos;
    }
}

