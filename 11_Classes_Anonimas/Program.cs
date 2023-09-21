public class Program
{

    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "Rafa",
            idade = 20
        };

        var pessoa2 = new
        {
            nome = "Júlia",
            idade = 21
        };

        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("Digite a marca do carro");
        string MarcaDigitada = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro");
        string AnoDigitado = Console.ReadLine();
        
        var carro = new
        {
            marca = modeloDigitado,
            modelo = MarcaDigitada,
            ano = AnoDigitado,
        };

        Console.WriteLine($"A marca do carro é {carro.marca} o modelo é {carro.modelo} e o ano é {carro.ano}");
    }
}