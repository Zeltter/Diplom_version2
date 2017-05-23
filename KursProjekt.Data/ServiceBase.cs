using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursProjekt.Data
{
    public abstract class ServiceBase
    {
		protected DataBaseContext Context { get; private set; }

		protected ServiceBase()
			: this(new DataBaseContext())
		{
		}

		protected ServiceBase(DataBaseContext context)
		{
			this.Context = context;
		}

		public void ResetContext()
		{
			this.Context.Dispose();
			this.Context = new DataBaseContext();
		}

		protected void DeleteAllRows<T>()
		{
			string tableName = (Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute)) as TableAttribute).Name;
			int? timeout = this.Context.Database.CommandTimeout;
			this.Context.Database.CommandTimeout = 2 * 60 * 1000;
			this.Context.Database.ExecuteSqlCommand("DELETE FROM " + tableName);
			this.Context.Database.CommandTimeout = timeout;
		}
	}
}

