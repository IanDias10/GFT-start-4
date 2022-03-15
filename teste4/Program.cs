using System;

namespace Teste4
{
    class program
    {
        static void Main(String[] args)
        {
            string name;
            double altura;
            int peso;
            double imc;

            Console.WriteLine("Qual o seu Nome: ");
            name = Console.ReadLine();

            Console.WriteLine("Qual sua Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o seu Peso: ");
            peso = Convert.ToInt32(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine(name + " " + altura + " " + peso + " " + imc);
            Console.ReadKey();
        }
    }
}
