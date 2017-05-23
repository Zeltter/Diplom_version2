using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using KursProjekt.Data.Models;

namespace KursProjekt.Data
{
	public class DataBaseContext : IdentityDbContext<IdentityUser>
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		[InjectionConstructor]
		public DataBaseContext() : base("DefaultConnection")
		{
		}
		public DataBaseContext(string connectionString) : base(connectionString)
		{
		}

		public DbSet<SomeDataBaseModel> SomeDataBaseModels { get; set; }//Вот так прописываешь таблицы в бд

		public static DataBaseContext Create()
		{
			return new DataBaseContext();
		}
	}
}
