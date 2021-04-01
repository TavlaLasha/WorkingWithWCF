﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinService.PriceServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PriceServiceReference.IPriceManagement")]
    public interface IPriceManagement {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceManagement/AddNewProductPrice", ReplyAction="http://tempuri.org/IPriceManagement/AddNewProductPriceResponse")]
        bool AddNewProductPrice(int product_id, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceManagement/AddNewProductPrice", ReplyAction="http://tempuri.org/IPriceManagement/AddNewProductPriceResponse")]
        System.Threading.Tasks.Task<bool> AddNewProductPriceAsync(int product_id, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceManagement/ChangeProductPrice", ReplyAction="http://tempuri.org/IPriceManagement/ChangeProductPriceResponse")]
        bool ChangeProductPrice(System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceManagement/ChangeProductPrice", ReplyAction="http://tempuri.org/IPriceManagement/ChangeProductPriceResponse")]
        System.Threading.Tasks.Task<bool> ChangeProductPriceAsync(System.DateTime dt);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPriceManagementChannel : WinService.PriceServiceReference.IPriceManagement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PriceManagementClient : System.ServiceModel.ClientBase<WinService.PriceServiceReference.IPriceManagement>, WinService.PriceServiceReference.IPriceManagement {
        
        public PriceManagementClient() {
        }
        
        public PriceManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PriceManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PriceManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PriceManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddNewProductPrice(int product_id, decimal price) {
            return base.Channel.AddNewProductPrice(product_id, price);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewProductPriceAsync(int product_id, decimal price) {
            return base.Channel.AddNewProductPriceAsync(product_id, price);
        }
        
        public bool ChangeProductPrice(System.DateTime dt) {
            return base.Channel.ChangeProductPrice(dt);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeProductPriceAsync(System.DateTime dt) {
            return base.Channel.ChangeProductPriceAsync(dt);
        }
    }
}