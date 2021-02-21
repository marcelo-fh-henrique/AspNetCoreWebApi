namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "itemTransferencia-PapCampoType")]
    public partial class itemTransferenciaPapCampoType
    {

        private string mES_TRANSFERENCIAField;

        private string oRIGEM_DESTINO_RECEBIMENTO_TRANSFERENCIAField;

        private decimal pETROLEO_RECEBIDOField;

        private decimal pETROLEO_TRANSFERIDOField;

        private decimal gAS_RECEBIDO_CAMPOField;

        private decimal gAS_TRANSFERIDO_CAMPOField;

        private decimal aGUA_RECEBIDA_CAMPOField;

        private decimal aGUA_TRANSFERIDA_CAMPOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string MES_TRANSFERENCIA
        {
            get
            {
                return this.mES_TRANSFERENCIAField;
            }
            set
            {
                this.mES_TRANSFERENCIAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string ORIGEM_DESTINO_RECEBIMENTO_TRANSFERENCIA
        {
            get
            {
                return this.oRIGEM_DESTINO_RECEBIMENTO_TRANSFERENCIAField;
            }
            set
            {
                this.oRIGEM_DESTINO_RECEBIMENTO_TRANSFERENCIAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal PETROLEO_RECEBIDO
        {
            get
            {
                return this.pETROLEO_RECEBIDOField;
            }
            set
            {
                this.pETROLEO_RECEBIDOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal PETROLEO_TRANSFERIDO
        {
            get
            {
                return this.pETROLEO_TRANSFERIDOField;
            }
            set
            {
                this.pETROLEO_TRANSFERIDOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal GAS_RECEBIDO_CAMPO
        {
            get
            {
                return this.gAS_RECEBIDO_CAMPOField;
            }
            set
            {
                this.gAS_RECEBIDO_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal GAS_TRANSFERIDO_CAMPO
        {
            get
            {
                return this.gAS_TRANSFERIDO_CAMPOField;
            }
            set
            {
                this.gAS_TRANSFERIDO_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal AGUA_RECEBIDA_CAMPO
        {
            get
            {
                return this.aGUA_RECEBIDA_CAMPOField;
            }
            set
            {
                this.aGUA_RECEBIDA_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal AGUA_TRANSFERIDA_CAMPO
        {
            get
            {
                return this.aGUA_TRANSFERIDA_CAMPOField;
            }
            set
            {
                this.aGUA_TRANSFERIDA_CAMPOField = value;
            }
        }
    }
}
