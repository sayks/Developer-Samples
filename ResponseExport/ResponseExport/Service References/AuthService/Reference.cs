﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResponseExport.AuthService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthService.IAuthenticationService")]
    public interface IAuthenticationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/IsLoggedIn", ReplyAction="http://tempuri.org/IAuthenticationService/IsLoggedInResponse")]
        Checkbox.Wcf.Services.Proxies.ServiceOperationResult<bool> IsLoggedIn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Login", ReplyAction="http://tempuri.org/IAuthenticationService/LoginResponse")]
        Checkbox.Wcf.Services.Proxies.ServiceOperationResult<string> Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Logout", ReplyAction="http://tempuri.org/IAuthenticationService/LogoutResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Checkbox.Wcf.Services.Proxies.ServiceOperationResult<bool>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Checkbox.Wcf.Services.Proxies.ServiceOperationResult<string>))]
        Checkbox.Wcf.Services.Proxies.ServiceOperationResult<object> Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        Checkbox.Wcf.Services.Proxies.ServiceOperationResult<bool> ValidateUser(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationServiceChannel : ResponseExport.AuthService.IAuthenticationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<ResponseExport.AuthService.IAuthenticationService>, ResponseExport.AuthService.IAuthenticationService {
        
        public AuthenticationServiceClient() {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Checkbox.Wcf.Services.Proxies.ServiceOperationResult<bool> IsLoggedIn() {
            return base.Channel.IsLoggedIn();
        }
        
        public Checkbox.Wcf.Services.Proxies.ServiceOperationResult<string> Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public Checkbox.Wcf.Services.Proxies.ServiceOperationResult<object> Logout() {
            return base.Channel.Logout();
        }
        
        public Checkbox.Wcf.Services.Proxies.ServiceOperationResult<bool> ValidateUser(string userName, string password) {
            return base.Channel.ValidateUser(userName, password);
        }
    }
}
