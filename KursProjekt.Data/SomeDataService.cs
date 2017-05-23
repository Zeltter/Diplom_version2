using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursProjekt.Data.Models;

namespace KursProjekt.Data
{
	public class SomeDataService : ServiceBase
	{
		public void AddDataToDataBase(SomeDataBaseModel model)
		{
			this.Context.SomeDataBaseModels.Add(model);
			this.Context.SaveChanges();
		}

		public List<SomeDataBaseModel> GetDataFromDataBase(int id)
		{
			return this.Context.SomeDataBaseModels.Where(data => data.ID == id).ToList();
		}

		public void DeleteDataFromDataBase(SomeDataBaseModel model)
		{
			this.Context.SomeDataBaseModels.Remove(model);
			this.Context.SaveChanges();
		}
	}
}
