namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PROGRAMAS_ANUAIS_DE_PRODUCAO_CAMPO
    {

        private itemPAPCampoType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAP_CAMPO", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemPAPCampoType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
