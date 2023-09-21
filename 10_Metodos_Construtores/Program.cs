using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto da classe Pessoa 
        /*
        Instanciando objeto sem método contrutor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Maria Clara";
        pessoa1.idade = 17;

        //Alternativa de um objeto instanciado sem construtor 
            Pessoa pessoa1 = new Pessoa{
                nome = "Ana",
                idade = 16
            }
        */

        //Intanciando o objeto com o método contrutor
        Pessoa pessoa1 = new Pessoa("Maria Clara", 17);
        Pessoa pessoa2 = new Pessoa("Vitória", 17);
        Pessoa pessoa3 = new Pessoa("Grazi", 16);

        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();
        pessoa2.Dancar();
        pessoa3.Falar();
    }
}