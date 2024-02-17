using WS.ChargerService.Asturias.Data.Model;

namespace WS.ChargerService.Asturias.Data.Data
{
    public class DataServices : IDataServices
    {
        public Cargador[] GetCargadores()
        {
            using (DAOFactory factory = new DAOFactory())
            {
                return factory.CargadorDAO.All().ToArray();
            }
        }
    }
}
