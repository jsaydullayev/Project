using Microsoft.EntityFrameworkCore;
using StudentsTable.ApplicationDbContext;
using StudentsTable.Class;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTable.Methodes
{
    public class HelperMethodes
    {
        List<StudentsClass> studentsClass = new List<StudentsClass>();
        AppDbContext dbContext = new AppDbContext();

        public void AllStudents()
        {
            var data = dbContext.students.ToList();
            if (data.Any())
            {
                foreach (var item in data)
                {
                    Console.WriteLine($"Id: {item.Id}, FirstName: {item.FirstName}, LastName: {item.LastName}, Student Age: {item.Age}, Student Address: {item.Address}");
                }
            }
            else
            {
                Console.WriteLine("Table is empty");
            }
        }
        public void AddStudents(StudentsClass studentClass)
        {
            dbContext.students.Add(studentClass);
            dbContext.SaveChanges();
        }
    }
}

