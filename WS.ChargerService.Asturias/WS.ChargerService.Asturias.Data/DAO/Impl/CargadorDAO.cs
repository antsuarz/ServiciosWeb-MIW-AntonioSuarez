using WS.ChargerService.Asturias.Data.Data;
using WS.ChargerService.Asturias.Data.Model;

namespace WS.ChargerService.Asturias.Data.DAO.Impl
{
    public class CargadorDAO : GenericDAO<Cargador>, ICargadorDAO
    {
        public CargadorDAO(DataContext context) : base(context)
        {
        }
    }
}
