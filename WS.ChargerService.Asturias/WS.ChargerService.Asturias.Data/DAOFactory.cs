using WS.ChargerService.Asturias.Data.DAO;
using WS.ChargerService.Asturias.Data.DAO.Impl;
using WS.ChargerService.Asturias.Data.Data;

namespace WS.ChargerService.Asturias.Data
{
    public class DAOFactory : IDisposable
    {
        private DataContext _context;

        public DAOFactory()
        {
            _context = new DataContext();
        }

        public ICargadorDAO CargadorDAO
        {
            get { return new CargadorDAO(_context); }
        }


        public void Dispose() { _context.Dispose(); }
    }
}
