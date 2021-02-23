using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SmartSchool.API.Models
{
    public class Aluno
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Aluno() { }

        public Aluno(int iD, string nome, string sobrenome, string telefone)
        {
            ID = iD;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
}
