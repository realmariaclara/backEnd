﻿//Exercícios Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string
string nome = Console.ReadLine();
Console.WriteLine($"meu nome é {nome}");


//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite o valor de nota1:");
int nota1 = int.Parse(Console.ReadLine());


//Receber a nota 2, converter e armazenar em uma variável int 
Console.WriteLine("Digite o valor de nota2:");
int nota2 = int.Parse(Console.ReadLine());


//Receber a nota 3, converter e armazenar em uma variável int 
Console.WriteLine("Digite o valor de nota3:");
int nota3 = int.Parse(Console.ReadLine());


//Declarar uma variável do tipo int, para receber a média das notas
//(nota1, nota2, nota3) / 3 
int media = (nota1 + nota2 + nota3) / 3;

//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7
//if = se 
if (media >=7){
    Console.WriteLine($"{nome} você está APROVADO(a) com média {media}!");
} else {
    Console.WriteLine($"{nome} você está REPROVADO(a) com média {media}!");
}