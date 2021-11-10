using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteAna = new Gerente(){
            Nome = "Ana",
            CPF = "987.987.987-98",
            Salario = 2000,
            NumeroDeAgencias = 5
            };
               

            Vendedor vendedorAlexandre = new Vendedor(){
            Nome = "Alexandre",
            CPF = "123.123.123-45",
            Salario = 1000,
            NumeroClientesAtendidos = 2
            };
            

            Vendedor vendedorMarcelo = new Vendedor(){
            Nome = "Marcelo",
            CPF = "456.456.456-67",
            Salario = 1000,
            NumeroClientesAtendidos = 4
            };
                vendedorMarcelo.Bonificacao = vendedorMarcelo.Salario;

            Vendedor vendedorFelipe = new Vendedor(){
            Nome = "Felipe",
            CPF = "458.965.487.97",
            Salario = 1000,
            NumeroClientesAtendidos = 3
            };


             gerenteAna.Bonificacao = gerenteAna.Salario;
             vendedorAlexandre.Bonificacao = vendedorAlexandre.Salario;
             vendedorMarcelo.Bonificacao = vendedorMarcelo.Salario;
             vendedorFelipe.Bonificacao = vendedorFelipe.Salario;    

          //------------------

            ContaCorrente contaDoMarcus = new ContaCorrente("Marcus Vinicius Ferreira Oliveira", 1234, 100,vendedorAlexandre); //vendedor Alexandre
            ContaCorrente contaDoAntonio = new ContaCorrente("Antonio Marcos", 1234, 120, vendedorMarcelo); //vendedor Marcelo
            ContaCorrente contaDaValdirene = new ContaCorrente("Valdirene", 1234, 150, vendedorAlexandre); //vendedor Alexandre


            Console.WriteLine("   "); 
            Console.WriteLine(" Nome: Marcus Vinicius Ferreira Oliveira"); 
            Console.WriteLine(" Turma: 35 DS - MT");
            Console.WriteLine(" N°: 29"); 
            Console.WriteLine("   "); 
            Console.WriteLine("                                                       Inicio da Tarefa   "); 
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Contas Correntes --------------------");  
            Console.WriteLine("   "); 
            Console.WriteLine("O saldo da conta do Marcus Vinicius Ferreira Oliveira é de: " + contaDoMarcus.Titular);
            Console.WriteLine("O vendedor que ajuda o Marcus é:" + vendedorAlexandre.Nome);
            Console.WriteLine("   "); 
            Console.WriteLine("O saldo da conta do Antonio Marcos é de: " + contaDoAntonio.Titular);
            Console.WriteLine("O vendedor que ajuda o Antonio é:" + vendedorMarcelo.Nome);
            Console.WriteLine("   "); 
            Console.WriteLine("O saldo da conta da Valdirene é de: " + contaDaValdirene.Titular);
            Console.WriteLine("O vendedor que ajuda o Valdirene é:" + vendedorAlexandre.Nome); //------------------------
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Saques --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("Sacando R$ 50 (cinquenta reais) de todas as contas criadas");
            contaDoMarcus.Sacar(50);
            Console.WriteLine("O saldo atual de Marcus é de: " + contaDoMarcus.Saldo);
            contaDoAntonio.Sacar(50);
            Console.WriteLine("O saldo atual de Antonio é de: " + contaDoAntonio.Saldo);
            contaDaValdirene.Sacar(50);
            Console.WriteLine("O saldo atual de Valdirene é de: " + contaDaValdirene.Saldo);
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Tranferencia --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("Transferindo R$ 5 (cinco reais) do marcus para o antonio");
            contaDoMarcus.Transferir(5, contaDoAntonio);
            Console.WriteLine("O saldo da conta do Marcus é: " + contaDoMarcus.Saldo);
            Console.WriteLine("O saldo da conta do Antonio é: " + contaDoAntonio.Saldo);
            Console.WriteLine("   "); 
            Console.WriteLine("Transferindo R$ 10 (dez reais) do Antonio para a Valdirene");
            contaDoAntonio.Transferir(10, contaDaValdirene);
            Console.WriteLine("O saldo da conta do Antonio é: " + contaDoAntonio.Saldo);
            Console.WriteLine("O saldo da conta da Valdirene é: " + contaDaValdirene.Saldo);
            Console.WriteLine("   "); 
            Console.WriteLine("Transferindo R$ 15 (quinze reais) da Valdirene para o Marcus");
            contaDaValdirene.Transferir(15, contaDoMarcus);
            Console.WriteLine("O saldo da conta da Valdirene é: " + contaDaValdirene.Saldo);
            Console.WriteLine("O saldo da conta do Marcus é: " + contaDoMarcus.Saldo);
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Comissão dos vendedores --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("A comissão do vendedor Alexandre é: " + vendedorAlexandre.Comissao); 
            Console.WriteLine("A comissão do vendedor Marcelo é: " + vendedorMarcelo.Comissao); 
            Console.WriteLine("A comissão do vendedor Felipe é: " + vendedorFelipe.Comissao); 
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Total de comissão a ser pago --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("O total de comissão a ser pago é de: " + ContaCorrente.TotalDeComissao); 
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Bonificação Anual dos vendedores e Gerente --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("A bonificação do vendedor Alexandre é de R$: " + vendedorAlexandre.Bonificacao);
            Console.WriteLine("A bonificação do vendedor Marcelo é de R$: " + vendedorMarcelo.Bonificacao);
            Console.WriteLine("A bonificação do vendedor Felipe é de R$: " + vendedorFelipe.Bonificacao); 
            Console.WriteLine("A bonificação da gerente é de R$: " + gerenteAna.Bonificacao);
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Renumeração total dos vendedores e gerente --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("A renumereção do vendedor Alexandre é de R$: " + vendedorAlexandre.RemuneracaoTotal(vendedorAlexandre.Salario, vendedorAlexandre.Bonificacao));
            Console.WriteLine("A renumereção do vendedor Marcelo é de R$: " + vendedorMarcelo.RemuneracaoTotal(vendedorMarcelo.Salario, vendedorMarcelo.Bonificacao));
            Console.WriteLine("A renumereção do vendedor Felipe é de R$: " + vendedorFelipe.RemuneracaoTotal(vendedorFelipe.Salario, vendedorFelipe.Bonificacao));
            Console.WriteLine("A renumereção da gerente Ana é de R$: " + gerenteAna.RemuneracaoTotal(gerenteAna.Salario, gerenteAna.Bonificacao));
            Console.WriteLine("   "); 
            Console.WriteLine("------------------------- Ferias dos vendedores e gerente --------------------");
            Console.WriteLine("   "); 
            Console.WriteLine("O vendedor Alexandre terá: " + vendedorAlexandre.CalcularFerias() + "dias de ferias");
            Console.WriteLine("O vendedor Marcelo terá: " + vendedorMarcelo.CalcularFerias() + "dias de ferias");
            Console.WriteLine("O vendedor Felipe terá: " + vendedorFelipe.CalcularFerias() + "dias de ferias");
            Console.WriteLine("a gerente Ana terá: " + gerenteAna.CalcularFerias() + "dias de ferias");
            Console.WriteLine("   "); 
            Console.WriteLine(" Fim da tarefa  "); 
           
            
        }
    }
}