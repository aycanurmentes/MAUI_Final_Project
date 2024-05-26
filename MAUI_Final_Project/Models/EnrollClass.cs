using System;
using SQLite;

namespace MAUI_Final_Project.Models
{
	public class EnrollClass
	{
		[PrimaryKey,AutoIncrement]
		public int En_ID { get; set; }
		public int Stu_ID { get; set; }
		public string Crs_Code { get; set; }
	}
}

