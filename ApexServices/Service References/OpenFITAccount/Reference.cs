//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.OpenFITAccount {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OpenFITAccount", Namespace="http://Bank.Biztalk.FundsInTransit")]
    [System.SerializableAttribute()]
    public partial class OpenFITAccount : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpportunityReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare5Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageID {
            get {
                return this.MessageIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIDField, value) != true)) {
                    this.MessageIDField = value;
                    this.RaisePropertyChanged("MessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageType {
            get {
                return this.MessageTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTypeField, value) != true)) {
                    this.MessageTypeField = value;
                    this.RaisePropertyChanged("MessageType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SourceID {
            get {
                return this.SourceIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceIDField, value) != true)) {
                    this.SourceIDField = value;
                    this.RaisePropertyChanged("SourceID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string AccountType {
            get {
                return this.AccountTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountTypeField, value) != true)) {
                    this.AccountTypeField = value;
                    this.RaisePropertyChanged("AccountType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string AccountCurrency {
            get {
                return this.AccountCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountCurrencyField, value) != true)) {
                    this.AccountCurrencyField = value;
                    this.RaisePropertyChanged("AccountCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string OpportunityReference {
            get {
                return this.OpportunityReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.OpportunityReferenceField, value) != true)) {
                    this.OpportunityReferenceField = value;
                    this.RaisePropertyChanged("OpportunityReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Spare1 {
            get {
                return this.Spare1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare1Field, value) != true)) {
                    this.Spare1Field = value;
                    this.RaisePropertyChanged("Spare1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Spare2 {
            get {
                return this.Spare2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare2Field, value) != true)) {
                    this.Spare2Field = value;
                    this.RaisePropertyChanged("Spare2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Spare3 {
            get {
                return this.Spare3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare3Field, value) != true)) {
                    this.Spare3Field = value;
                    this.RaisePropertyChanged("Spare3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string Spare4 {
            get {
                return this.Spare4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare4Field, value) != true)) {
                    this.Spare4Field = value;
                    this.RaisePropertyChanged("Spare4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Spare5 {
            get {
                return this.Spare5Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare5Field, value) != true)) {
                    this.Spare5Field = value;
                    this.RaisePropertyChanged("Spare5");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OpenFITAccountResponse", Namespace="http://Bank.Biztalk.FundsInTransit")]
    [System.SerializableAttribute()]
    public partial class OpenFITAccountResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FITAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spare5Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageID {
            get {
                return this.MessageIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIDField, value) != true)) {
                    this.MessageIDField = value;
                    this.RaisePropertyChanged("MessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageType {
            get {
                return this.MessageTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTypeField, value) != true)) {
                    this.MessageTypeField = value;
                    this.RaisePropertyChanged("MessageType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SourceID {
            get {
                return this.SourceIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceIDField, value) != true)) {
                    this.SourceIDField = value;
                    this.RaisePropertyChanged("SourceID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string FITAccountNumber {
            get {
                return this.FITAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.FITAccountNumberField, value) != true)) {
                    this.FITAccountNumberField = value;
                    this.RaisePropertyChanged("FITAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ResponseCode {
            get {
                return this.ResponseCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseCodeField, value) != true)) {
                    this.ResponseCodeField = value;
                    this.RaisePropertyChanged("ResponseCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ResponseDescription {
            get {
                return this.ResponseDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseDescriptionField, value) != true)) {
                    this.ResponseDescriptionField = value;
                    this.RaisePropertyChanged("ResponseDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Spare1 {
            get {
                return this.Spare1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare1Field, value) != true)) {
                    this.Spare1Field = value;
                    this.RaisePropertyChanged("Spare1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Spare2 {
            get {
                return this.Spare2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare2Field, value) != true)) {
                    this.Spare2Field = value;
                    this.RaisePropertyChanged("Spare2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Spare3 {
            get {
                return this.Spare3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare3Field, value) != true)) {
                    this.Spare3Field = value;
                    this.RaisePropertyChanged("Spare3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Spare4 {
            get {
                return this.Spare4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare4Field, value) != true)) {
                    this.Spare4Field = value;
                    this.RaisePropertyChanged("Spare4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string Spare5 {
            get {
                return this.Spare5Field;
            }
            set {
                if ((object.ReferenceEquals(this.Spare5Field, value) != true)) {
                    this.Spare5Field = value;
                    this.RaisePropertyChanged("Spare5");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Bank.Biztalk.FundsInTransit", ConfigurationName="OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPor" +
        "tSoap")]
    public interface Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap {
        
        // CODEGEN: Generating message contract since element name OpenFITAccount from namespace http://Bank.Biztalk.FundsInTransit is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.FundsInTransit/Bank_Biztalk_FundsInTransit_orcProcessOpenFITA" +
            "ccount_ReceiveOFAPort/OFA", ReplyAction="*")]
        ApexServices.OpenFITAccount.OFAResponse OFA(ApexServices.OpenFITAccount.OFARequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.FundsInTransit/Bank_Biztalk_FundsInTransit_orcProcessOpenFITA" +
            "ccount_ReceiveOFAPort/OFA", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.OpenFITAccount.OFAResponse> OFAAsync(ApexServices.OpenFITAccount.OFARequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OFARequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OFA", Namespace="http://Bank.Biztalk.FundsInTransit", Order=0)]
        public ApexServices.OpenFITAccount.OFARequestBody Body;
        
        public OFARequest() {
        }
        
        public OFARequest(ApexServices.OpenFITAccount.OFARequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Bank.Biztalk.FundsInTransit")]
    public partial class OFARequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.OpenFITAccount.OpenFITAccount OpenFITAccount;
        
        public OFARequestBody() {
        }
        
        public OFARequestBody(ApexServices.OpenFITAccount.OpenFITAccount OpenFITAccount) {
            this.OpenFITAccount = OpenFITAccount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OFAResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OFAResponse", Namespace="http://Bank.Biztalk.FundsInTransit", Order=0)]
        public ApexServices.OpenFITAccount.OFAResponseBody Body;
        
        public OFAResponse() {
        }
        
        public OFAResponse(ApexServices.OpenFITAccount.OFAResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Bank.Biztalk.FundsInTransit")]
    public partial class OFAResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.OpenFITAccount.OpenFITAccountResponse OpenFITAccountResponse;
        
        public OFAResponseBody() {
        }
        
        public OFAResponseBody(ApexServices.OpenFITAccount.OpenFITAccountResponse OpenFITAccountResponse) {
            this.OpenFITAccountResponse = OpenFITAccountResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapChannel : ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient : System.ServiceModel.ClientBase<ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap>, ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap {
        
        public Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient() {
        }
        
        public Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.OpenFITAccount.OFAResponse ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap.OFA(ApexServices.OpenFITAccount.OFARequest request) {
            return base.Channel.OFA(request);
        }
        
        public ApexServices.OpenFITAccount.OpenFITAccountResponse OFA(ApexServices.OpenFITAccount.OpenFITAccount OpenFITAccount) {
            ApexServices.OpenFITAccount.OFARequest inValue = new ApexServices.OpenFITAccount.OFARequest();
            inValue.Body = new ApexServices.OpenFITAccount.OFARequestBody();
            inValue.Body.OpenFITAccount = OpenFITAccount;
            ApexServices.OpenFITAccount.OFAResponse retVal = ((ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap)(this)).OFA(inValue);
            return retVal.Body.OpenFITAccountResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.OpenFITAccount.OFAResponse> ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap.OFAAsync(ApexServices.OpenFITAccount.OFARequest request) {
            return base.Channel.OFAAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.OpenFITAccount.OFAResponse> OFAAsync(ApexServices.OpenFITAccount.OpenFITAccount OpenFITAccount) {
            ApexServices.OpenFITAccount.OFARequest inValue = new ApexServices.OpenFITAccount.OFARequest();
            inValue.Body = new ApexServices.OpenFITAccount.OFARequestBody();
            inValue.Body.OpenFITAccount = OpenFITAccount;
            return ((ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoap)(this)).OFAAsync(inValue);
        }
    }
}
