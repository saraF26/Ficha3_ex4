using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Ficha3_ex4
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string NumeroMatricula { get; set; }
        public List<Disciplina> DisciplinasMatriculas { get; set; }

        //construtor
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            NumeroMatricula = matricula;
            DisciplinasMatriculas = new List<Disciplina>();
            
        }
        //METODOS
        public void MatricularEmDisciplina(Disciplina disciplina)
        {
            if(disciplina!=null && !DisciplinasMatriculas.Contains(disciplina))
            {
                DisciplinasMatriculas.Add(disciplina);
                disciplina.AdicionarAluno(this);
            }
        }
        public void ExibirInformações()
        {
            Console.WriteLine($"Aluno: {Nome}, Matricula: {NumeroMatricula}");
            Console.WriteLine("Disciplinas Matriculadas:");

            foreach(var disciplina in DisciplinasMatriculas)
            {
                Console.WriteLine($" - {disciplina.Nome}");
            }
        }
    }
}
