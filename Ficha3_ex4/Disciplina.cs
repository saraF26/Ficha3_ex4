using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Ficha3_ex4
{
    internal class Disciplina
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public List<Aluno> AlunosMatriculados { get; set; }
        public Professor Professor { get; set; }

        //construtor
        public Disciplina(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
            AlunosMatriculados = new List<Aluno>();
        }

        //METODOS
        public void AdicionarAluno(Aluno aluno)
        {
            if(aluno!=null && !AlunosMatriculados.Contains(aluno))
            {
                AlunosMatriculados.Add(aluno);
            }
        }

        public void DefenirProfessor(Professor professor)
        {
            if (professor != null)
            {
                Professor = professor;
                //atribuo a refª do objeto professor à propriedade Professor
                professor.AdicionarDisciplina(this);
            }
            

        }
        public void ExibirInformaçoes()
        {
            Console.WriteLine($"Disciplina: {Nome}, codigo: {Codigo}");
            Console.WriteLine($"Alunos Matriculados:");
            foreach(var aluno in AlunosMatriculados)
            {
                Console.WriteLine($" - {aluno.Nome}");
            }
            if (Professor != null)
            {
                Console.WriteLine($"Professor: {Professor.Nome}");
            }
        }
    }
}
