namespace WS.ChargerService.Asturias.Data.DAO
{
    public interface IGenericDAO<T> where T : class
    { 
        T Find(int id);
        IEnumerable<T> All(); 
    }
}
