namespace ErrorHandlingSch {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ErrorHandling", @"ResponseErrorHandling"})]
    public sealed class SQLService_EventViewerLog : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://OWBT.ErrorHandling/EventViewerLog"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [EventViewerInsert] @EventCategory=&quot; &quot;, @EventDateTime=&quot; &quot;, @EventLevel=&quot; &quot;, @EventMachineName=&quot; &quot;, @EventMessage=&quot; &quot;, @EventSource=&quot; &quot;"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ErrorHandling"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""EventViewerInsert"">
          <xs:complexType>
            <xs:attribute name=""EventCategory"" type=""xs:string"" />
            <xs:attribute name=""EventDateTime"" type=""xs:string"" />
            <xs:attribute name=""EventLevel"" type=""xs:string"" />
            <xs:attribute name=""EventMachineName"" type=""xs:string"" />
            <xs:attribute name=""EventMessage"" type=""xs:string"" />
            <xs:attribute name=""EventSource"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ResponseErrorHandling"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SQLService_EventViewerLog() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ErrorHandling";
                _RootElements[1] = "ResponseErrorHandling";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://OWBT.ErrorHandling/EventViewerLog",@"ErrorHandling")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ErrorHandling"})]
        public sealed class ErrorHandling : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ErrorHandling() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ErrorHandling";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://OWBT.ErrorHandling/EventViewerLog",@"ResponseErrorHandling")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ResponseErrorHandling"})]
        public sealed class ResponseErrorHandling : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ResponseErrorHandling() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ResponseErrorHandling";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
