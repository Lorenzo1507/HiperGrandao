using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiperGrandao
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        List<Produto> produtos = new List<Produto>();

        private void btnLancar_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(txtPreco.Text);

            /*Produto unitário
Produto por Kg*/

            if (cbxTipoProduto.SelectedIndex == 0)
            //if (cbxTipoProduto.SelectedItem.ToString() == "Produto unitário")
            {
                Produto produto = new Produto(txtProduto.Text, preco, cbxTipoProduto.SelectedItem.ToString());
                produtos.Add(produto);
            }
            else
            {
                float peso = float.Parse(txtPeso.Text);
                ProdutoKG produtoKg = new ProdutoKG(txtProduto.Text, preco, cbxTipoProduto.SelectedItem.ToString(), peso);
                produtos.Add(produtoKg);
            }

            foreach (Produto produto in produtos)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void cbxTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoProduto.SelectedIndex == 1)
            {
                lblPreco.Visible = false;
                lblKg.Visible = true;
                lblPeso.Visible = true;
                txtPeso.Visible = true;
            }
            else
            {
                lblPreco.Visible = true;
                lblKg.Visible = false;
                lblPeso.Visible = false;
                txtPeso.Visible = false;
            }
            
        }

        /*if (cbxTipoProduto.SelectedItem.ToString() == "Produto unitário")
            {
                lblPreco.Visible = false;
                lblKg.Visible = true;
                lblPeso.Visible = true;
                txtPeso.Visible = true;
            }
            else
            {
                lblPreco.Visible = true;
                lblKg.Visible = false;
                lblPeso.Visible = false;
                txtPeso.Visible = false;
            }*/
    }
}
