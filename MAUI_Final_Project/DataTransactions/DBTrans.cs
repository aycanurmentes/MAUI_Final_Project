using System;
using MAUI_Final_Project.Models;
using SQLite;

namespace MAUI_Final_Project.DataTransactions
{
	public class DBTrans
	{
		public string dbPath;
		private SQLiteConnection conn;

		public DBTrans(string _dbPath)
		{
			this.dbPath = _dbPath;
		}
		public void Init()
		{
			if (conn == null)
			{
                conn = new SQLiteConnection(this.dbPath);
                conn.CreateTable<StudentClass>();
				conn.CreateTable<CourseClass>();
				conn.CreateTable<EnrollClass>();

            }
			
		}

		//student
		public List<StudentClass> GetAllStudents()
		{
			Init();
			return conn.Table<StudentClass>().ToList();
		}
		public void Add(StudentClass student)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Insert(student);
		}
		public void Delete(int student_ID)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Delete(new StudentClass { ID = student_ID });
		}

		//course
		public List<CourseClass> GetAllCourses()
		{
			Init();
			return conn.Table<CourseClass>().ToList();
		}
		public void AddCourse(CourseClass course)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Insert(course);
		}
		public void DeleteCourse(int course_ID)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Delete(new CourseClass { Crs_ID = course_ID });
		}

		//enroll
		public List<EnrollClass> GetAllEnrolls()
		{
			Init();
			return conn.Table<EnrollClass>().ToList();
		}
		public void AddEnroll(EnrollClass enroll)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Insert(enroll);
		}
		public void DeleteEnroll(int enroll_ID)
		{
			conn = new SQLiteConnection(this.dbPath);
			conn.Delete(new EnrollClass { En_ID= enroll_ID });
		}
	}
}

