using System;
using System.Collections.Generic;
using System.Text;

namespace HiperGrandao
{
    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string TipoProduto { get; set; }

        public Produto (string nome, float preco, string tipo)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.TipoProduto = tipo;
        }
    }
}
