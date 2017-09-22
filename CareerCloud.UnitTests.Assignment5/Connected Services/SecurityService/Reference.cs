﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloud.UnitTests.Assignment5.SecurityService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SecurityService.ISecurity")]
    public interface ISecurity {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginResponse")]
        void AddSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginResponse")]
        System.Threading.Tasks.Task AddSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginResponse")]
        CareerCloud.Pocos.SecurityLoginPoco[] GetAllSecurityLogin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginPoco[]> GetAllSecurityLoginAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginResponse")]
        CareerCloud.Pocos.SecurityLoginPoco GetSingleSecurityLogin(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginPoco> GetSingleSecurityLoginAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginResponse")]
        void RemoveSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginResponse")]
        System.Threading.Tasks.Task RemoveSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginResponse")]
        void UpdateSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLogin", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginResponse")]
        System.Threading.Tasks.Task UpdateSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginsLogResponse")]
        void AddSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginsLogResponse")]
        System.Threading.Tasks.Task AddSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginsLogResponse")]
        CareerCloud.Pocos.SecurityLoginsLogPoco[] GetAllSecurityLoginsLog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginsLogResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsLogPoco[]> GetAllSecurityLoginsLogAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginsLogResponse")]
        CareerCloud.Pocos.SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginsLogResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsLogPoco> GetSingleSecurityLoginsLogAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginsLogResponse")]
        void RemoveSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginsLogResponse")]
        System.Threading.Tasks.Task RemoveSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginsLogResponse")]
        void UpdateSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLoginsLog", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginsLogResponse")]
        System.Threading.Tasks.Task UpdateSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginsRoleResponse")]
        void AddSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/AddSecurityLoginsRoleResponse")]
        System.Threading.Tasks.Task AddSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginsRoleResponse")]
        CareerCloud.Pocos.SecurityLoginsRolePoco[] GetAllSecurityLoginsRole();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityLoginsRoleResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsRolePoco[]> GetAllSecurityLoginsRoleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginsRoleResponse")]
        CareerCloud.Pocos.SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityLoginsRoleResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsRolePoco> GetSingleSecurityLoginsRoleAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginsRoleResponse")]
        void RemoveSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityLoginsRoleResponse")]
        System.Threading.Tasks.Task RemoveSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginsRoleResponse")]
        void UpdateSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityLoginsRole", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityLoginsRoleResponse")]
        System.Threading.Tasks.Task UpdateSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityRole", ReplyAction="http://tempuri.org/ISecurity/AddSecurityRoleResponse")]
        void AddSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/AddSecurityRole", ReplyAction="http://tempuri.org/ISecurity/AddSecurityRoleResponse")]
        System.Threading.Tasks.Task AddSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityRole", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityRoleResponse")]
        CareerCloud.Pocos.SecurityRolePoco[] GetAllSecurityRole();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetAllSecurityRole", ReplyAction="http://tempuri.org/ISecurity/GetAllSecurityRoleResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityRolePoco[]> GetAllSecurityRoleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityRole", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityRoleResponse")]
        CareerCloud.Pocos.SecurityRolePoco GetSingleSecurityRole(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/GetSingleSecurityRole", ReplyAction="http://tempuri.org/ISecurity/GetSingleSecurityRoleResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityRolePoco> GetSingleSecurityRoleAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityRole", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityRoleResponse")]
        void RemoveSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/RemoveSecurityRole", ReplyAction="http://tempuri.org/ISecurity/RemoveSecurityRoleResponse")]
        System.Threading.Tasks.Task RemoveSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityRole", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityRoleResponse")]
        void UpdateSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurity/UpdateSecurityRole", ReplyAction="http://tempuri.org/ISecurity/UpdateSecurityRoleResponse")]
        System.Threading.Tasks.Task UpdateSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISecurityChannel : CareerCloud.UnitTests.Assignment5.SecurityService.ISecurity, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecurityClient : System.ServiceModel.ClientBase<CareerCloud.UnitTests.Assignment5.SecurityService.ISecurity>, CareerCloud.UnitTests.Assignment5.SecurityService.ISecurity {
        
        public SecurityClient() {
        }
        
        public SecurityClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecurityClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            base.Channel.AddSecurityLogin(pocos);
        }
        
        public System.Threading.Tasks.Task AddSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            return base.Channel.AddSecurityLoginAsync(pocos);
        }
        
        public CareerCloud.Pocos.SecurityLoginPoco[] GetAllSecurityLogin() {
            return base.Channel.GetAllSecurityLogin();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginPoco[]> GetAllSecurityLoginAsync() {
            return base.Channel.GetAllSecurityLoginAsync();
        }
        
        public CareerCloud.Pocos.SecurityLoginPoco GetSingleSecurityLogin(string id) {
            return base.Channel.GetSingleSecurityLogin(id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginPoco> GetSingleSecurityLoginAsync(string id) {
            return base.Channel.GetSingleSecurityLoginAsync(id);
        }
        
        public void RemoveSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            base.Channel.RemoveSecurityLogin(pocos);
        }
        
        public System.Threading.Tasks.Task RemoveSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            return base.Channel.RemoveSecurityLoginAsync(pocos);
        }
        
        public void UpdateSecurityLogin(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            base.Channel.UpdateSecurityLogin(pocos);
        }
        
        public System.Threading.Tasks.Task UpdateSecurityLoginAsync(CareerCloud.Pocos.SecurityLoginPoco[] pocos) {
            return base.Channel.UpdateSecurityLoginAsync(pocos);
        }
        
        public void AddSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            base.Channel.AddSecurityLoginsLog(pocos);
        }
        
        public System.Threading.Tasks.Task AddSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            return base.Channel.AddSecurityLoginsLogAsync(pocos);
        }
        
        public CareerCloud.Pocos.SecurityLoginsLogPoco[] GetAllSecurityLoginsLog() {
            return base.Channel.GetAllSecurityLoginsLog();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsLogPoco[]> GetAllSecurityLoginsLogAsync() {
            return base.Channel.GetAllSecurityLoginsLogAsync();
        }
        
        public CareerCloud.Pocos.SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id) {
            return base.Channel.GetSingleSecurityLoginsLog(id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsLogPoco> GetSingleSecurityLoginsLogAsync(string id) {
            return base.Channel.GetSingleSecurityLoginsLogAsync(id);
        }
        
        public void RemoveSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            base.Channel.RemoveSecurityLoginsLog(pocos);
        }
        
        public System.Threading.Tasks.Task RemoveSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            return base.Channel.RemoveSecurityLoginsLogAsync(pocos);
        }
        
        public void UpdateSecurityLoginsLog(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            base.Channel.UpdateSecurityLoginsLog(pocos);
        }
        
        public System.Threading.Tasks.Task UpdateSecurityLoginsLogAsync(CareerCloud.Pocos.SecurityLoginsLogPoco[] pocos) {
            return base.Channel.UpdateSecurityLoginsLogAsync(pocos);
        }
        
        public void AddSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            base.Channel.AddSecurityLoginsRole(pocos);
        }
        
        public System.Threading.Tasks.Task AddSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            return base.Channel.AddSecurityLoginsRoleAsync(pocos);
        }
        
        public CareerCloud.Pocos.SecurityLoginsRolePoco[] GetAllSecurityLoginsRole() {
            return base.Channel.GetAllSecurityLoginsRole();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsRolePoco[]> GetAllSecurityLoginsRoleAsync() {
            return base.Channel.GetAllSecurityLoginsRoleAsync();
        }
        
        public CareerCloud.Pocos.SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id) {
            return base.Channel.GetSingleSecurityLoginsRole(id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityLoginsRolePoco> GetSingleSecurityLoginsRoleAsync(string id) {
            return base.Channel.GetSingleSecurityLoginsRoleAsync(id);
        }
        
        public void RemoveSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            base.Channel.RemoveSecurityLoginsRole(pocos);
        }
        
        public System.Threading.Tasks.Task RemoveSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            return base.Channel.RemoveSecurityLoginsRoleAsync(pocos);
        }
        
        public void UpdateSecurityLoginsRole(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            base.Channel.UpdateSecurityLoginsRole(pocos);
        }
        
        public System.Threading.Tasks.Task UpdateSecurityLoginsRoleAsync(CareerCloud.Pocos.SecurityLoginsRolePoco[] pocos) {
            return base.Channel.UpdateSecurityLoginsRoleAsync(pocos);
        }
        
        public void AddSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            base.Channel.AddSecurityRole(pocos);
        }
        
        public System.Threading.Tasks.Task AddSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            return base.Channel.AddSecurityRoleAsync(pocos);
        }
        
        public CareerCloud.Pocos.SecurityRolePoco[] GetAllSecurityRole() {
            return base.Channel.GetAllSecurityRole();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityRolePoco[]> GetAllSecurityRoleAsync() {
            return base.Channel.GetAllSecurityRoleAsync();
        }
        
        public CareerCloud.Pocos.SecurityRolePoco GetSingleSecurityRole(string id) {
            return base.Channel.GetSingleSecurityRole(id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SecurityRolePoco> GetSingleSecurityRoleAsync(string id) {
            return base.Channel.GetSingleSecurityRoleAsync(id);
        }
        
        public void RemoveSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            base.Channel.RemoveSecurityRole(pocos);
        }
        
        public System.Threading.Tasks.Task RemoveSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            return base.Channel.RemoveSecurityRoleAsync(pocos);
        }
        
        public void UpdateSecurityRole(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            base.Channel.UpdateSecurityRole(pocos);
        }
        
        public System.Threading.Tasks.Task UpdateSecurityRoleAsync(CareerCloud.Pocos.SecurityRolePoco[] pocos) {
            return base.Channel.UpdateSecurityRoleAsync(pocos);
        }
    }
}
