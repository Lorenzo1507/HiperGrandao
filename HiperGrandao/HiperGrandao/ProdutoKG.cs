using System;
using System.Collections.Generic;
using System.Text;

namespace HiperGrandao
{
    public class ProdutoKG : Produto
    {
        public float Peso { get; set; }
        public ProdutoKG(string nome, float preco, string tipo, float peso) : base (nome, preco, tipo)
        {
            this.Peso = peso;
        }
    }
}
