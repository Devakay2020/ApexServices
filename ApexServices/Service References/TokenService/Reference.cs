//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.TokenService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TokenService.TokenServiceSoap")]
    public interface TokenServiceSoap {
        
        // CODEGEN: Generating message contract since element name source from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Validate", ReplyAction="*")]
        ApexServices.TokenService.ValidateResponse Validate(ApexServices.TokenService.ValidateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Validate", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.TokenService.ValidateResponse> ValidateAsync(ApexServices.TokenService.ValidateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Validate", Namespace="http://tempuri.org/", Order=0)]
        public ApexServices.TokenService.ValidateRequestBody Body;
        
        public ValidateRequest() {
        }
        
        public ValidateRequest(ApexServices.TokenService.ValidateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int application;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string source;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string IP;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string requestXml;
        
        public ValidateRequestBody() {
        }
        
        public ValidateRequestBody(int application, string source, string token, string IP, string requestXml) {
            this.application = application;
            this.source = source;
            this.token = token;
            this.IP = IP;
            this.requestXml = requestXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateResponse", Namespace="http://tempuri.org/", Order=0)]
        public ApexServices.TokenService.ValidateResponseBody Body;
        
        public ValidateResponse() {
        }
        
        public ValidateResponse(ApexServices.TokenService.ValidateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidateResult;
        
        public ValidateResponseBody() {
        }
        
        public ValidateResponseBody(bool ValidateResult) {
            this.ValidateResult = ValidateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TokenServiceSoapChannel : ApexServices.TokenService.TokenServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TokenServiceSoapClient : System.ServiceModel.ClientBase<ApexServices.TokenService.TokenServiceSoap>, ApexServices.TokenService.TokenServiceSoap {
        
        public TokenServiceSoapClient() {
        }
        
        public TokenServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TokenServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.TokenService.ValidateResponse ApexServices.TokenService.TokenServiceSoap.Validate(ApexServices.TokenService.ValidateRequest request) {
            return base.Channel.Validate(request);
        }
        
        public bool Validate(int application, string source, string token, string IP, string requestXml) {
            ApexServices.TokenService.ValidateRequest inValue = new ApexServices.TokenService.ValidateRequest();
            inValue.Body = new ApexServices.TokenService.ValidateRequestBody();
            inValue.Body.application = application;
            inValue.Body.source = source;
            inValue.Body.token = token;
            inValue.Body.IP = IP;
            inValue.Body.requestXml = requestXml;
            ApexServices.TokenService.ValidateResponse retVal = ((ApexServices.TokenService.TokenServiceSoap)(this)).Validate(inValue);
            return retVal.Body.ValidateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.TokenService.ValidateResponse> ApexServices.TokenService.TokenServiceSoap.ValidateAsync(ApexServices.TokenService.ValidateRequest request) {
            return base.Channel.ValidateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.TokenService.ValidateResponse> ValidateAsync(int application, string source, string token, string IP, string requestXml) {
            ApexServices.TokenService.ValidateRequest inValue = new ApexServices.TokenService.ValidateRequest();
            inValue.Body = new ApexServices.TokenService.ValidateRequestBody();
            inValue.Body.application = application;
            inValue.Body.source = source;
            inValue.Body.token = token;
            inValue.Body.IP = IP;
            inValue.Body.requestXml = requestXml;
            return ((ApexServices.TokenService.TokenServiceSoap)(this)).ValidateAsync(inValue);
        }
    }
}
