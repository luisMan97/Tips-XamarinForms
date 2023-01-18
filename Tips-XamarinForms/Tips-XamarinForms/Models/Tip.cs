using System;
using SQLite;

namespace TipsXamarinForms.Data
{
	public class Tip
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

		public Tip()
		{

		}
	}
}

