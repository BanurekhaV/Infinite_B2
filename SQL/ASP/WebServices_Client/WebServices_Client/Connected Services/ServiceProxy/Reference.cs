﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServices_Client.ServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceProxy.CalculatorServiceSoap")]
    public interface CalculatorServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServices_Client.ServiceProxy.HelloWorldResponse HelloWorld(WebServices_Client.ServiceProxy.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.HelloWorldResponse> HelloWorldAsync(WebServices_Client.ServiceProxy.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add2Nos", ReplyAction="*")]
        int add2Nos(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add2Nos", ReplyAction="*")]
        System.Threading.Tasks.Task<int> add2NosAsync(int x, int y);
        
        // CODEGEN: Generating message contract since element name s from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        WebServices_Client.ServiceProxy.MessageResponse Message(WebServices_Client.ServiceProxy.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.MessageResponse> MessageAsync(WebServices_Client.ServiceProxy.MessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServices_Client.ServiceProxy.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServices_Client.ServiceProxy.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServices_Client.ServiceProxy.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServices_Client.ServiceProxy.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Message", Namespace="http://tempuri.org/", Order=0)]
        public WebServices_Client.ServiceProxy.MessageRequestBody Body;
        
        public MessageRequest() {
        }
        
        public MessageRequest(WebServices_Client.ServiceProxy.MessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public MessageRequestBody() {
        }
        
        public MessageRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServices_Client.ServiceProxy.MessageResponseBody Body;
        
        public MessageResponse() {
        }
        
        public MessageResponse(WebServices_Client.ServiceProxy.MessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MessageResult;
        
        public MessageResponseBody() {
        }
        
        public MessageResponseBody(string MessageResult) {
            this.MessageResult = MessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorServiceSoapChannel : WebServices_Client.ServiceProxy.CalculatorServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceSoapClient : System.ServiceModel.ClientBase<WebServices_Client.ServiceProxy.CalculatorServiceSoap>, WebServices_Client.ServiceProxy.CalculatorServiceSoap {
        
        public CalculatorServiceSoapClient() {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServices_Client.ServiceProxy.HelloWorldResponse WebServices_Client.ServiceProxy.CalculatorServiceSoap.HelloWorld(WebServices_Client.ServiceProxy.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServices_Client.ServiceProxy.HelloWorldRequest inValue = new WebServices_Client.ServiceProxy.HelloWorldRequest();
            inValue.Body = new WebServices_Client.ServiceProxy.HelloWorldRequestBody();
            WebServices_Client.ServiceProxy.HelloWorldResponse retVal = ((WebServices_Client.ServiceProxy.CalculatorServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.HelloWorldResponse> WebServices_Client.ServiceProxy.CalculatorServiceSoap.HelloWorldAsync(WebServices_Client.ServiceProxy.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.HelloWorldResponse> HelloWorldAsync() {
            WebServices_Client.ServiceProxy.HelloWorldRequest inValue = new WebServices_Client.ServiceProxy.HelloWorldRequest();
            inValue.Body = new WebServices_Client.ServiceProxy.HelloWorldRequestBody();
            return ((WebServices_Client.ServiceProxy.CalculatorServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int add2Nos(int x, int y) {
            return base.Channel.add2Nos(x, y);
        }
        
        public System.Threading.Tasks.Task<int> add2NosAsync(int x, int y) {
            return base.Channel.add2NosAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServices_Client.ServiceProxy.MessageResponse WebServices_Client.ServiceProxy.CalculatorServiceSoap.Message(WebServices_Client.ServiceProxy.MessageRequest request) {
            return base.Channel.Message(request);
        }
        
        public string Message(string s) {
            WebServices_Client.ServiceProxy.MessageRequest inValue = new WebServices_Client.ServiceProxy.MessageRequest();
            inValue.Body = new WebServices_Client.ServiceProxy.MessageRequestBody();
            inValue.Body.s = s;
            WebServices_Client.ServiceProxy.MessageResponse retVal = ((WebServices_Client.ServiceProxy.CalculatorServiceSoap)(this)).Message(inValue);
            return retVal.Body.MessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.MessageResponse> WebServices_Client.ServiceProxy.CalculatorServiceSoap.MessageAsync(WebServices_Client.ServiceProxy.MessageRequest request) {
            return base.Channel.MessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServices_Client.ServiceProxy.MessageResponse> MessageAsync(string s) {
            WebServices_Client.ServiceProxy.MessageRequest inValue = new WebServices_Client.ServiceProxy.MessageRequest();
            inValue.Body = new WebServices_Client.ServiceProxy.MessageRequestBody();
            inValue.Body.s = s;
            return ((WebServices_Client.ServiceProxy.CalculatorServiceSoap)(this)).MessageAsync(inValue);
        }
    }
}
