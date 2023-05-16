namespace OWBT.ErrorHandlingMap {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ErrorHandlingSch.EventLogs", typeof(global::ErrorHandlingSch.EventLogs))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ErrorHandlingSch.SQLService_EventViewerLog+ErrorHandling", typeof(global::ErrorHandlingSch.SQLService_EventViewerLog.ErrorHandling))]
    public sealed class TransInMsg_InMsgDB : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://OWBT.ErrorHandling/EventViewerLog"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ErrorHandling"" />
  </xsl:template>
  <xsl:template match=""/ErrorHandling"">
    <ns0:ErrorHandling>
      <xsl:for-each select=""Events/Event"">
        <ns0:EventViewerInsert>
          <xsl:attribute name=""EventCategory"">
            <xsl:value-of select=""Category/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""EventDateTime"">
            <xsl:value-of select=""DateTime/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""EventLevel"">
            <xsl:value-of select=""Level/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""EventMachineName"">
            <xsl:value-of select=""MachineName/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""EventMessage"">
            <xsl:value-of select=""Message/text()"" />
          </xsl:attribute>
          <xsl:attribute name=""EventSource"">
            <xsl:value-of select=""Source/text()"" />
          </xsl:attribute>
        </ns0:EventViewerInsert>
      </xsl:for-each>
    </ns0:ErrorHandling>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ErrorHandlingSch.EventLogs";
        
        private const global::ErrorHandlingSch.EventLogs _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ErrorHandlingSch.SQLService_EventViewerLog+ErrorHandling";
        
        private const global::ErrorHandlingSch.SQLService_EventViewerLog.ErrorHandling _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ErrorHandlingSch.EventLogs";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ErrorHandlingSch.SQLService_EventViewerLog+ErrorHandling";
                return _TrgSchemas;
            }
        }
    }
}
