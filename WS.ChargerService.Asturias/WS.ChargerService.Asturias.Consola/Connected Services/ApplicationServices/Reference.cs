﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CargadorModel", Namespace="http://schemas.datacontract.org/2004/07/WS.ChargerService.Asturias.Application.Mo" +
        "del")]
    public partial class CargadorModel : object
    {
        
        private string TipoField;
        
        private string TitleField;
        
        private string cordXField;
        
        private string cordYField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo
        {
            get
            {
                return this.TipoField;
            }
            set
            {
                this.TipoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cordX
        {
            get
            {
                return this.cordXField;
            }
            set
            {
                this.cordXField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cordY
        {
            get
            {
                return this.cordYField;
            }
            set
            {
                this.cordYField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.chargerservice.asturias/application/", ConfigurationName="ApplicationServices.IApplicationServices")]
    public interface IApplicationServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.chargerservice.asturias/application/IApplicationServices/GetCargadores", ReplyAction="http://ws.chargerservice.asturias/application/IApplicationServices/GetCargadoresR" +
            "esponse")]
        System.Threading.Tasks.Task<ApplicationServices.CargadorModel[]> GetCargadoresAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IApplicationServicesChannel : ApplicationServices.IApplicationServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ApplicationServicesClient : System.ServiceModel.ClientBase<ApplicationServices.IApplicationServices>, ApplicationServices.IApplicationServices
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ApplicationServicesClient() : 
                base(ApplicationServicesClient.GetDefaultBinding(), ApplicationServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IApplicationServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApplicationServicesClient(EndpointConfiguration endpointConfiguration) : 
                base(ApplicationServicesClient.GetBindingForEndpoint(endpointConfiguration), ApplicationServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApplicationServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ApplicationServicesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApplicationServicesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ApplicationServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApplicationServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ApplicationServices.CargadorModel[]> GetCargadoresAsync()
        {
            return base.Channel.GetCargadoresAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IApplicationServices))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IApplicationServices))
            {
                return new System.ServiceModel.EndpointAddress("http://156.35.98.159:9091/ApplicationServices.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ApplicationServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IApplicationServices);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ApplicationServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IApplicationServices);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IApplicationServices,
        }
    }
}
