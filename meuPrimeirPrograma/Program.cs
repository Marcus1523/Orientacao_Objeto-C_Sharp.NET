using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoMarcus = new ContaCorrente("Marcus", 1234, 789, 100.50);

            ContaCorrente contaDoJoao = new ContaCorrente("Joao", 1234, 790, 120);

            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 791, 150);

            Console.WriteLine("O titular da conta é: " + contaDoMarcus.titular);
            Console.WriteLine("O titular da conta é: " + contaDoJoao.titular);
            Console.WriteLine("O titular da conta é: " + contaDaMaria.titular);
        }
    }
}