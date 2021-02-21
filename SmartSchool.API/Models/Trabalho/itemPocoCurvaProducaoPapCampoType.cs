namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "itemPocoCurvaProducao-PapCampoType")]
    public partial class itemPocoCurvaProducaoPapCampoType
    {

        private string iND_POCO_NOVOField;

        private string cOD_CADASTRO_POCOField;

        private string nOME_OPERADORField;

        private string iND_PRODUTOR_INJETORField;

        private System.DateTime dAT_INICIO_OPERACAOField;

        private System.DateTime dAT_PREVISAO_RETORNOField;

        private string cOD_ZONAField;

        private string cOD_UEP_POCOField;

        private string cOD_UEP_POCO_NOVAField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IND_POCO_NOVO
        {
            get
            {
                return this.iND_POCO_NOVOField;
            }
            set
            {
                this.iND_POCO_NOVOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COD_CADASTRO_POCO
        {
            get
            {
                return this.cOD_CADASTRO_POCOField;
            }
            set
            {
                this.cOD_CADASTRO_POCOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NOME_OPERADOR
        {
            get
            {
                return this.nOME_OPERADORField;
            }
            set
            {
                this.nOME_OPERADORField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IND_PRODUTOR_INJETOR
        {
            get
            {
                return this.iND_PRODUTOR_INJETORField;
            }
            set
            {
                this.iND_PRODUTOR_INJETORField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DAT_INICIO_OPERACAO
        {
            get
            {
                return this.dAT_INICIO_OPERACAOField;
            }
            set
            {
                this.dAT_INICIO_OPERACAOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DAT_PREVISAO_RETORNO
        {
            get
            {
                return this.dAT_PREVISAO_RETORNOField;
            }
            set
            {
                this.dAT_PREVISAO_RETORNOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string COD_ZONA
        {
            get
            {
                return this.cOD_ZONAField;
            }
            set
            {
                this.cOD_ZONAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string COD_UEP_POCO
        {
            get
            {
                return this.cOD_UEP_POCOField;
            }
            set
            {
                this.cOD_UEP_POCOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COD_UEP_POCO_NOVA
        {
            get
            {
                return this.cOD_UEP_POCO_NOVAField;
            }
            set
            {
                this.cOD_UEP_POCO_NOVAField = value;
            }
        }
    }
}
