namespace SmartSchool.API.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class itemPAPCampoType
    {

        private string iDENTIFICADOR_EXTERNOField;

        private string cODIGO_CAMPOField;

        private string aNO_REFERENCIAField;

        private string mOTIVO_REVISAOField;

        private itemProducaoCampoPapCampoType[] pRODUCOES_CAMPOField;

        private itemInjecaoCampoPapCampoType[] iNJECOES_CAMPOField;

        private itemProducaoZonaUepPapCampoType[] pRODUCOES_ZONAUEPField;

        private itemInjecaoZonaUepPapCampoType[] iNJECOES_ZONAUEPField;

        private itemMovimentacaoPapCampoType[] mOVIMENTACOESField;

        private itemQueimadorPapCampoType[] qUEIMADORESField;

        private itemTransferenciaPapCampoType[] tRANSFERENCIASField;

        private itemPocoCurvaProducaoPapCampoType[] pOCOS_CURVA_PRODUCAOField;

        private itemListaInformacoesComplementaresPapCampoType iNFORMACOES_COMPLEMENTARESField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IDENTIFICADOR_EXTERNO
        {
            get
            {
                return this.iDENTIFICADOR_EXTERNOField;
            }
            set
            {
                this.iDENTIFICADOR_EXTERNOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string CODIGO_CAMPO
        {
            get
            {
                return this.cODIGO_CAMPOField;
            }
            set
            {
                this.cODIGO_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "positiveInteger")]
        public string ANO_REFERENCIA
        {
            get
            {
                return this.aNO_REFERENCIAField;
            }
            set
            {
                this.aNO_REFERENCIAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MOTIVO_REVISAO
        {
            get
            {
                return this.mOTIVO_REVISAOField;
            }
            set
            {
                this.mOTIVO_REVISAOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PRODUCAO_CAMPO", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemProducaoCampoPapCampoType[] PRODUCOES_CAMPO
        {
            get
            {
                return this.pRODUCOES_CAMPOField;
            }
            set
            {
                this.pRODUCOES_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("INJECAO_CAMPO", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemInjecaoCampoPapCampoType[] INJECOES_CAMPO
        {
            get
            {
                return this.iNJECOES_CAMPOField;
            }
            set
            {
                this.iNJECOES_CAMPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PRODUCAO_ZONA_UEP", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemProducaoZonaUepPapCampoType[] PRODUCOES_ZONA_UEP
        {
            get
            {
                return this.pRODUCOES_ZONAUEPField;
            }
            set
            {
                this.pRODUCOES_ZONAUEPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("INJECAO_ZONA_UEP", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemInjecaoZonaUepPapCampoType[] INJECOES_ZONA_UEP
        {
            get
            {
                return this.iNJECOES_ZONAUEPField;
            }
            set
            {
                this.iNJECOES_ZONAUEPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("MOVIMENTACAO", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemMovimentacaoPapCampoType[] MOVIMENTACOES
        {
            get
            {
                return this.mOVIMENTACOESField;
            }
            set
            {
                this.mOVIMENTACOESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("QUEIMADOR", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemQueimadorPapCampoType[] QUEIMADORES
        {
            get
            {
                return this.qUEIMADORESField;
            }
            set
            {
                this.qUEIMADORESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TRANSFERENCIA", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemTransferenciaPapCampoType[] TRANSFERENCIAS
        {
            get
            {
                return this.tRANSFERENCIASField;
            }
            set
            {
                this.tRANSFERENCIASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("POCO_CURVA_PRODUCAO", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemPocoCurvaProducaoPapCampoType[] POCOS_CURVA_PRODUCAO
        {
            get
            {
                return this.pOCOS_CURVA_PRODUCAOField;
            }
            set
            {
                this.pOCOS_CURVA_PRODUCAOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemListaInformacoesComplementaresPapCampoType INFORMACOES_COMPLEMENTARES
        {
            get
            {
                return this.iNFORMACOES_COMPLEMENTARESField;
            }
            set
            {
                this.iNFORMACOES_COMPLEMENTARESField = value;
            }
        }
    }
}
