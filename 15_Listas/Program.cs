using System.Collections.Generic;
using Sesi.Models;

public class program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista 
        listaNumeros.Add(10); // posição [0]
        listaNumeros.Add(5); // posição [1]
        listaNumeros.Add(23); // posição [2]

        //Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} nr");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(7); // posição [4]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} nr");

        Console.WriteLine("---------------------");

        //Criem uma nova lista de texto e adicionem alguns nomes a ela e exibam a quantidade de nomes que contém nela 
        List<string> listaNomes = new List<string>();

        listaNomes.Add("Maria"); // posição [0]
        listaNomes.Add("Vividona"); // posição [1]
        listaNomes.Add("Grazi"); // Posição [3]

        Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------");

        //Criando uma lista já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        numeros.Add(10);

        //Removendo um elemento buscando pelo conteúdo
        numeros.Remove(2);
        //Remove o elemento pela posição (índice)
        numeros.RemoveAt(4);
        //Remove o elemento da posição dois e os próximos dois elementos
        numeros.RemoveRange(2,2);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        } 

        Console.WriteLine("--------------------");

        //Declarar uma nova lista com objetos da classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno na lista
        Aluno novoAluno = new Aluno("Luis", 18);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Marcos", 17));
        listaAlunos.Add(new Aluno("Camila", 16));
        listaAlunos.Add(new Aluno("Aurora", 13));
        listaAlunos.Add(new Aluno("Augusto", 17));

        Console.WriteLine("Lista de Alunos");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome aluno: {item.nome}, Idade Aluno: {item.idade}");
        }

        Console.WriteLine("--------------------");

        //Criando uma nova lista, filtrando e ordenando por nome 
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome 
                        select aluno;
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome Aluno: {item.nome} idade {item.idade}");
        }

        //LINQ utilizando Sintaxe de método
        var metodo = listaAlunos 
                            .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);
        Console.WriteLine("----------------------");
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            
            Console.WriteLine($"Nome Aluno: {item.nome} idade {item.idade}");
        }
    }
}