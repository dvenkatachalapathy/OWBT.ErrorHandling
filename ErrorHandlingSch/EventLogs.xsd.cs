namespace ErrorHandlingSch {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"ErrorHandling")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ErrorHandling"})]
    public sealed class EventLogs : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ErrorHandling"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Events"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""Event"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Level"" type=""xs:string"" />
                    <xs:element name=""DateTime"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Source"" type=""xs:string"" />
                    <xs:element name=""Category"" type=""xs:string"" />
                    <xs:element name=""Message"" type=""xs:string"" />
                    <xs:element name=""MachineName"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Summary"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Information"" type=""xs:unsignedByte"" />
              <xs:element name=""Warning"" type=""xs:unsignedShort"" />
              <xs:element name=""Error"" type=""xs:unsignedByte"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EventLogs() {
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
}
