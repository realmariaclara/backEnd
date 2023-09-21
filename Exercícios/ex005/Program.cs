class Churrasco 
 {
 
    public static void Main()
        {
        //Chamar o método
        ListaDoChurrasco();
        }

    //Declarar o vetor em seis posições
    public static void ListaDoChurrasco()
    {
        string[] listaProdutos = new string[6];

    //Receber os produtos que precisam ser comprados
        listaProdutos[0] = "Carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;
        }
    
        //Ordenar vetor 
        Array.Sort(listaProdutos);

        //"Para cada" item na lista exibir no console 
        foreach(string item in listaProdutos){
            Console.WriteLine($"Item {item}");
        }
    }

    public static void SonhosDeConsumo(){
        string[] listaSonhos = new string[3];
        int[] valorSonhos = new int [3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.WriteLine("Informe o sonho:");
            string sonho = Console.ReadLine();
            listaSonhos[i] = sonho;

            Console.WriteLine("Informe o valor:");
            int valor = int.Parse(Console.ReadLine());
            valorSonhos[i] = valor;
        }

        foreach (int intem in listaSonhos)
            soma += intem;
        Console.WriteLine($"Seus sonhos custarão R${soma}");
    }

}

