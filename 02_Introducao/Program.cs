// Somente declaramos a variável como inteira e não atribuimos valor
int num1;

//Declarando um variável do tipo inteira e atribuindo o valor
int num2 = 5;

//Declarando uma variavel do tipo string 
string nomeAluno;

//Variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//Variável do tipo valor com casa decimais - para valores mais preciosos
double coordenada = 1.80;

//Variável do tipo decimal - mais usada para valor monetário 
decimal valor = 1.80M;


int idade = 17;
string nome = "Maria";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação do usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");
