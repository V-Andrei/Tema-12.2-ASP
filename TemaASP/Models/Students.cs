using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemaASP.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Email { get; set; }

    }

    public class StudentsData
    {
        private static readonly List<Students> Students = new List<Students>();
        static StudentsData()
        {
            Students.Add(new Students { Id = 1, Name = "George", Faculty = "History", Email = "george@yahoo.com" });
            Students.Add(new Students { Id = 2, Name = "Marian", Faculty = "Biology",Email = "marian@yahoo.com" });
            Students.Add(new Students { Id = 3, Name = "Stefana", Faculty = "Info",Email = "stefana@yahoo.com" });
            Students.Add(new Students { Id = 4, Name = "Gheorghe", Faculty = "Info",Email = "gheorghe@yahoo.com" });
            Students.Add(new Students { Id = 5, Name = "Nicoleta", Faculty = "Info",Email = "nicoleta@yahoo.com" });
            Students.Add(new Students { Id = 6, Name = "Gigiel", Faculty = "Geography", Email = "gigiel@yahoo.com" });
            Students.Add(new Students { Id = 7, Name = "Vasile", Faculty = "History", Email = "vasile@yahoo.com" });
            Students.Add(new Students { Id = 8, Name = "Elena", Faculty = "Geography", Email = "elena@yahoo.com" });
            Students.Add(new Students { Id = 9, Name = "Maria", Faculty = "History", Email = "maria@yahoo.com" });
            Students.Add(new Students { Id = 10, Name = "Andreea", Faculty = "Geography", Email = "andreea@yahoo.com" });
        }
        public StudentsData()
        {
        }
        public List<Students> GetStudents()
        {
            return Students;
        }
        public Students GetStudents(int id)
        {
            return Students.Find(x => x.Id == id);
        }
    }
}