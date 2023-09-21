namespace Sistema.Models
{
    public class ContaCorrente
    {

        private string titular { get; set; }

        private decimal saldo { get; set; }

        public ContaCorrente(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O seu saldo bancário é de {saldo}");
        }

        public void SacarSaldo()
        {
            Console.WriteLine("Digite o valor do saque:");
            decimal saque = decimal.Parse(Console.ReadLine());
            saldo -= saque;
            Console.WriteLine($"Você sacou {saldo}");
        }

        public void DepositarSaldo()
        {
            Console.WriteLine("Digite o valor do depósito:");
            decimal valor = decimal.Parse(Console.ReadLine());
            saldo += valor;
            Console.WriteLine($"O saldo atualizado é de {saldo}");
        }
    }


}