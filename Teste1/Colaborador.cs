using System;

namespace gftStart4
{
    public class Colaborador
    {   
        private String nome;
        public String Nome
        {
            get { return this.Nome; }
            set { this.Nome = value; }
        }

        private int idade;
        public int Idade
        {
            get { return this.Idade; }
            set { this.Idade = value; }
        }

        private int salario;
        public int Salario
        {
            get { return this.Salario; }
            set { this.Salario = value; }
        }

        private int grauInstrucao;
        public int GrauInstrucao
        {
            get { return this.GrauInstrucao; }
            set { this.GrauInstrucao = value; }
        }

        private void Bonificacao()
        {
            Console.WriteLine("Salário: " + this.Salario);
        }
        
        
        
    }

}