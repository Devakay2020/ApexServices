﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.ChequeDeposit {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChequeDeposit", Namespace="http://IBB.Services.CashierServices")]
    [System.SerializableAttribute()]
    public partial class ChequeDeposit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkstationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EBSUserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChequeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IssuingBankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChequeAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChequeCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChequeSerialNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepositReferenceField;
        
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
        private string OverrideUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChargeCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChargeAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoOfChequesField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string ChequeType {
            get {
                return this.ChequeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ChequeTypeField, value) != true)) {
                    this.ChequeTypeField = value;
                    this.RaisePropertyChanged("ChequeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string IssuingBank {
            get {
                return this.IssuingBankField;
            }
            set {
                if ((object.ReferenceEquals(this.IssuingBankField, value) != true)) {
                    this.IssuingBankField = value;
                    this.RaisePropertyChanged("IssuingBank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string ChequeAmount {
            get {
                return this.ChequeAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.ChequeAmountField, value) != true)) {
                    this.ChequeAmountField = value;
                    this.RaisePropertyChanged("ChequeAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string ChequeCurrency {
            get {
                return this.ChequeCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.ChequeCurrencyField, value) != true)) {
                    this.ChequeCurrencyField = value;
                    this.RaisePropertyChanged("ChequeCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string ChequeSerialNo {
            get {
                return this.ChequeSerialNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ChequeSerialNoField, value) != true)) {
                    this.ChequeSerialNoField = value;
                    this.RaisePropertyChanged("ChequeSerialNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string DepositReference {
            get {
                return this.DepositReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.DepositReferenceField, value) != true)) {
                    this.DepositReferenceField = value;
                    this.RaisePropertyChanged("DepositReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
        public string ChargeCode {
            get {
                return this.ChargeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ChargeCodeField, value) != true)) {
                    this.ChargeCodeField = value;
                    this.RaisePropertyChanged("ChargeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
        public string ChargeAmount {
            get {
                return this.ChargeAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.ChargeAmountField, value) != true)) {
                    this.ChargeAmountField = value;
                    this.RaisePropertyChanged("ChargeAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=23)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=24)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=25)]
        public string NoOfCheques {
            get {
                return this.NoOfChequesField;
            }
            set {
                if ((object.ReferenceEquals(this.NoOfChequesField, value) != true)) {
                    this.NoOfChequesField = value;
                    this.RaisePropertyChanged("NoOfCheques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=26)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=27)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=28)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=29)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=30)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChequeDepositResponse", Namespace="http://IBB.Services.CashierServices")]
    [System.SerializableAttribute()]
    public partial class ChequeDepositResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTypeField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://IBB.Services.CashierServices", ConfigurationName="ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRe" +
        "questPortSoap")]
    public interface IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap {
        
        // CODEGEN: Generating message contract since element name ChequeDeposit from namespace http://IBB.Services.CashierServices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcChequeDeposit_" +
            "ReceiveChequeDepositRequestPort/ChequeDeposit", ReplyAction="*")]
        ApexServices.ChequeDeposit.ChequeDepositResponse1 ChequeDeposit(ApexServices.ChequeDeposit.ChequeDepositRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcChequeDeposit_" +
            "ReceiveChequeDepositRequestPort/ChequeDeposit", ReplyAction="*")]
        System.Threading.Tasks.Task<ApexServices.ChequeDeposit.ChequeDepositResponse1> ChequeDepositAsync(ApexServices.ChequeDeposit.ChequeDepositRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChequeDepositRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChequeDeposit", Namespace="http://IBB.Services.CashierServices", Order=0)]
        public ApexServices.ChequeDeposit.ChequeDepositRequestBody Body;
        
        public ChequeDepositRequest() {
        }
        
        public ChequeDepositRequest(ApexServices.ChequeDeposit.ChequeDepositRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.CashierServices")]
    public partial class ChequeDepositRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.ChequeDeposit.ChequeDeposit ChequeDeposit;
        
        public ChequeDepositRequestBody() {
        }
        
        public ChequeDepositRequestBody(ApexServices.ChequeDeposit.ChequeDeposit ChequeDeposit) {
            this.ChequeDeposit = ChequeDeposit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChequeDepositResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChequeDepositResponse", Namespace="http://IBB.Services.CashierServices", Order=0)]
        public ApexServices.ChequeDeposit.ChequeDepositResponse1Body Body;
        
        public ChequeDepositResponse1() {
        }
        
        public ChequeDepositResponse1(ApexServices.ChequeDeposit.ChequeDepositResponse1Body Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://IBB.Services.CashierServices")]
    public partial class ChequeDepositResponse1Body {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ApexServices.ChequeDeposit.ChequeDepositResponse ChequeDepositResponse;
        
        public ChequeDepositResponse1Body() {
        }
        
        public ChequeDepositResponse1Body(ApexServices.ChequeDeposit.ChequeDepositResponse ChequeDepositResponse) {
            this.ChequeDepositResponse = ChequeDepositResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapChannel : ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient : System.ServiceModel.ClientBase<ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap>, ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap {
        
        public BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient() {
        }
        
        public BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApexServices.ChequeDeposit.ChequeDepositResponse1 ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap.ChequeDeposit(ApexServices.ChequeDeposit.ChequeDepositRequest request) {
            return base.Channel.ChequeDeposit(request);
        }
        
        public ApexServices.ChequeDeposit.ChequeDepositResponse ChequeDeposit(ApexServices.ChequeDeposit.ChequeDeposit ChequeDeposit1) {
            ApexServices.ChequeDeposit.ChequeDepositRequest inValue = new ApexServices.ChequeDeposit.ChequeDepositRequest();
            inValue.Body = new ApexServices.ChequeDeposit.ChequeDepositRequestBody();
            inValue.Body.ChequeDeposit = ChequeDeposit1;
            ApexServices.ChequeDeposit.ChequeDepositResponse1 retVal = ((ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap)(this)).ChequeDeposit(inValue);
            return retVal.Body.ChequeDepositResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApexServices.ChequeDeposit.ChequeDepositResponse1> ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap.ChequeDepositAsync(ApexServices.ChequeDeposit.ChequeDepositRequest request) {
            return base.Channel.ChequeDepositAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApexServices.ChequeDeposit.ChequeDepositResponse1> ChequeDepositAsync(ApexServices.ChequeDeposit.ChequeDeposit ChequeDeposit) {
            ApexServices.ChequeDeposit.ChequeDepositRequest inValue = new ApexServices.ChequeDeposit.ChequeDepositRequest();
            inValue.Body = new ApexServices.ChequeDeposit.ChequeDepositRequestBody();
            inValue.Body.ChequeDeposit = ChequeDeposit;
            return ((ApexServices.ChequeDeposit.IBB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoap)(this)).ChequeDepositAsync(inValue);
        }
    }
}
