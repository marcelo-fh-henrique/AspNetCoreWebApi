namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "itemListaInformacoesComplementares-PapCampoType")]
    public partial class itemListaInformacoesComplementaresPapCampoType
    {

        private itemInformacaoComplementarPapCampoType iNFORMACAO_COMPLEMENTARField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemInformacaoComplementarPapCampoType INFORMACAO_COMPLEMENTAR
        {
            get
            {
                return this.iNFORMACAO_COMPLEMENTARField;
            }
            set
            {
                this.iNFORMACAO_COMPLEMENTARField = value;
            }
        }
    }
}
