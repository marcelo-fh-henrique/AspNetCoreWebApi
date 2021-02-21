using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SmartSchool.API.Models
{
    [XmlRoot(ElementName = "alunos")]
    public class Alunos
    {
        [XmlElement(ElementName = "id")]
        public int id { get; set; }

        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }

        [XmlElement(ElementName = "sobrenome")]
        public string Sobrenome { get; set; }

        [XmlElement(ElementName = "telefone")]
        public string Telefone { get; set; }
    }
}
