﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JMMClient.JMMImageServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JMMImageServer.IJMMServerImage")]
    public interface IJMMServerImage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJMMServerImage2/GetImage", ReplyAction="http://tempuri.org/IJMMServerImage2/GetImageResponse")]
        System.IO.Stream GetImage(string entityID, int entityType, bool thumnbnailOnly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJMMServerImage2/GetImageUsingPath", ReplyAction="http://tempuri.org/IJMMServerImage2/GetImageUsingPathResponse")]
        byte[] GetImageUsingPath(string serverImagePath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJMMServerImageChannel : JMMClient.JMMImageServer.IJMMServerImage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JMMServerImageClient : System.ServiceModel.ClientBase<JMMClient.JMMImageServer.IJMMServerImage>, JMMClient.JMMImageServer.IJMMServerImage {
        
        public JMMServerImageClient() {
        }
        
        public JMMServerImageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JMMServerImageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JMMServerImageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JMMServerImageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetImage(string entityID, int entityType, bool thumnbnailOnly) {
            return base.Channel.GetImage(entityID, entityType, thumnbnailOnly);
        }
        
        public byte[] GetImageUsingPath(string serverImagePath) {
            return base.Channel.GetImageUsingPath(serverImagePath);
        }
    }
}
