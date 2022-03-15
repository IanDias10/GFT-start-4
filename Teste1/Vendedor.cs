using System;

namespace gftStart4
{
    public class Vendedor : Colaborador
    {
        public void BonificacaoV()
        {
            double s1 = Salario + 300.00 * GrauInstrucao;
            this.Salario = ((int)s1 * 2);
        }
    }
}