
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
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Titulo.Location = new System.Drawing.Point(260, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(265, 42);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Hipermercado";
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo2.ForeColor = System.Drawing.Color.Red;
            this.Titulo2.Location = new System.Drawing.Point(306, 51);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(167, 42);
            this.Titulo2.TabIndex = 1;
            this.Titulo2.Text = "Grandão";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 9);
            this.listBox1.Name = "listBox1";
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
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(623, 222);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(114, 36);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
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
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
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
    }
}

