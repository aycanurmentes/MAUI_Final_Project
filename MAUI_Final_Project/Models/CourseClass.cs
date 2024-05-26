using System;
using SQLite;

namespace MAUI_Final_Project.Models
{
	public class CourseClass
	{
		[PrimaryKey,AutoIncrement]
		public int Crs_ID { get; set; }
		public string Crs_Name { get; set; }
		public string Crs_Code { get; set; }
	}
}

