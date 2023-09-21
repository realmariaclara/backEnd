﻿public class Program
{
    public static void Main()
    {
        //O try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //A execução do bloco vai para o catch
        try{        
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }

        catch(OverflowException)
        {
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }

        //Tratando exceção de erro específica de formato
        catch (FormaException)
        {
            Console.WriteLine("Digite um número inteiro");
        }

        //É o tratamento do erro, normalmente colocamos as mensagens de acordo
        //Com o tipo do erro, para melhorar compreensão do usúario
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro genérico: {erro.Message}");
        }

        finally
        {
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }
    }
}