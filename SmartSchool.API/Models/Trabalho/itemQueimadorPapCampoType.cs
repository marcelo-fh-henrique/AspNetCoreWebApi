namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "itemQueimador-PapCampoType")]
    public partial class itemQueimadorPapCampoType
    {

        private string cOD_PILOTOField;

        private string qTD_PILOTOField;

        private string dSC_LOCAL_QUEIMAField;

        private decimal vOL_QUEIMA_PILOTOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string COD_PILOTO
        {
            get
            {
                return this.cOD_PILOTOField;
            }
            set
            {
                this.cOD_PILOTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string QTD_PILOTO
        {
            get
            {
                return this.qTD_PILOTOField;
            }
            set
            {
                this.qTD_PILOTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DSC_LOCAL_QUEIMA
        {
            get
            {
                return this.dSC_LOCAL_QUEIMAField;
            }
            set
            {
                this.dSC_LOCAL_QUEIMAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal VOL_QUEIMA_PILOTO
        {
            get
            {
                return this.vOL_QUEIMA_PILOTOField;
            }
            set
            {
                this.vOL_QUEIMA_PILOTOField = value;
            }
        }
    }
}
