﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caculator.CaculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CaculatorService.ICaculatorService")]
    public interface ICaculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaculatorService/Plus", ReplyAction="http://tempuri.org/ICaculatorService/PlusResponse")]
        int Plus(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaculatorService/Subtract", ReplyAction="http://tempuri.org/ICaculatorService/SubtractResponse")]
        int Subtract(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaculatorService/GetResult", ReplyAction="http://tempuri.org/ICaculatorService/GetResultResponse")]
        int GetResult();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaculatorServiceChannel : Caculator.CaculatorService.ICaculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaculatorServiceClient : System.ServiceModel.ClientBase<Caculator.CaculatorService.ICaculatorService>, Caculator.CaculatorService.ICaculatorService {
        
        public CaculatorServiceClient() {
        }
        
        public CaculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Plus(int a, int b) {
            return base.Channel.Plus(a, b);
        }
        
        public int Subtract(int a, int b) {
            return base.Channel.Subtract(a, b);
        }
        
        public int GetResult() {
            return base.Channel.GetResult();
        }
    }
}
