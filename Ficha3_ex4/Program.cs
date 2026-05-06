namespace Ficha3_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o nome do professor:");
            string nome1 = Console.ReadLine();



            Professor p1 = new Professor(nome1, "P01");
            Professor p2 = new Professor("rui", "P02");

            Aluno a1 = new Aluno("Sara", "M1");
            Aluno a2 = new Aluno("Ana", "M2");

            Disciplina d1 = new Disciplina("C#", "D1");
            Disciplina d2 = new Disciplina("Java", "D2");

            //Associação de professores á disciplina

            d1.DefenirProfessor(p1);
            d2.DefenirProfessor(p2);
        }
    }
}
