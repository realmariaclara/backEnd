using Sesi.Models;

class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "Moranguete";
        meuGato.cor = "Branco";
        meuGato.idade = 1;
        meuGato.especie = "Isfins";
        meuGato.genero = "femea";
        meuGato.peso = 3;
        meuGato.EmitirSom();

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Palhaço";
        meuPeixe.cor = "Azul";
        meuPeixe.tamanho = 0.20M;
        meuPeixe.peso = 0.100M;
    }
}