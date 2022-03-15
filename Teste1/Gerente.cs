using System;

namespace gftStart4
{
    public class Gerente : Colaborador
    {
        public void BonificacaoG()
        {
            double s1 = Salario + 1000.00 * GrauInstrucao;
            this.Salario = ((int)s1 * 2);
        }
    }
}