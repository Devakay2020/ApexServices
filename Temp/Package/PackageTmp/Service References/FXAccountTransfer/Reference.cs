﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.FXAccountTransfer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FXAccountTransferEngage", Namespace="http://Bank.Biztalk.FXServices")]
    [System.SerializableAttribute()]
    public partial class FXAccountTransferEngage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExchangeRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionNarrativeLine1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionNarrativeLine2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionNarrativeLine3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionNarrativeLine4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitSystemParameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditSystemParameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EBSUserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OverrideUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditAccountNumberField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DebitCurrency {
            get {
                return this.DebitCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.DebitCurrencyField, value) != true)) {
                    this.DebitCurrencyField = value;
                    this.RaisePropertyChanged("DebitCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string CreditCurrency {
            get {
                return this.CreditCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCurrencyField, value) != true)) {
                    this.CreditCurrencyField = value;
                    this.RaisePropertyChanged("CreditCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string DebitAmount {
            get {
                return this.DebitAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.DebitAmountField, value) != true)) {
                    this.DebitAmountField = value;
                    this.RaisePropertyChanged("DebitAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CreditAmount {
            get {
                return this.CreditAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditAmountField, value) != true)) {
                    this.CreditAmountField = value;
                    this.RaisePropertyChanged("CreditAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ExchangeRate {
            get {
                return this.ExchangeRateField;
            }
            set {
                if ((object.ReferenceEquals(this.ExchangeRateField, value) != true)) {
                    this.ExchangeRateField = value;
                    this.RaisePropertyChanged("ExchangeRate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string ValueDate {
            get {
                return this.ValueDateField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueDateField, value) != true)) {
                    this.ValueDateField = value;
                    this.RaisePropertyChanged("ValueDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string TransactionReference {
            get {
                return this.TransactionReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionReferenceField, value) != true)) {
                    this.TransactionReferenceField = value;
                    this.RaisePropertyChanged("TransactionReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string TransactionNarrativeLine1 {
            get {
                return this.TransactionNarrativeLine1Field;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionNarrativeLine1Field, value) != true)) {
                    this.TransactionNarrativeLine1Field = value;
                    this.RaisePropertyChanged("TransactionNarrativeLine1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string TransactionNarrativeLine2 {
            get {
                return this.TransactionNarrativeLine2Field;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionNarrativeLine2Field, value) != true)) {
                    this.TransactionNarrativeLine2Field = value;
                    this.RaisePropertyChanged("TransactionNarrativeLine2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string TransactionNarrativeLine3 {
            get {
                return this.TransactionNarrativeLine3Field;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionNarrativeLine3Field, value) != true)) {
                    this.TransactionNarrativeLine3Field = value;
                    this.RaisePropertyChanged("TransactionNarrativeLine3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string TransactionNarrativeLine4 {
            get {
                return this.TransactionNarrativeLine4Field;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionNarrativeLine4Field, value) != true)) {
                    this.TransactionNarrativeLine4Field = value;
                    this.RaisePropertyChanged("TransactionNarrativeLine4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string DebitSystemParameter {
            get {
                return this.DebitSystemParameterField;
            }
            set {
                if ((object.ReferenceEquals(this.DebitSystemParameterField, value) != true)) {
                    this.DebitSystemParameterField = value;
                    this.RaisePropertyChanged("DebitSystemParameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string CreditSystemParameter {
            get {
                return this.CreditSystemParameterField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditSystemParameterField, value) != true)) {
                    this.CreditSystemParameterField = value;
                    this.RaisePropertyChanged("CreditSystemParameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string OverrideUser {
            get {
                return this.OverrideUserField;
            }
            set {
                if ((object.ReferenceEquals(this.OverrideUserField, value) != true)) {
                    this.OverrideUserField = value;
                    this.RaisePropertyChanged("OverrideUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string DebitAccountNumber {
            get {
                return this.DebitAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.DebitAccountNumberField, value) != true)) {
                    this.DebitAccountNumberField = value;
                    this.RaisePropertyChanged("DebitAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string CreditAccountNumber {
            get {
                return this.CreditAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditAccountNumberField, value) != true)) {
                    this.CreditAccountNumberField = value;
                    this.RaisePropertyChanged("CreditAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=23)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=24)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FXAccountTransferResponse", Namespace="http://Bank.Biztalk.FXServices")]
    [System.SerializableAttribute()]
    public partial class FXAccountTransferResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
        private string ResponseTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionReferenceField;
        
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
        public string ResponseText {
            get {
                return this.ResponseTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseTextField, value) != true)) {
                    this.ResponseTextField = value;
                    this.RaisePropertyChanged("ResponseText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string TransactionReference {
            get {
                return this.TransactionReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionReferenceField, value) != true)) {
                    this.TransactionReferenceField = value;
                    this.RaisePropertyChanged("TransactionReference");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Bank.Biztalk.FXServices", ConfigurationName="FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAc" +
        "countTransferPortSoap")]
    public interface Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap {
        
        // CODEGEN: Generating message contract since element name FXAccountTransferEngage from namespace http://Bank.Biztalk.FXServices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.FXServices/Bank_Biztalk_FXServices_orcProcessFXAccountTransfe" +
            "r_ReceiveFXAccountTransferPort/FXAccountTransfer", ReplyAction="*")]
        ApexServices.FXAccountTransfer.FXAccountTransferResponse1 FXAccountTransfer(ApexServices.FXAccountTransfer.FXAccountTransferRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.FXServices/Bank_Biztalk_FXServices_orcProcessFXAccountTransfe" +
            "r_ReceiveFXAccountTransferPort/FXAccountTransfer", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.FXAccountTransfer.FXAccountTransferResponse1> FXAccountTransferAsync(ApexServices.FXAccountTransfer.FXAccountTransferRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FXAccountTransferRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FXAccountTransfer", Namespace="http://Bank.Biztalk.FXServices", Order=0)]
        public ApexServices.FXAccountTransfer.FXAccountTransferRequestBody Body;
        
        public FXAccountTransferRequest() {
        }
        
        public FXAccountTransferRequest(ApexServices.FXAccountTransfer.FXAccountTransferRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Bank.Biztalk.FXServices")]
    public partial class FXAccountTransferRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.FXAccountTransfer.FXAccountTransferEngage FXAccountTransferEngage;
        
        public FXAccountTransferRequestBody() {
        }
        
        public FXAccountTransferRequestBody(ApexServices.FXAccountTransfer.FXAccountTransferEngage FXAccountTransferEngage) {
            this.FXAccountTransferEngage = FXAccountTransferEngage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FXAccountTransferResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FXAccountTransferResponse", Namespace="http://Bank.Biztalk.FXServices", Order=0)]
        public ApexServices.FXAccountTransfer.FXAccountTransferResponse1Body Body;
        
        public FXAccountTransferResponse1() {
        }
        
        public FXAccountTransferResponse1(ApexServices.FXAccountTransfer.FXAccountTransferResponse1Body Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Bank.Biztalk.FXServices")]
    public partial class FXAccountTransferResponse1Body {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.FXAccountTransfer.FXAccountTransferResponse FXAccountTransferResponse;
        
        public FXAccountTransferResponse1Body() {
        }
        
        public FXAccountTransferResponse1Body(ApexServices.FXAccountTransfer.FXAccountTransferResponse FXAccountTransferResponse) {
            this.FXAccountTransferResponse = FXAccountTransferResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapChannel : ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient : System.ServiceModel.ClientBase<ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap>, ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap {
        
        public Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient() {
        }
        
        public Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.FXAccountTransfer.FXAccountTransferResponse1 ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap.FXAccountTransfer(ApexServices.FXAccountTransfer.FXAccountTransferRequest request) {
            return base.Channel.FXAccountTransfer(request);
        }
        
        public ApexServices.FXAccountTransfer.FXAccountTransferResponse FXAccountTransfer(ApexServices.FXAccountTransfer.FXAccountTransferEngage FXAccountTransferEngage) {
            ApexServices.FXAccountTransfer.FXAccountTransferRequest inValue = new ApexServices.FXAccountTransfer.FXAccountTransferRequest();
            inValue.Body = new ApexServices.FXAccountTransfer.FXAccountTransferRequestBody();
            inValue.Body.FXAccountTransferEngage = FXAccountTransferEngage;
            ApexServices.FXAccountTransfer.FXAccountTransferResponse1 retVal = ((ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap)(this)).FXAccountTransfer(inValue);
            return retVal.Body.FXAccountTransferResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.FXAccountTransfer.FXAccountTransferResponse1> ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap.FXAccountTransferAsync(ApexServices.FXAccountTransfer.FXAccountTransferRequest request) {
            return base.Channel.FXAccountTransferAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.FXAccountTransfer.FXAccountTransferResponse1> FXAccountTransferAsync(ApexServices.FXAccountTransfer.FXAccountTransferEngage FXAccountTransferEngage) {
            ApexServices.FXAccountTransfer.FXAccountTransferRequest inValue = new ApexServices.FXAccountTransfer.FXAccountTransferRequest();
            inValue.Body = new ApexServices.FXAccountTransfer.FXAccountTransferRequestBody();
            inValue.Body.FXAccountTransferEngage = FXAccountTransferEngage;
            return ((ApexServices.FXAccountTransfer.Bank_Biztalk_FXServices_orcProcessFXAccountTransfer_ReceiveFXAccountTransferPortSoap)(this)).FXAccountTransferAsync(inValue);
        }
    }
}