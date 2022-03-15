using System;

namespace gftStart4
{
    public class Supervisor : Colaborador
    {
        public void BonificacaoS()
        {
            double s1 = Salario + 500.00 * GrauInstrucao;
            this.Salario = ((int)s1 * 2);
        }
    }
}