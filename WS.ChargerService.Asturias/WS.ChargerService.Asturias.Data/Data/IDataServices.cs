using System.ServiceModel;
using WS.ChargerService.Asturias.Data.Model;

namespace WS.ChargerService.Asturias.Data.Data
{
    [ServiceContract(Namespace = "http://ws.chargerservice.asturias/data/")]
    public interface IDataServices
    {
        [OperationContract]
        public Cargador[] GetCargadores();
    }
}
