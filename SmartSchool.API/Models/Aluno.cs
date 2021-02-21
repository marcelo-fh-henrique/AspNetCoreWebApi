using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SmartSchool.API.Models
{
    [XmlRoot(ElementName = "alunos")]
    public class Aluno
    {
        [XmlElement(ElementName = "id")]
        public int ID { get; set; }

        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "sobrenome")]
        public string Sobrenome { get; set; }

        [XmlElement(ElementName = "telefone")]
        public string Telefone { get; set; }

        //public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }

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
