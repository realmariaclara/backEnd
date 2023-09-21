using Sesi.Model;

class  Program 
{
     public static void Main()
    {
      //Criando uma variável aluno1 e instanciando da classe Aluno
      //Criando objeto
      var aluno1 = new Aluno();
      aluno1.nome = "Maria";
      aluno1.idade = 17;
      aluno1.turma = "2 EM";

      //Chamando o método de classe Aluno
      aluno1.Apresentar();

      var aluno2 = new Aluno();
      aluno2.nome = "Clara";
      aluno2.idade = 17;
      aluno2.turma = "2 EM";

      aluno2.Apresentar();
      aluno2.AdicionarFaltas(10);
      aluno2.Apresentar();
      
      aluno2.ResumoFaltas();

      
    }
}