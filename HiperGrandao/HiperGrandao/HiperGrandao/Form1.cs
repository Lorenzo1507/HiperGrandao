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

            if (cbxTipoProduto.SelectedIndex == 0)
            {
                Produto produto = new Produto(txtProduto.Text, preco, cbxTipoProduto.SelectedItem.ToString());
                produtos.Add(produto);

                listBox1.Items.Add(produto.Nome + "  R$" + produto.Preco);
            }
            else
            {
                float peso = float.Parse(txtPeso.Text);
                ProdutoKG produtoKg = new ProdutoKG(txtProduto.Text, preco, cbxTipoProduto.SelectedItem.ToString(), peso);
                listBox1.Items.Add(produtoKg.Nome + "  R$" + produtoKg.Preco + " X " + produtoKg.Peso + " Kg");

                produtoKg.Preco *= peso;
                produtos.Add(produtoKg);

                
            }

        }

        private void cbxTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Troca entre as opções de Produto kg e produto normal
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Habilita fazer o que quiser através de código, com multiplos itens selecionados de uma lista, ao invés de selecionar um por vez
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                //contador começa em 0 então...
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(selectedItems[i]);
                }
                   
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            rbtnCartao.Visible = true;
            rBtnDebito.Visible = true;
            rBtnDinheiro.Visible = true;
            lblTotal.Visible = true;
            lblValorTotal.Visible = true;
            btnConcluir.Visible = true;
            label2.Visible = true;

            float total = 0;

            //Pega o valor dos preços dos produtos na List
            foreach (Produto produto in produtos)
            {
                total += produto.Preco;
            }

            lblValorTotal.Text = total.ToString();


        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (rbtnCartao.Checked == true || rBtnDebito.Checked == true || rBtnDinheiro.Checked == true)
            {
                groupBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                lblPago.Visible = true;

                label5.Text = lblValorTotal.Text;

                if(rbtnCartao.Checked == true)
                {
                    lblPago.Text = rbtnCartao.Text;
                }
                else 
                {
                    if (rBtnDebito.Checked == true)
                    {
                        lblPago.Text = rBtnDebito.Text;
                    }

                    else
                    {
                        lblPago.Text = rBtnDinheiro.Text;
                    }
                }
            }
        }
    }
}
