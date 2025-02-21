using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_frameWork3.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_frameWork3
{
    internal class CompanyDBContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-D1ALO0LH\\MSSQLSERVER02;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //         .HasMany(s => s.Courses)
            //   .WithMany(c => c.Students);

            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Students)
            //    .WithMany(s => s.Courses);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.studentCourses)
                .WithOne(sc => sc.Course)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.studentCourses)
                .WithOne(sc => sc.Student)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Department>()
                        .HasKey(d => d.DeptId);
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
