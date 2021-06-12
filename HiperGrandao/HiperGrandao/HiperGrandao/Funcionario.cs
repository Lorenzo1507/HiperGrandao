using System;
using System.Collections.Generic;
using System.Text;

namespace HiperGrandao
{
    public abstract class Funcionario
    {
        public string NomeFuncionario { get; set; }
        public string Senha { get; set; }
        public string TipoFuncionario { get; set; }

        public Funcionario (string nome, string senha, string tipo)
        {
            this.NomeFuncionario = nome;
            this.Senha = senha;
            this.TipoFuncionario = tipo;
        }
    }
}
