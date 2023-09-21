using Sistema.Models;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Seja Bem-Vindo ao nosso Banco");
        Console.WriteLine("*****************************");
        Console.WriteLine("Aqui cuidamos no seu dinheiro!!");

        ContaCorrente conta = new ContaCorrente("Maria", 0);

        string opcao = "";

        do
        {
            Console.WriteLine("########## S I S T E M A ############");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar ");
            Console.WriteLine("3 - Sacar ");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch(opcao){
                case "4":
                    Console.WriteLine("Obrigado(a), volte sempre!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    conta.DepositarSaldo();
                    break;
                case "3":
                    conta.SacarSaldo();
                    break;
                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }
        } while (opcao != "0");
    }
}