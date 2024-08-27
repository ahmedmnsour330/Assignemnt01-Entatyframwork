using Assignemnt01_Entatyframwork.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt01_Entatyframwork.Context
{
    internal class CompanyDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-8SAG386T; Database = Company_Entity01 ; Trusted_Connection = True ; Encrypt = False");
        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course_Inst> Course_Inst {  get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor {  get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; } 




        }

    }

