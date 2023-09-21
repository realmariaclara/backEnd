//Colocar o nome da classe como o nome do arquivo
class Senai
{
    //Método Main é o ponto de entrada de um programa em C#
    public static void Main()
    {
        Console.WriteLine("Estou no método Main");
        Metodo();
        ImprimeDataHora();
        int resultadoSoma = Somar(3,8);
        Console.WriteLine(resultadoSoma);
        ContagemRegressiva(8);
    }


   public static void ContagemRegressiva(int n)
    {
        while (n >= 0){
            Console.WriteLine(n);
            n--; //n = n - 1;
            System.Threading.Thread.Sleep(1000); //Pausa de 1s - 1000ms
        }
        Console.WriteLine("BOOOOOOOOOOOOOOM");
    }

    public static void Metodo()
    {
        Console.WriteLine("Estou no método / função");
    }

//void não retorna
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static int Somar(int n1, int n2)
    {
        int soma = n1 + n2;
        return soma;
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * ");
        Console.WriteLine(" Bem Vindo ao Jogo");
        Console.WriteLine("Sorteei um nº 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * *  * * * * *  * * * * * * ** ");
        Console.WriteLine(""); // Linha em branco 

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitando = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitando = int.Parse(Console.ReadLine());
                if(nrDigitando > nrSorteado)
                    Console.WriteLine("O número digitado é MAIOR que ");
                else if (nrDigitando < nrSorteado)
                    Console.WriteLine("O número digitado é Menor que o sorteado");
        } while (nrSorteado != nrSorteado);
            Console.WriteLine("Parabéns você acertou");
    }
  
}