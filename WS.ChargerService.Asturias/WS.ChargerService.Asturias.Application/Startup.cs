using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using System.ServiceModel;

namespace WS.ChargerService.Asturias.Application
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IApplicationServices, ApplicationServices>();
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddSoapCore();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSoapEndpoint<IApplicationServices>(
            "/ApplicationServices.svc",
            new BasicHttpBinding(),
            SoapSerializer.DataContractSerializer,
            false, null, null, true, true);
            app.UseMvc();
        }
    }

}
