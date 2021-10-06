using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionarioAlexandre = new Funcionario(){
            Nome = "Alexandre",
            CPF = "123.123.123-45",
            Cargo = "Vendedor",
            Salario = 1000
            };

            Funcionario funcionarioMarcelo = new Funcionario();
            funcionarioMarcelo.Nome = "Marcelo";
            funcionarioMarcelo.CPF = "456.456.456-67";
            funcionarioMarcelo.Cargo = "Vendedor";
            funcionarioMarcelo.Salario = 1000;

            funcionarioMarcelo.Bonificacao = funcionarioMarcelo.Salario;

            ContaCorrente contaDoMarcus = new ContaCorrente("Marcus Vinicius Ferreira Oliveira", 1234, 100, funcionarioAlexandre); //Funcionario Alexandre
            ContaCorrente contaDoAntonio = new ContaCorrente("Antonio Marcos", 1234, 120, funcionarioMarcelo); //Funcionario Marcelo
            ContaCorrente contaDaValdirene = new ContaCorrente("Valdirene", 1234, 150, funcionarioAlexandre); //Funcionario Alexandre


            Console.WriteLine("   "); 
            Console.WriteLine(" Nome: Marcus Vinicius Ferreira Oliveira"); 
            Console.WriteLine(" Turma: 35 DS - MT");
            Console.WriteLine(" N°: 29"); 
            Console.WriteLine("   "); 
            Console.WriteLine("                                                       Inicio da Tarefa   "); 
            Console.WriteLine("   "); 
            Console.WriteLine("-------------------------Saldo das contas--------------------");  
            Console.WriteLine("O saldo da conta do Marcus é: " + contaDoMarcus.Saldo);
            Console.WriteLine("O saldo da conta do Antonio é: " + contaDoAntonio.Saldo);
            Console.WriteLine("O saldo da conta da Valdirene é: " + contaDaValdirene.Saldo);
            
            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Comisão dos vendedores--------------------");  
            Console.WriteLine("A comissão do vendedor Alexandre é:: " + funcionarioAlexandre.Comissao);
            Console.WriteLine("A comissão do vendedor Marcelo é:" + funcionarioMarcelo.Comissao);

            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Salario dos vendedores--------------------"); 
            Console.WriteLine("O Salario do Alexandre é de:" + funcionarioAlexandre.Salario);
            Console.WriteLine("O Salario do Marcelo é de:" + funcionarioMarcelo.Salario);

             Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Numero total de contas criadas--------------------"); 
            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);

            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Valor total de comissão a ser pago--------------------"); 
            Console.WriteLine("O total de comissão a ser pago é:" + ContaCorrente.TotalDeComissao);

            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Sacar Dinheiro--------------------"); 
            contaDoMarcus.Sacar(90);
            Console.WriteLine("Depois de sacar dinheiro o saldo da conta do Marcus é:" + contaDoMarcus.Saldo);
            contaDoAntonio.Sacar(70);
            Console.WriteLine("Depois de sacar dinheiro o saldo da conta do Antonio é:" + contaDoAntonio.Saldo);
            contaDaValdirene.Sacar(110);
            Console.WriteLine("Depois de sacar dinheiro o saldo da conta da Valdirene é:" + contaDaValdirene.Saldo);

            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Depositar dinheiro--------------------"); 
            contaDoMarcus.Depositar(100);
            Console.WriteLine("Depois de depositar dinheiro o saldo da conta do Marcus é:" + contaDoMarcus.Saldo);
            contaDoAntonio.Depositar(80);
            Console.WriteLine("Depois de depositar dinheiro o saldo da conta do Antonio é:" + contaDoAntonio.Saldo);
            contaDaValdirene.Depositar(50);
            Console.WriteLine("Depois de depositar dinheiro o saldo da conta da Valdirene é:" + contaDaValdirene.Saldo);

            Console.WriteLine("     "); 
            Console.WriteLine("-------------------------Transferir dinheiro--------------------"); 
            contaDoMarcus.Transferir(10, contaDoAntonio);
            Console.WriteLine("Depois que o Marcus Trasfeririu dinheiro para Antonio o saldo da conta do Marcus é: " + contaDoMarcus.Saldo +  "e o saldo do Antorio é : " + contaDoAntonio.Saldo);
            contaDoAntonio.Transferir(05, contaDaValdirene);
            Console.WriteLine("Depois que o Antonio Trasfeririu dinheiro para Valdirene o saldo da conta do Antorio é: " + contaDoAntonio.Saldo + " e o saldo da Valdirene é : " + contaDaValdirene.Saldo);
            contaDaValdirene.Transferir(03, contaDoMarcus);
            Console.WriteLine("Depois que a Valdirene Trasfeririu dinheiro para Marcus o saldo da conta da Valdirene é: " + contaDaValdirene.Saldo + " e o saldo do do marcus é : " + contaDoMarcus.Saldo);

            Console.WriteLine("   "); 
            Console.WriteLine("                                                       Fim da Tarefa   "); 
            Console.WriteLine("   "); 
            Console.WriteLine(" aula de hoje:  "); 
             Console.WriteLine("A Bonifiação do Alexandre é de:" + funcionarioAlexandre.Bonificacao);
            Console.WriteLine("A Bonificação do Marcelo é de:" + funcionarioMarcelo.Bonificacao);
        }
    }
}