using System;

namespace gftStart4
{
    internal class program
    {
        static void Main(String[] args)
        {
            Colaborador c = new Colaborador();
            c.Salario = Convert.ToInt32(1500);

            Console.WriteLine(c.Salario);
        }
    }
}