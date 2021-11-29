﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.DealDeposits {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Bank.Biztalk.DealsInformation", ConfigurationName="DealDeposits.Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDe" +
        "positPortSoap")]
    public interface Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.DealsInformation/Bank_Biztalk_DealsInformation_orcProcessDepo" +
            "sitInformation_ReceiveDepositPort/DepositInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DealDepositsResponse")]
        ApexServices.DealDeposits.DepositInformationResponseDealDepositsResponse DepositInformation(ApexServices.DealDeposits.DepositInformationDealDeposits DealDeposits);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Bank.Biztalk.DealsInformation/Bank_Biztalk_DealsInformation_orcProcessDepo" +
            "sitInformation_ReceiveDepositPort/DepositInformation", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DealDepositsResponse")]
        System.Threading.Tasks.Task<ApexServices.DealDeposits.DepositInformationResponseDealDepositsResponse> DepositInformationAsync(ApexServices.DealDeposits.DepositInformationDealDeposits DealDeposits);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationDealDeposits : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageIDField;
        
        private string messageTypeField;
        
        private string sourceIDField;
        
        private string customerField;
        
        private string accountNumberField;
        
        private string dealReferenceField;
        
        private string spare1Field;
        
        private string spare2Field;
        
        private string spare3Field;
        
        private string spare4Field;
        
        private string spare5Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MessageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
                this.RaisePropertyChanged("MessageID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string MessageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("MessageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SourceID {
            get {
                return this.sourceIDField;
            }
            set {
                this.sourceIDField = value;
                this.RaisePropertyChanged("SourceID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
                this.RaisePropertyChanged("Customer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
                this.RaisePropertyChanged("AccountNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DealReference {
            get {
                return this.dealReferenceField;
            }
            set {
                this.dealReferenceField = value;
                this.RaisePropertyChanged("DealReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Spare1 {
            get {
                return this.spare1Field;
            }
            set {
                this.spare1Field = value;
                this.RaisePropertyChanged("Spare1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Spare2 {
            get {
                return this.spare2Field;
            }
            set {
                this.spare2Field = value;
                this.RaisePropertyChanged("Spare2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Spare3 {
            get {
                return this.spare3Field;
            }
            set {
                this.spare3Field = value;
                this.RaisePropertyChanged("Spare3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Spare4 {
            get {
                return this.spare4Field;
            }
            set {
                this.spare4Field = value;
                this.RaisePropertyChanged("Spare4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Spare5 {
            get {
                return this.spare5Field;
            }
            set {
                this.spare5Field = value;
                this.RaisePropertyChanged("Spare5");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationResponseDealDepositsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageIDField;
        
        private string messageTypeField;
        
        private string sourceIDField;
        
        private string customerField;
        
        private string responseCodeField;
        
        private string responseDescriptionField;
        
        private string spare1Field;
        
        private string spare2Field;
        
        private string spare3Field;
        
        private string spare4Field;
        
        private string spare5Field;
        
        private DepositInformationResponseDealDepositsResponseAccountInformation[] accountInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MessageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
                this.RaisePropertyChanged("MessageID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string MessageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("MessageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SourceID {
            get {
                return this.sourceIDField;
            }
            set {
                this.sourceIDField = value;
                this.RaisePropertyChanged("SourceID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
                this.RaisePropertyChanged("Customer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ResponseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
                this.RaisePropertyChanged("ResponseCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ResponseDescription {
            get {
                return this.responseDescriptionField;
            }
            set {
                this.responseDescriptionField = value;
                this.RaisePropertyChanged("ResponseDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Spare1 {
            get {
                return this.spare1Field;
            }
            set {
                this.spare1Field = value;
                this.RaisePropertyChanged("Spare1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Spare2 {
            get {
                return this.spare2Field;
            }
            set {
                this.spare2Field = value;
                this.RaisePropertyChanged("Spare2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Spare3 {
            get {
                return this.spare3Field;
            }
            set {
                this.spare3Field = value;
                this.RaisePropertyChanged("Spare3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Spare4 {
            get {
                return this.spare4Field;
            }
            set {
                this.spare4Field = value;
                this.RaisePropertyChanged("Spare4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Spare5 {
            get {
                return this.spare5Field;
            }
            set {
                this.spare5Field = value;
                this.RaisePropertyChanged("Spare5");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccountInformation", Order=11)]
        public DepositInformationResponseDealDepositsResponseAccountInformation[] AccountInformation {
            get {
                return this.accountInformationField;
            }
            set {
                this.accountInformationField = value;
                this.RaisePropertyChanged("AccountInformation");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationResponseDealDepositsResponseAccountInformation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string accountNumberField;
        
        private DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformation[] depositsInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
                this.RaisePropertyChanged("AccountNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DepositsInformation", Order=1)]
        public DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformation[] DepositsInformation {
            get {
                return this.depositsInformationField;
            }
            set {
                this.depositsInformationField = value;
                this.RaisePropertyChanged("DepositsInformation");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dealBranchField;
        
        private string dealTypeField;
        
        private string dealRefField;
        
        private string dealTypeDescField;
        
        private string dealStartDateField;
        
        private string dealMaturityDateField;
        
        private string dealCurrencyField;
        
        private string dealOriginalAmtField;
        
        private string dealCurrentAmtField;
        
        private string maturityAmountField;
        
        private string dealPeriodCodeField;
        
        private string dealPeriodCodeDescField;
        
        private string dealProfitRateField;
        
        private string aERField;
        
        private string dealNextProfitDateField;
        
        private string dealNextProfitAmountField;
        
        private string payProfitSCField;
        
        private string payProfitACField;
        
        private string payMaturitySCField;
        
        private string payMaturityACField;
        
        private string profitCapitalisedField;
        
        private string spare1Field;
        
        private string spare2Field;
        
        private string spare3Field;
        
        private string spare4Field;
        
        private string spare5Field;
        
        private DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostings[] dealPostingsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DealBranch {
            get {
                return this.dealBranchField;
            }
            set {
                this.dealBranchField = value;
                this.RaisePropertyChanged("DealBranch");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DealType {
            get {
                return this.dealTypeField;
            }
            set {
                this.dealTypeField = value;
                this.RaisePropertyChanged("DealType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string DealRef {
            get {
                return this.dealRefField;
            }
            set {
                this.dealRefField = value;
                this.RaisePropertyChanged("DealRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DealTypeDesc {
            get {
                return this.dealTypeDescField;
            }
            set {
                this.dealTypeDescField = value;
                this.RaisePropertyChanged("DealTypeDesc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string DealStartDate {
            get {
                return this.dealStartDateField;
            }
            set {
                this.dealStartDateField = value;
                this.RaisePropertyChanged("DealStartDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DealMaturityDate {
            get {
                return this.dealMaturityDateField;
            }
            set {
                this.dealMaturityDateField = value;
                this.RaisePropertyChanged("DealMaturityDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string DealCurrency {
            get {
                return this.dealCurrencyField;
            }
            set {
                this.dealCurrencyField = value;
                this.RaisePropertyChanged("DealCurrency");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string DealOriginalAmt {
            get {
                return this.dealOriginalAmtField;
            }
            set {
                this.dealOriginalAmtField = value;
                this.RaisePropertyChanged("DealOriginalAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string DealCurrentAmt {
            get {
                return this.dealCurrentAmtField;
            }
            set {
                this.dealCurrentAmtField = value;
                this.RaisePropertyChanged("DealCurrentAmt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string MaturityAmount {
            get {
                return this.maturityAmountField;
            }
            set {
                this.maturityAmountField = value;
                this.RaisePropertyChanged("MaturityAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string DealPeriodCode {
            get {
                return this.dealPeriodCodeField;
            }
            set {
                this.dealPeriodCodeField = value;
                this.RaisePropertyChanged("DealPeriodCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string DealPeriodCodeDesc {
            get {
                return this.dealPeriodCodeDescField;
            }
            set {
                this.dealPeriodCodeDescField = value;
                this.RaisePropertyChanged("DealPeriodCodeDesc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string DealProfitRate {
            get {
                return this.dealProfitRateField;
            }
            set {
                this.dealProfitRateField = value;
                this.RaisePropertyChanged("DealProfitRate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string AER {
            get {
                return this.aERField;
            }
            set {
                this.aERField = value;
                this.RaisePropertyChanged("AER");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string DealNextProfitDate {
            get {
                return this.dealNextProfitDateField;
            }
            set {
                this.dealNextProfitDateField = value;
                this.RaisePropertyChanged("DealNextProfitDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string DealNextProfitAmount {
            get {
                return this.dealNextProfitAmountField;
            }
            set {
                this.dealNextProfitAmountField = value;
                this.RaisePropertyChanged("DealNextProfitAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string PayProfitSC {
            get {
                return this.payProfitSCField;
            }
            set {
                this.payProfitSCField = value;
                this.RaisePropertyChanged("PayProfitSC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string PayProfitAC {
            get {
                return this.payProfitACField;
            }
            set {
                this.payProfitACField = value;
                this.RaisePropertyChanged("PayProfitAC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string PayMaturitySC {
            get {
                return this.payMaturitySCField;
            }
            set {
                this.payMaturitySCField = value;
                this.RaisePropertyChanged("PayMaturitySC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string PayMaturityAC {
            get {
                return this.payMaturityACField;
            }
            set {
                this.payMaturityACField = value;
                this.RaisePropertyChanged("PayMaturityAC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string ProfitCapitalised {
            get {
                return this.profitCapitalisedField;
            }
            set {
                this.profitCapitalisedField = value;
                this.RaisePropertyChanged("ProfitCapitalised");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string Spare1 {
            get {
                return this.spare1Field;
            }
            set {
                this.spare1Field = value;
                this.RaisePropertyChanged("Spare1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string Spare2 {
            get {
                return this.spare2Field;
            }
            set {
                this.spare2Field = value;
                this.RaisePropertyChanged("Spare2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string Spare3 {
            get {
                return this.spare3Field;
            }
            set {
                this.spare3Field = value;
                this.RaisePropertyChanged("Spare3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string Spare4 {
            get {
                return this.spare4Field;
            }
            set {
                this.spare4Field = value;
                this.RaisePropertyChanged("Spare4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string Spare5 {
            get {
                return this.spare5Field;
            }
            set {
                this.spare5Field = value;
                this.RaisePropertyChanged("Spare5");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DealPostings", Order=26)]
        public DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostings[] DealPostings {
            get {
                return this.dealPostingsField;
            }
            set {
                this.dealPostingsField = value;
                this.RaisePropertyChanged("DealPostings");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostings : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dealBranchField;
        
        private string dealTypeField;
        
        private string dealRefField;
        
        private DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostingsDealPostingItem[] dealPostingItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DealBranch {
            get {
                return this.dealBranchField;
            }
            set {
                this.dealBranchField = value;
                this.RaisePropertyChanged("DealBranch");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DealType {
            get {
                return this.dealTypeField;
            }
            set {
                this.dealTypeField = value;
                this.RaisePropertyChanged("DealType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string DealRef {
            get {
                return this.dealRefField;
            }
            set {
                this.dealRefField = value;
                this.RaisePropertyChanged("DealRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DealPostingItem", Order=3)]
        public DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostingsDealPostingItem[] DealPostingItem {
            get {
                return this.dealPostingItemField;
            }
            set {
                this.dealPostingItemField = value;
                this.RaisePropertyChanged("DealPostingItem");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Bank.Biztalk.DealsInformation")]
    public partial class DepositInformationResponseDealDepositsResponseAccountInformationDepositsInformationDealPostingsDealPostingItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tranDateField;
        
        private string tranVDateField;
        
        private string acctNoField;
        
        private string acctShortNameField;
        
        private string postingCcyField;
        
        private string transactionCodeField;
        
        private string tranNameField;
        
        private string tranAmaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
                this.RaisePropertyChanged("TranDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string TranVDate {
            get {
                return this.tranVDateField;
            }
            set {
                this.tranVDateField = value;
                this.RaisePropertyChanged("TranVDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AcctNo {
            get {
                return this.acctNoField;
            }
            set {
                this.acctNoField = value;
                this.RaisePropertyChanged("AcctNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AcctShortName {
            get {
                return this.acctShortNameField;
            }
            set {
                this.acctShortNameField = value;
                this.RaisePropertyChanged("AcctShortName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string PostingCcy {
            get {
                return this.postingCcyField;
            }
            set {
                this.postingCcyField = value;
                this.RaisePropertyChanged("PostingCcy");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string TransactionCode {
            get {
                return this.transactionCodeField;
            }
            set {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string TranName {
            get {
                return this.tranNameField;
            }
            set {
                this.tranNameField = value;
                this.RaisePropertyChanged("TranName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string TranAma {
            get {
                return this.tranAmaField;
            }
            set {
                this.tranAmaField = value;
                this.RaisePropertyChanged("TranAma");
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
    public interface Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapChannel : ApexServices.DealDeposits.Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient : System.ServiceModel.ClientBase<ApexServices.DealDeposits.Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoap>, ApexServices.DealDeposits.Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoap {
        
        public Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient() {
        }
        
        public Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ApexServices.DealDeposits.DepositInformationResponseDealDepositsResponse DepositInformation(ApexServices.DealDeposits.DepositInformationDealDeposits DealDeposits) {
            return base.Channel.DepositInformation(DealDeposits);
        }
        
        public System.Threading.Tasks.Task<ApexServices.DealDeposits.DepositInformationResponseDealDepositsResponse> DepositInformationAsync(ApexServices.DealDeposits.DepositInformationDealDeposits DealDeposits) {
            return base.Channel.DepositInformationAsync(DealDeposits);
        }
    }
}