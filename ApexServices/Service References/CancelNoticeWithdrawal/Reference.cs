//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.CancelNoticeWithdrawal {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelNoticeWithdrawal", Namespace="http://IBB.Services.EngageServices")]
    [System.SerializableAttribute()]
    public partial class CancelNoticeWithdrawal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkstationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoticeReferenceField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string WorkstationID {
            get {
                return this.WorkstationIDField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkstationIDField, value) != true)) {
                    this.WorkstationIDField = value;
                    this.RaisePropertyChanged("WorkstationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string AccountNumber {
            get {
                return this.AccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountNumberField, value) != true)) {
                    this.AccountNumberField = value;
                    this.RaisePropertyChanged("AccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string NoticeReference {
            get {
                return this.NoticeReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.NoticeReferenceField, value) != true)) {
                    this.NoticeReferenceField = value;
                    this.RaisePropertyChanged("NoticeReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelNoticeWithdrawalResponse", Namespace="http://IBB.Services.EngageServices")]
    [System.SerializableAttribute()]
    public partial class CancelNoticeWithdrawalResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseDescriptionField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_Rece" +
        "iveCancelNoticeWithdrawalPortSoap")]
    public interface IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap {
        
        // CODEGEN: Generating message contract since element name CancelNoticeWithdrawal from namespace http://IBB.Services.EngageServices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveC" +
            "ancelNoticeWithdrawalPort/CancelNoticeWithdrawal", ReplyAction="*")]
        ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1 CancelNoticeWithdrawal(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveC" +
            "ancelNoticeWithdrawalPort/CancelNoticeWithdrawal", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1> CancelNoticeWithdrawalAsync(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelNoticeWithdrawalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelNoticeWithdrawal", Namespace="http://tempuri.org/", Order=0)]
        public ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequestBody Body;
        
        public CancelNoticeWithdrawalRequest() {
        }
        
        public CancelNoticeWithdrawalRequest(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.EngageServices")]
    public partial class CancelNoticeWithdrawalRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawal CancelNoticeWithdrawal;
        
        public CancelNoticeWithdrawalRequestBody() {
        }
        
        public CancelNoticeWithdrawalRequestBody(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawal CancelNoticeWithdrawal) {
            this.CancelNoticeWithdrawal = CancelNoticeWithdrawal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelNoticeWithdrawalResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelNoticeWithdrawalResponse", Namespace="http://tempuri.org/", Order=0)]
        public ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1Body Body;
        
        public CancelNoticeWithdrawalResponse1() {
        }
        
        public CancelNoticeWithdrawalResponse1(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1Body Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.EngageServices")]
    public partial class CancelNoticeWithdrawalResponse1Body {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse CancelNoticeWithdrawalResponse;
        
        public CancelNoticeWithdrawalResponse1Body() {
        }
        
        public CancelNoticeWithdrawalResponse1Body(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse CancelNoticeWithdrawalResponse) {
            this.CancelNoticeWithdrawalResponse = CancelNoticeWithdrawalResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapChannel : ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient : System.ServiceModel.ClientBase<ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap>, ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap {
        
        public BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient() {
        }
        
        public BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1 ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap.CancelNoticeWithdrawal(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest request) {
            return base.Channel.CancelNoticeWithdrawal(request);
        }
        
        public ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse CancelNoticeWithdrawal(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawal CancelNoticeWithdrawal1) {
            ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest inValue = new ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest();
            inValue.Body = new ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequestBody();
            inValue.Body.CancelNoticeWithdrawal = CancelNoticeWithdrawal1;
            ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1 retVal = ((ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap)(this)).CancelNoticeWithdrawal(inValue);
            return retVal.Body.CancelNoticeWithdrawalResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1> ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap.CancelNoticeWithdrawalAsync(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest request) {
            return base.Channel.CancelNoticeWithdrawalAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalResponse1> CancelNoticeWithdrawalAsync(ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawal CancelNoticeWithdrawal) {
            ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest inValue = new ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequest();
            inValue.Body = new ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawalRequestBody();
            inValue.Body.CancelNoticeWithdrawal = CancelNoticeWithdrawal;
            return ((ApexServices.CancelNoticeWithdrawal.IBB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoap)(this)).CancelNoticeWithdrawalAsync(inValue);
        }
    }
}
