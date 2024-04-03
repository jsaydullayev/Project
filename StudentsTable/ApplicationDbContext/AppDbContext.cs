using Microsoft.EntityFrameworkCore;
using StudentsTable.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTable.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
       public  DbSet<StudentsClass> students {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=ASUS; DataBase = Students Table; Integrated Security = true; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(path);
        }

    }
}
