using WS.ChargerService.Asturias.Application.Model;
using WSClient.Data;

namespace WS.ChargerService.Asturias.Application
{
    public class ApplicationServices : IApplicationServices
    {

        CargadorModel[] IApplicationServices.GetCargadores()
        { 
            IDataServices dataServices = new DataServicesClient();
            Console.WriteLine(dataServices.GetCargadoresAsync().Result.Length);
            return ConverterList(dataServices.GetCargadoresAsync().Result);
        }

        private CargadorModel[] ConverterList(Cargador[] result)
        {
            var modelos = new List<CargadorModel>();
            foreach(Cargador c in result) {
                modelos.Add(Converter(c));
            }
            return modelos.ToArray();
        }

        private CargadorModel Converter(Cargador c)
        {
            var modelo = new CargadorModel();
            modelo.Tipo = c.Tipo;
            modelo.cordX = c.cordX;
            modelo.cordY = c.cordY;
            modelo.Title = c.Title;
            return modelo;
        }
    }
}
