﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvantexeVLE.AdvantexeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/AdvantexeWebService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdvantexeService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        AdvantexeVLE.AdvantexeService.CompositeType GetDataUsingDataContract(AdvantexeVLE.AdvantexeService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<AdvantexeVLE.AdvantexeService.CompositeType> GetDataUsingDataContractAsync(AdvantexeVLE.AdvantexeService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckValidLoginUser", ReplyAction="http://tempuri.org/IService1/CheckValidLoginUserResponse")]
        BusinessObject.ManageLogin CheckValidLoginUser(BusinessObject.ManageLogin Managelogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckValidLoginUser", ReplyAction="http://tempuri.org/IService1/CheckValidLoginUserResponse")]
        System.Threading.Tasks.Task<BusinessObject.ManageLogin> CheckValidLoginUserAsync(BusinessObject.ManageLogin Managelogin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AdvantexeVLE.AdvantexeService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AdvantexeVLE.AdvantexeService.IService1>, AdvantexeVLE.AdvantexeService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public AdvantexeVLE.AdvantexeService.CompositeType GetDataUsingDataContract(AdvantexeVLE.AdvantexeService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AdvantexeVLE.AdvantexeService.CompositeType> GetDataUsingDataContractAsync(AdvantexeVLE.AdvantexeService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public BusinessObject.ManageLogin CheckValidLoginUser(BusinessObject.ManageLogin Managelogin) {
            return base.Channel.CheckValidLoginUser(Managelogin);
        }
        
        public System.Threading.Tasks.Task<BusinessObject.ManageLogin> CheckValidLoginUserAsync(BusinessObject.ManageLogin Managelogin) {
            return base.Channel.CheckValidLoginUserAsync(Managelogin);
        }
    }
}