﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.CancelTransaction {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelTransactionEngage", Namespace="http://IBB.Services.CashierServices")]
    [System.SerializableAttribute()]
    public partial class CancelTransactionEngage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalMessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EBSUserIDField;
        
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
        public string OriginalMessageID {
            get {
                return this.OriginalMessageIDField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalMessageIDField, value) != true)) {
                    this.OriginalMessageIDField = value;
                    this.RaisePropertyChanged("OriginalMessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string EBSUserID {
            get {
                return this.EBSUserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.EBSUserIDField, value) != true)) {
                    this.EBSUserIDField = value;
                    this.RaisePropertyChanged("EBSUserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelTransactionEngageResponse", Namespace="http://IBB.Services.CashierServices")]
    [System.SerializableAttribute()]
    public partial class CancelTransactionEngageResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalMessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MsgStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MsgStatusDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponseReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatedField;
        
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
        public string OriginalMessageID {
            get {
                return this.OriginalMessageIDField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalMessageIDField, value) != true)) {
                    this.OriginalMessageIDField = value;
                    this.RaisePropertyChanged("OriginalMessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string MsgStatus {
            get {
                return this.MsgStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.MsgStatusField, value) != true)) {
                    this.MsgStatusField = value;
                    this.RaisePropertyChanged("MsgStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string MsgStatusDescription {
            get {
                return this.MsgStatusDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.MsgStatusDescriptionField, value) != true)) {
                    this.MsgStatusDescriptionField = value;
                    this.RaisePropertyChanged("MsgStatusDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ResponseReference {
            get {
                return this.ResponseReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseReferenceField, value) != true)) {
                    this.ResponseReferenceField = value;
                    this.RaisePropertyChanged("ResponseReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Dated {
            get {
                return this.DatedField;
            }
            set {
                if ((object.ReferenceEquals(this.DatedField, value) != true)) {
                    this.DatedField = value;
                    this.RaisePropertyChanged("Dated");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://IBB.Services.CashierServices", ConfigurationName="CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveC" +
        "ancelTransactionRequestPortSoap")]
    public interface IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap {
        
        // CODEGEN: Generating message contract since element name CancelTransactionEngage from namespace http://IBB.Services.CashierServices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcCancelTransact" +
            "ionEngage_ReceiveCancelTransactionRequestPort/CancelTransaction", ReplyAction="*")]
        ApexServices.CancelTransaction.CancelTransactionResponse CancelTransaction(ApexServices.CancelTransaction.CancelTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcCancelTransact" +
            "ionEngage_ReceiveCancelTransactionRequestPort/CancelTransaction", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.CancelTransaction.CancelTransactionResponse> CancelTransactionAsync(ApexServices.CancelTransaction.CancelTransactionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelTransaction", Namespace="http://IBB.Services.CashierServices", Order=0)]
        public ApexServices.CancelTransaction.CancelTransactionRequestBody Body;
        
        public CancelTransactionRequest() {
        }
        
        public CancelTransactionRequest(ApexServices.CancelTransaction.CancelTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.CashierServices")]
    public partial class CancelTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.CancelTransaction.CancelTransactionEngage CancelTransactionEngage;
        
        public CancelTransactionRequestBody() {
        }
        
        public CancelTransactionRequestBody(ApexServices.CancelTransaction.CancelTransactionEngage CancelTransactionEngage) {
            this.CancelTransactionEngage = CancelTransactionEngage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelTransactionResponse", Namespace="http://IBB.Services.CashierServices", Order=0)]
        public ApexServices.CancelTransaction.CancelTransactionResponseBody Body;
        
        public CancelTransactionResponse() {
        }
        
        public CancelTransactionResponse(ApexServices.CancelTransaction.CancelTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.CashierServices")]
    public partial class CancelTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.CancelTransaction.CancelTransactionEngageResponse CancelTransactionEngageResponse;
        
        public CancelTransactionResponseBody() {
        }
        
        public CancelTransactionResponseBody(ApexServices.CancelTransaction.CancelTransactionEngageResponse CancelTransactionEngageResponse) {
            this.CancelTransactionEngageResponse = CancelTransactionEngageResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapChannel : ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient : System.ServiceModel.ClientBase<ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap>, ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap {
        
        public BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient() {
        }
        
        public BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.CancelTransaction.CancelTransactionResponse ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap.CancelTransaction(ApexServices.CancelTransaction.CancelTransactionRequest request) {
            return base.Channel.CancelTransaction(request);
        }
        
        public ApexServices.CancelTransaction.CancelTransactionEngageResponse CancelTransaction(ApexServices.CancelTransaction.CancelTransactionEngage CancelTransactionEngage) {
            ApexServices.CancelTransaction.CancelTransactionRequest inValue = new ApexServices.CancelTransaction.CancelTransactionRequest();
            inValue.Body = new ApexServices.CancelTransaction.CancelTransactionRequestBody();
            inValue.Body.CancelTransactionEngage = CancelTransactionEngage;
            ApexServices.CancelTransaction.CancelTransactionResponse retVal = ((ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap)(this)).CancelTransaction(inValue);
            return retVal.Body.CancelTransactionEngageResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.CancelTransaction.CancelTransactionResponse> ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap.CancelTransactionAsync(ApexServices.CancelTransaction.CancelTransactionRequest request) {
            return base.Channel.CancelTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.CancelTransaction.CancelTransactionResponse> CancelTransactionAsync(ApexServices.CancelTransaction.CancelTransactionEngage CancelTransactionEngage) {
            ApexServices.CancelTransaction.CancelTransactionRequest inValue = new ApexServices.CancelTransaction.CancelTransactionRequest();
            inValue.Body = new ApexServices.CancelTransaction.CancelTransactionRequestBody();
            inValue.Body.CancelTransactionEngage = CancelTransactionEngage;
            return ((ApexServices.CancelTransaction.IBB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoap)(this)).CancelTransactionAsync(inValue);
        }
    }
}