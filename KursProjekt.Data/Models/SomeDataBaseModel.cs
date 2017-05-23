using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursProjekt.Data.Models
{
	//так описываешь сущности в бд
	[Table("SomeDataBaseModels")]
	public class SomeDataBaseModel
	{
		public int ID { get; set; }

		
		[NotMapped]//так добавляешь в класс данные, которые не являются частью модели данных БД
		public string SomeString { get; set; }
	}
}
