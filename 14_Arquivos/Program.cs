using System.IO;

public class Program
{
    public static void Main()
    {
        gravarArquivo();
    }

    public static void gravarArquivo()
    {
        try
        {
            //Gravando arquivo de texto
            using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
            {
                arquivo.WriteLine("OLÁ");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }
}