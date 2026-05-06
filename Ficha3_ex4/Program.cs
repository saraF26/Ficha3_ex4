namespace Ficha3_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduza o nome do professor:");
            //string nome1 = Console.ReadLine();



            //Professor p1 = new Professor(nome1, "P01");
            //Professor p2 = new Professor("rui", "P02");

            //Aluno a1 = new Aluno("Sara", "M1");
            //Aluno a2 = new Aluno("Ana", "M2");

            //Disciplina d1 = new Disciplina("C#", "D1");
            //Disciplina d2 = new Disciplina("Java", "D2");

            ////Associação de professores á disciplina

            //d1.DefenirProfessor(p1);
            //d2.DefenirProfessor(p2);
            ////associação de alunos a disciplinas
            //a1.MatricularEmDisciplina(d1);
            //a2.MatricularEmDisciplina(d1);
            ////exibir informações
            //a1.ExibirInformações();
            //d1.ExibirInformaçoes();
            //p1.ExibirInformações();
            List<Professor> listaProfessores = new List<Professor>();
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            int opcao;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-Adicionar Professor");
                Console.WriteLine("2-Adicionar Aluno");
                Console.WriteLine("3-Adicionar Disciplina");
                Console.WriteLine("4- Associar professor à disciplina");
                Console.WriteLine("5-Matricular o aluno");
                Console.WriteLine("6- Listar Professores");
                Console.WriteLine("7 - listar Alunos");
                Console.WriteLine("8 - Listar Disciplinas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha a opção");
                 opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Nome do professor:");
                        string nomeProf = Console.ReadLine();
                        Console.WriteLine("Numero registro:");
                        string numRegisto = Console.ReadLine();

                        listaProfessores.Add(new Professor(nomeProf, numRegisto));
                        break;
                    case 2:
                        Console.WriteLine("Nome do aluno:");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("Numero matricula:");
                        string numMatricula = Console.ReadLine();
                        listaAlunos.Add(new Aluno(nomeAluno, numMatricula));
                        break;
                    case 3:
                        Console.WriteLine("Nome da disciplina:");
                        string nomeDisc = Console.ReadLine();
                        Console.WriteLine("Código:");
                        string codigoDisc = Console.ReadLine();
                        listaDisciplinas.Add(new Disciplina(nomeDisc, codigoDisc));
                        break;
                    case 4:

                        Console.WriteLine("\n Professores:");
                        for (int i = 0; i < listaProfessores.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listaProfessores[i].Nome}");
                        }
                        Console.WriteLine("Escolha o professor:");
                        int p = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n Disciplinas:");
                        for (int i = 0; i < listaDisciplinas.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listaDisciplinas[i].Nome}");
                        }
                        Console.WriteLine("Escolha a disciplina:");
                        int d = int.Parse(Console.ReadLine());

                        //associação
                        listaDisciplinas[d].DefenirProfessor(listaProfessores[p]);
                        break;
                    case 5:
                        Console.WriteLine("\n Alunos:");
                        for (int i = 0; i < listaAlunos.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listaAlunos[i].Nome}");
                        }
                        Console.WriteLine("Escolher um aluno:");
                        int a = int.Parse(Console.ReadLine());


                        Console.WriteLine("\n Disciplinas:");
                        for (int i = 0; i < listaDisciplinas.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listaDisciplinas[i].Nome}");
                        }
                        Console.WriteLine("Escolha a disciplina:");
                        int dis = int.Parse(Console.ReadLine());

                        //Associação
                        listaAlunos[a].MatricularEmDisciplina(listaDisciplinas[dis]);
                        break;
                    case 6: //listar professores

                        foreach (var prof in listaProfessores)
                        {
                            prof.ExibirInformações();
                        }
                        break;

                    case 7: //listar alunos

                        foreach (var aluno in listaAlunos)
                        {
                            aluno.ExibirInformações();
                        }
                        break;

                    case 8: //listar disciplinas

                        foreach (var disc in listaDisciplinas)
                        {
                            disc.ExibirInformaçoes();
                        }
                        break;
                    case 0:
                        Console.WriteLine("programa a terminar");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
