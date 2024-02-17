using System.ServiceModel;
using WS.ChargerService.Asturias.Application.Model;

namespace WS.ChargerService.Asturias.Application
{
    [ServiceContract(Namespace = "http://ws.chargerservice.asturias/application/")]
    public interface IApplicationServices
    {
        [OperationContract]
        public CargadorModel[] GetCargadores();
    }
}
