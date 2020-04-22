namespace TestandoCheckBox {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.txtNummesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtdshop = new System.Windows.Forms.TextBox();
            this.txtQtdPetisco = new System.Windows.Forms.TextBox();
            this.txtqtdRefeicao = new System.Windows.Forms.TextBox();
            this.txtTotalServico = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.chkShop = new System.Windows.Forms.CheckBox();
            this.chkPetisco = new System.Windows.Forms.CheckBox();
            this.chkRefeicao = new System.Windows.Forms.CheckBox();
            this.btnFecharConta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Location = new System.Drawing.Point(89, 90);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(62, 13);
            this.lblNumMesa.TabIndex = 0;
            this.lblNumMesa.Text = "N° da mesa";
            // 
            // txtNummesa
            // 
            this.txtNummesa.Location = new System.Drawing.Point(167, 87);
            this.txtNummesa.Name = "txtNummesa";
            this.txtNummesa.Size = new System.Drawing.Size(100, 20);
            this.txtNummesa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(92, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(218, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qtd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Parcial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total serviços (8%)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total a pagar";
            // 
            // txtQtdshop
            // 
            this.txtQtdshop.Location = new System.Drawing.Point(218, 194);
            this.txtQtdshop.Name = "txtQtdshop";
            this.txtQtdshop.Size = new System.Drawing.Size(100, 20);
            this.txtQtdshop.TabIndex = 10;
            // 
            // txtQtdPetisco
            // 
            this.txtQtdPetisco.Location = new System.Drawing.Point(218, 251);
            this.txtQtdPetisco.Name = "txtQtdPetisco";
            this.txtQtdPetisco.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPetisco.TabIndex = 11;
            // 
            // txtqtdRefeicao
            // 
            this.txtqtdRefeicao.Location = new System.Drawing.Point(218, 297);
            this.txtqtdRefeicao.Name = "txtqtdRefeicao";
            this.txtqtdRefeicao.Size = new System.Drawing.Size(100, 20);
            this.txtqtdRefeicao.TabIndex = 12;
            // 
            // txtTotalServico
            // 
            this.txtTotalServico.Location = new System.Drawing.Point(377, 248);
            this.txtTotalServico.Name = "txtTotalServico";
            this.txtTotalServico.Size = new System.Drawing.Size(100, 20);
            this.txtTotalServico.TabIndex = 13;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(377, 298);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 14;
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Location = new System.Drawing.Point(377, 192);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(100, 20);
            this.txtTotalParcial.TabIndex = 15;
            // 
            // chkShop
            // 
            this.chkShop.AutoSize = true;
            this.chkShop.Location = new System.Drawing.Point(92, 196);
            this.chkShop.Name = "chkShop";
            this.chkShop.Size = new System.Drawing.Size(98, 17);
            this.chkShop.TabIndex = 16;
            this.chkShop.Text = "Shopp R$ 5,00";
            this.chkShop.UseVisualStyleBackColor = true;
            // 
            // chkPetisco
            // 
            this.chkPetisco.AutoSize = true;
            this.chkPetisco.Location = new System.Drawing.Point(92, 251);
            this.chkPetisco.Name = "chkPetisco";
            this.chkPetisco.Size = new System.Drawing.Size(102, 17);
            this.chkPetisco.TabIndex = 17;
            this.chkPetisco.Text = "Petisco R$ 9,00";
            this.chkPetisco.UseVisualStyleBackColor = true;
            // 
            // chkRefeicao
            // 
            this.chkRefeicao.AutoSize = true;
            this.chkRefeicao.Location = new System.Drawing.Point(92, 297);
            this.chkRefeicao.Name = "chkRefeicao";
            this.chkRefeicao.Size = new System.Drawing.Size(116, 17);
            this.chkRefeicao.TabIndex = 18;
            this.chkRefeicao.Text = "Refeição R$ 15,90";
            this.chkRefeicao.UseVisualStyleBackColor = true;
            // 
            // btnFecharConta
            // 
            this.btnFecharConta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFecharConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharConta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFecharConta.Location = new System.Drawing.Point(336, 366);
            this.btnFecharConta.Name = "btnFecharConta";
            this.btnFecharConta.Size = new System.Drawing.Size(117, 23);
            this.btnFecharConta.TabIndex = 19;
            this.btnFecharConta.Text = "Fechar conta";
            this.btnFecharConta.UseVisualStyleBackColor = false;
            this.btnFecharConta.Click += new System.EventHandler(this.btnFecharConta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(377, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total a Pagar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFecharConta);
            this.Controls.Add(this.chkRefeicao);
            this.Controls.Add(this.chkPetisco);
            this.Controls.Add(this.chkShop);
            this.Controls.Add(this.txtTotalParcial);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtTotalServico);
            this.Controls.Add(this.txtqtdRefeicao);
            this.Controls.Add(this.txtQtdPetisco);
            this.Controls.Add(this.txtQtdshop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNummesa);
            this.Controls.Add(this.lblNumMesa);
            this.Name = "Form1";
            this.Text = "Fechar conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.TextBox txtNummesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtdshop;
        private System.Windows.Forms.TextBox txtQtdPetisco;
        private System.Windows.Forms.TextBox txtqtdRefeicao;
        private System.Windows.Forms.TextBox txtTotalServico;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.CheckBox chkShop;
        private System.Windows.Forms.CheckBox chkPetisco;
        private System.Windows.Forms.CheckBox chkRefeicao;
        private System.Windows.Forms.Button btnFecharConta;
        private System.Windows.Forms.Label label5;
    }
}

