﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SM.Web.DataServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataServiceProxy.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetTableColumnsType", ReplyAction="http://tempuri.org/IDataService/GetTableColumnsTypeResponse")]
        System.Data.DataTable GetTableColumnsType(string tableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetTableColumnsType", ReplyAction="http://tempuri.org/IDataService/GetTableColumnsTypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetTableColumnsTypeAsync(string tableName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : SM.Web.DataServiceProxy.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<SM.Web.DataServiceProxy.IDataService>, SM.Web.DataServiceProxy.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetTableColumnsType(string tableName) {
            return base.Channel.GetTableColumnsType(tableName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetTableColumnsTypeAsync(string tableName) {
            return base.Channel.GetTableColumnsTypeAsync(tableName);
        }
    }
}
