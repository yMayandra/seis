
namespace seis.View
{
    partial class main
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxFrete = new System.Windows.Forms.TextBox();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(127, 89);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(127, 121);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(127, 155);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(46, 15);
            this.lblFrete.TabIndex = 0;
            this.lblFrete.Text = "% Frete";
            // 
            // tbxCliente
            // 
            this.tbxCliente.Location = new System.Drawing.Point(199, 80);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.Size = new System.Drawing.Size(100, 23);
            this.tbxCliente.TabIndex = 1;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(199, 113);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 23);
            this.tbxValor.TabIndex = 1;
            // 
            // tbxFrete
            // 
            this.tbxFrete.Location = new System.Drawing.Point(199, 147);
            this.tbxFrete.Name = "tbxFrete";
            this.tbxFrete.Size = new System.Drawing.Size(100, 23);
            this.tbxFrete.TabIndex = 1;
            // 
            // cbxUf
            // 
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "Selecione",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(199, 184);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(100, 23);
            this.cbxUf.TabIndex = 2;
            this.cbxUf.SelectedIndexChanged += new System.EventHandler(this.cbxUf_SelectedIndexChanged);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(127, 192);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(19, 15);
            this.lblUf.TabIndex = 3;
            this.lblUf.Text = "Uf";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(199, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(127, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(172, 89);
            this.lblResultado.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.cbxUf);
            this.Controls.Add(this.tbxFrete);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxCliente);
            this.Controls.Add(this.lblFrete);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxFrete;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}