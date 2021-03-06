//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApexServices.TransactionHistory {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://IBB.Services.CashierServices", ConfigurationName="TransactionHistory.IBB_Services_EngageServices_orcTransactionHistoryEngage_Receiv" +
        "eTransactionHistoryEngagePortSoap")]
    public interface IBB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcTransactionHis" +
            "toryEngage_ReceiveTransactionHistoryEngagePort/TransactionHistoryEngage", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="TransactionHistoryEngageResponse")]
        ApexServices.TransactionHistory.TransactionHistoryEngageResponseTransactionHistoryEngageResponse TransactionHistoryEngage([System.ServiceModel.MessageParameterAttribute(Name="TransactionHistoryEngage")] ApexServices.TransactionHistory.TransactionHistoryEngageTransactionHistoryEngage TransactionHistoryEngage1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://IBB.Services.CashierServices/IBB_Services_EngageServices_orcTransactionHis" +
            "toryEngage_ReceiveTransactionHistoryEngagePort/TransactionHistoryEngage", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="TransactionHistoryEngageResponse")]
        System.Threading.Tasks.Task<ApexServices.TransactionHistory.TransactionHistoryEngageResponseTransactionHistoryEngageResponse> TransactionHistoryEngageAsync(ApexServices.TransactionHistory.TransactionHistoryEngageTransactionHistoryEngage TransactionHistoryEngage);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IBB.Services.CashierServices")]
    public partial class TransactionHistoryEngageTransactionHistoryEngage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sourceIDField;
        
        private string workstationIDField;
        
        private string messageTypeField;
        
        private string messageIDField;
        
        private string sessionIDField;
        
        private string accountNumberField;
        
        private string fromDateField;
        
        private string toDateField;
        
        private string tranPeriodField;
        
        private string noOfTransactionsField;
        
        private string spare1Field;
        
        private string spare2Field;
        
        private string spare3Field;
        
        private string spare4Field;
        
        private string spare5Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string WorkstationID {
            get {
                return this.workstationIDField;
            }
            set {
                this.workstationIDField = value;
                this.RaisePropertyChanged("WorkstationID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string SessionID {
            get {
                return this.sessionIDField;
            }
            set {
                this.sessionIDField = value;
                this.RaisePropertyChanged("SessionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string FromDate {
            get {
                return this.fromDateField;
            }
            set {
                this.fromDateField = value;
                this.RaisePropertyChanged("FromDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ToDate {
            get {
                return this.toDateField;
            }
            set {
                this.toDateField = value;
                this.RaisePropertyChanged("ToDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string TranPeriod {
            get {
                return this.tranPeriodField;
            }
            set {
                this.tranPeriodField = value;
                this.RaisePropertyChanged("TranPeriod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string NoOfTransactions {
            get {
                return this.noOfTransactionsField;
            }
            set {
                this.noOfTransactionsField = value;
                this.RaisePropertyChanged("NoOfTransactions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IBB.Services.CashierServices")]
    public partial class TransactionHistoryEngageResponseTransactionHistoryEngageResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageIDField;
        
        private string messageTypeField;
        
        private string sourceIDField;
        
        private string responseCodeField;
        
        private string responseDescriptionField;
        
        private string availableBalanceField;
        
        private TransactionHistoryEngageResponseTransactionHistoryEngageResponseTransactionDetails[] transactionDetailsField;
        
        private TransactionHistoryEngageResponseTransactionHistoryEngageResponseMoreTransactions moreTransactionsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string AvailableBalance {
            get {
                return this.availableBalanceField;
            }
            set {
                this.availableBalanceField = value;
                this.RaisePropertyChanged("AvailableBalance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionDetails", Order=6)]
        public TransactionHistoryEngageResponseTransactionHistoryEngageResponseTransactionDetails[] TransactionDetails {
            get {
                return this.transactionDetailsField;
            }
            set {
                this.transactionDetailsField = value;
                this.RaisePropertyChanged("TransactionDetails");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public TransactionHistoryEngageResponseTransactionHistoryEngageResponseMoreTransactions MoreTransactions {
            get {
                return this.moreTransactionsField;
            }
            set {
                this.moreTransactionsField = value;
                this.RaisePropertyChanged("MoreTransactions");
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IBB.Services.CashierServices")]
    public partial class TransactionHistoryEngageResponseTransactionHistoryEngageResponseTransactionDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cCYField;
        
        private string cCYNameField;
        
        private string transactionCodeField;
        
        private string transactionNameField;
        
        private string transactionTypeField;
        
        private string transactionAmountField;
        
        private string moneyOutField;
        
        private string moneyInField;
        
        private string transactionDateField;
        
        private string transactionValueDateField;
        
        private string inputBranchField;
        
        private string postingGroupField;
        
        private string transactionReferenceField;
        
        private string narrativeLine1Field;
        
        private string narrativeLine2Field;
        
        private string narrativeLine3Field;
        
        private string narrativeLine4Field;
        
        private string runningBalanceField;
        
        private string displayOrderField;
        
        private string errorMessageField;
        
        private string warningMessageField;
        
        private string messageCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CCY {
            get {
                return this.cCYField;
            }
            set {
                this.cCYField = value;
                this.RaisePropertyChanged("CCY");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CCYName {
            get {
                return this.cCYNameField;
            }
            set {
                this.cCYNameField = value;
                this.RaisePropertyChanged("CCYName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string TransactionName {
            get {
                return this.transactionNameField;
            }
            set {
                this.transactionNameField = value;
                this.RaisePropertyChanged("TransactionName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
                this.RaisePropertyChanged("TransactionType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string TransactionAmount {
            get {
                return this.transactionAmountField;
            }
            set {
                this.transactionAmountField = value;
                this.RaisePropertyChanged("TransactionAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string MoneyOut {
            get {
                return this.moneyOutField;
            }
            set {
                this.moneyOutField = value;
                this.RaisePropertyChanged("MoneyOut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string MoneyIn {
            get {
                return this.moneyInField;
            }
            set {
                this.moneyInField = value;
                this.RaisePropertyChanged("MoneyIn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
                this.RaisePropertyChanged("TransactionDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string TransactionValueDate {
            get {
                return this.transactionValueDateField;
            }
            set {
                this.transactionValueDateField = value;
                this.RaisePropertyChanged("TransactionValueDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string InputBranch {
            get {
                return this.inputBranchField;
            }
            set {
                this.inputBranchField = value;
                this.RaisePropertyChanged("InputBranch");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string PostingGroup {
            get {
                return this.postingGroupField;
            }
            set {
                this.postingGroupField = value;
                this.RaisePropertyChanged("PostingGroup");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string TransactionReference {
            get {
                return this.transactionReferenceField;
            }
            set {
                this.transactionReferenceField = value;
                this.RaisePropertyChanged("TransactionReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string NarrativeLine1 {
            get {
                return this.narrativeLine1Field;
            }
            set {
                this.narrativeLine1Field = value;
                this.RaisePropertyChanged("NarrativeLine1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string NarrativeLine2 {
            get {
                return this.narrativeLine2Field;
            }
            set {
                this.narrativeLine2Field = value;
                this.RaisePropertyChanged("NarrativeLine2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string NarrativeLine3 {
            get {
                return this.narrativeLine3Field;
            }
            set {
                this.narrativeLine3Field = value;
                this.RaisePropertyChanged("NarrativeLine3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string NarrativeLine4 {
            get {
                return this.narrativeLine4Field;
            }
            set {
                this.narrativeLine4Field = value;
                this.RaisePropertyChanged("NarrativeLine4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string RunningBalance {
            get {
                return this.runningBalanceField;
            }
            set {
                this.runningBalanceField = value;
                this.RaisePropertyChanged("RunningBalance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string DisplayOrder {
            get {
                return this.displayOrderField;
            }
            set {
                this.displayOrderField = value;
                this.RaisePropertyChanged("DisplayOrder");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
                this.RaisePropertyChanged("ErrorMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string WarningMessage {
            get {
                return this.warningMessageField;
            }
            set {
                this.warningMessageField = value;
                this.RaisePropertyChanged("WarningMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string MessageCode {
            get {
                return this.messageCodeField;
            }
            set {
                this.messageCodeField = value;
                this.RaisePropertyChanged("MessageCode");
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://IBB.Services.CashierServices")]
    public partial class TransactionHistoryEngageResponseTransactionHistoryEngageResponseMoreTransactions : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string moreTransactionsIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MoreTransactionsIndicator {
            get {
                return this.moreTransactionsIndicatorField;
            }
            set {
                this.moreTransactionsIndicatorField = value;
                this.RaisePropertyChanged("MoreTransactionsIndicator");
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
    public interface IBB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapChannel : ApexServices.TransactionHistory.IBB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient : System.ServiceModel.ClientBase<ApexServices.TransactionHistory.IBB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoap>, ApexServices.TransactionHistory.IBB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoap {
        
        public BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient() {
        }
        
        public BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ApexServices.TransactionHistory.TransactionHistoryEngageResponseTransactionHistoryEngageResponse TransactionHistoryEngage(ApexServices.TransactionHistory.TransactionHistoryEngageTransactionHistoryEngage TransactionHistoryEngage1) {
            return base.Channel.TransactionHistoryEngage(TransactionHistoryEngage1);
        }
        
        public System.Threading.Tasks.Task<ApexServices.TransactionHistory.TransactionHistoryEngageResponseTransactionHistoryEngageResponse> TransactionHistoryEngageAsync(ApexServices.TransactionHistory.TransactionHistoryEngageTransactionHistoryEngage TransactionHistoryEngage) {
            return base.Channel.TransactionHistoryEngageAsync(TransactionHistoryEngage);
        }
    }
}
