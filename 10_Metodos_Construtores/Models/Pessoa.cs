namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        //Criando nosso método construtor
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Métodos da classe Pessoa 
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Dancar()
        {
            Console.WriteLine($"{nome} está dançando");
        }

        public void Falar()
        {
            Console.WriteLine($"{nome} está falando");
        }
    }
}