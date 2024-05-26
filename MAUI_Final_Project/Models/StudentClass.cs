using System;
using SQLite;

namespace MAUI_Final_Project.Models
{
	public class StudentClass
	{
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}

