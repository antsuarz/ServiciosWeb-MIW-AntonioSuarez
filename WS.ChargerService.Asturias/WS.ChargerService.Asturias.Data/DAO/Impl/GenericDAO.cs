using Microsoft.EntityFrameworkCore;
using WS.ChargerService.Asturias.Data.Data;

namespace WS.ChargerService.Asturias.Data.DAO.Impl
{
    public class GenericDAO<T> where T : class
    {
        private DataContext Context { get; set; }

        public GenericDAO(DataContext context)
        {
            this.Context = context;
        }

        protected DbSet<T> DbSet
        {
            get { return Context.Set<T>(); }
        }

        public virtual T Find(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> All()
        {
            return DbSet.ToList();
        }

    }
}
