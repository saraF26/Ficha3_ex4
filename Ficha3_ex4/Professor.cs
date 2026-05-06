using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Ficha3_ex4
{
    internal class Professor
    {
        public string Nome { get; set; }
        public string NumeroRegistro { get; set; }
        public List<Disciplina> DisciplinasLecionadas { get; set; }

        public Professor(string nome, string numeroRegisto)
        {
            Nome = nome;
            NumeroRegistro = numeroRegisto;
            DisciplinasLecionadas = new List<Disciplina>();
            
        }
        //Metodos:
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            if (!DisciplinasLecionadas.Contains(disciplina))
            {
                DisciplinasLecionadas.Add(disciplina);
            }
        }
        public void ExibirInformações()
        {
            Console.WriteLine($"Professor: {Nome}");
            Console.WriteLine("Disciplinas lecionadas:");
            foreach(var disciplina in DisciplinasLecionadas)
            {
                Console.WriteLine($" - {disciplina.Nome}");
            }
        }
    }
}
