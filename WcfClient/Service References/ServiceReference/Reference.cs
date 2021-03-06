﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloService/SayHello", ReplyAction="http://tempuri.org/IHelloService/SayHelloResponse")]
        System.IAsyncResult BeginSayHello(string name, System.AsyncCallback callback, object asyncState);
        
        string EndSayHello(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : WcfClient.ServiceReference.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SayHelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SayHelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<WcfClient.ServiceReference.IHelloService>, WcfClient.ServiceReference.IHelloService {
        
        private BeginOperationDelegate onBeginSayHelloDelegate;
        
        private EndOperationDelegate onEndSayHelloDelegate;
        
        private System.Threading.SendOrPostCallback onSayHelloCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public HelloServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(HelloServiceClient.GetBindingForEndpoint(endpointConfiguration), HelloServiceClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public HelloServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HelloServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public HelloServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HelloServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<SayHelloCompletedEventArgs> SayHelloCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WcfClient.ServiceReference.IHelloService.BeginSayHello(string name, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSayHello(name, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string WcfClient.ServiceReference.IHelloService.EndSayHello(System.IAsyncResult result) {
            return base.Channel.EndSayHello(result);
        }
        
        private System.IAsyncResult OnBeginSayHello(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string name = ((string)(inValues[0]));
            return ((WcfClient.ServiceReference.IHelloService)(this)).BeginSayHello(name, callback, asyncState);
        }
        
        private object[] OnEndSayHello(System.IAsyncResult result) {
            string retVal = ((WcfClient.ServiceReference.IHelloService)(this)).EndSayHello(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSayHelloCompleted(object state) {
            if ((this.SayHelloCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SayHelloCompleted(this, new SayHelloCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SayHelloAsync(string name) {
            this.SayHelloAsync(name, null);
        }
        
        public void SayHelloAsync(string name, object userState) {
            if ((this.onBeginSayHelloDelegate == null)) {
                this.onBeginSayHelloDelegate = new BeginOperationDelegate(this.OnBeginSayHello);
            }
            if ((this.onEndSayHelloDelegate == null)) {
                this.onEndSayHelloDelegate = new EndOperationDelegate(this.OnEndSayHello);
            }
            if ((this.onSayHelloCompletedDelegate == null)) {
                this.onSayHelloCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSayHelloCompleted);
            }
            base.InvokeAsync(this.onBeginSayHelloDelegate, new object[] {
                        name}, this.onEndSayHelloDelegate, this.onSayHelloCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override WcfClient.ServiceReference.IHelloService CreateChannel() {
            return new HelloServiceClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHelloService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHelloService1)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHelloService)) {
                return new System.ServiceModel.EndpointAddress("https://192.168.70.92:18765/WcfService/HelloService/");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHelloService1)) {
                return new System.ServiceModel.EndpointAddress("http://192.168.70.92:28765/WcfService/HelloService/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private class HelloServiceClientChannel : ChannelBase<WcfClient.ServiceReference.IHelloService>, WcfClient.ServiceReference.IHelloService {
            
            public HelloServiceClientChannel(System.ServiceModel.ClientBase<WcfClient.ServiceReference.IHelloService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSayHello(string name, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = name;
                System.IAsyncResult _result = base.BeginInvoke("SayHello", _args, callback, asyncState);
                return _result;
            }
            
            public string EndSayHello(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("SayHello", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IHelloService,
            
            BasicHttpBinding_IHelloService1,
        }
    }
}
