
namespace HiperGrandao
{
    partial class frmCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.cbxTipoProduto = new System.Windows.Forms.ComboBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblKg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCartao = new System.Windows.Forms.RadioButton();
            this.rBtnDebito = new System.Windows.Forms.RadioButton();
            this.rBtnDinheiro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Titulo.Location = new System.Drawing.Point(260, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(218, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Hipermercado";
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo2.ForeColor = System.Drawing.Color.Red;
            this.Titulo2.Location = new System.Drawing.Point(306, 51);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(143, 37);
            this.Titulo2.TabIndex = 1;
            this.Titulo2.Text = "Grandão";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(178, 499);
            this.listBox1.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(247, 125);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(226, 23);
            this.txtProduto.TabIndex = 3;
            // 
            // cbxTipoProduto
            // 
            this.cbxTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoProduto.FormattingEnabled = true;
            this.cbxTipoProduto.Items.AddRange(new object[] {
            "Produto unitário",
            "Produto por Kg"});
            this.cbxTipoProduto.Location = new System.Drawing.Point(247, 168);
            this.cbxTipoProduto.Name = "cbxTipoProduto";
            this.cbxTipoProduto.Size = new System.Drawing.Size(226, 23);
            this.cbxTipoProduto.TabIndex = 4;
            this.cbxTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cbxTipoProduto_SelectedIndexChanged);
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(247, 222);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(114, 36);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(247, 107);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(53, 15);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "Produto:";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(245, 150);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(96, 15);
            this.lblTipoProduto.TabIndex = 7;
            this.lblTipoProduto.Text = "Tipo do produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(511, 107);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(103, 15);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço do produto:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(513, 125);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(226, 23);
            this.txtPreco.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(509, 150);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(98, 15);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso do produto:";
            this.lblPeso.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(511, 168);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(226, 23);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.Visible = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(436, 222);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(114, 36);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(623, 222);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(114, 36);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(513, 107);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(89, 15);
            this.lblKg.TabIndex = 14;
            this.lblKg.Text = "Preço do Quilo:";
            this.lblKg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Os itens da lista são selecionáveis";
            // 
            // rbtnCartao
            // 
            this.rbtnCartao.AutoSize = true;
            this.rbtnCartao.Location = new System.Drawing.Point(247, 295);
            this.rbtnCartao.Name = "rbtnCartao";
            this.rbtnCartao.Size = new System.Drawing.Size(116, 19);
            this.rbtnCartao.TabIndex = 16;
            this.rbtnCartao.Text = "Cartão de crédito";
            this.rbtnCartao.UseVisualStyleBackColor = true;
            this.rbtnCartao.Visible = false;
            // 
            // rBtnDebito
            // 
            this.rBtnDebito.AutoSize = true;
            this.rBtnDebito.Location = new System.Drawing.Point(247, 331);
            this.rBtnDebito.Name = "rBtnDebito";
            this.rBtnDebito.Size = new System.Drawing.Size(113, 19);
            this.rBtnDebito.TabIndex = 17;
            this.rBtnDebito.TabStop = true;
            this.rBtnDebito.Text = "Cartão de débito";
            this.rBtnDebito.UseVisualStyleBackColor = true;
            this.rBtnDebito.Visible = false;
            // 
            // rBtnDinheiro
            // 
            this.rBtnDinheiro.AutoSize = true;
            this.rBtnDinheiro.Location = new System.Drawing.Point(247, 366);
            this.rBtnDinheiro.Name = "rBtnDinheiro";
            this.rBtnDinheiro.Size = new System.Drawing.Size(70, 19);
            this.rBtnDinheiro.TabIndex = 18;
            this.rBtnDinheiro.TabStop = true;
            this.rBtnDinheiro.Text = "Dinheiro";
            this.rBtnDinheiro.UseVisualStyleBackColor = true;
            this.rBtnDinheiro.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(484, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 217);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Compra Finalizada!";
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Volte sempre ao Hipermercado Grandão!!!";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "R$";
            this.label4.Visible = false;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(82, 37);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(38, 15);
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "label4";
            this.lblPago.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "total";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paga com: ";
            this.label3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total a pago: ";
            this.label6.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(247, 399);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a pagar: ";
            this.lblTotal.Visible = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(348, 399);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(31, 15);
            this.lblValorTotal.TabIndex = 20;
            this.lblValorTotal.Text = "total";
            this.lblValorTotal.Visible = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(245, 435);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(114, 39);
            this.btnConcluir.TabIndex = 21;
            this.btnConcluir.Text = "Concluir pagamento";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Visible = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "R$";
            this.label2.Visible = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rBtnDinheiro);
            this.Controls.Add(this.rBtnDebito);
            this.Controls.Add(this.rbtnCartao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblTipoProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.cbxTipoProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Titulo2);
            this.Controls.Add(this.Titulo);
            this.Name = "frmCaixa";
            this.Text = "Caixa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Titulo2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ComboBox cbxTipoProduto;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCartao;
        private System.Windows.Forms.RadioButton rBtnDebito;
        private System.Windows.Forms.RadioButton rBtnDinheiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

