using Microsoft.EntityFrameworkCore;
using WS.ChargerService.Asturias.Data.Model;

namespace WS.ChargerService.Asturias.Data.Data
{
	public class DataContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder
		optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=data/database.db");
		}
		public DbSet<Cargador> Cargadores { get; set; }
	}
}
