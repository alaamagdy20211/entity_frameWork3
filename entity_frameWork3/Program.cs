using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace entity_frameWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //Explicit Loading
            CompanyDBContext context = new CompanyDBContext();
            //var Department = (from D in context.Departments        
            //                  where D.DeptId == 10
            //                  select D).FirstOrDefault();
            //context.Entry(Department).Collection(D => D.Employees).Load();
            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //Console.WriteLine($"DepartmentId = {Department.DeptId} , DepartmentName = {Department.Name}");

            //var Employee = (from E in context.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();
            //context.Entry(Employee).Reference(e => e.Department).Load();

            //Console.WriteLine($"EmployeeId = {Employee.Id} , EmployeeName = {Employee.Name} , DepartmentName = {Employee.Department.Name}");
            //Eager Loading
            var department = (from D in context.Departments.Include(D => D.Employees)
                              where D.DeptId == 10
                              select D).FirstOrDefault();
            foreach (var E in department.Employees)
                Console.WriteLine(E.Name);

            var employee = (from E in context.Employees.Include(E => E.Department)
                            where E.Id == 1
                            select E).FirstOrDefault();



            //Lazy Loading
            //var ddepartment = (from D in context.Departments
            //                  where D.DeptId == 10
            //                  select D).FirstOrDefault();


            //foreach (var E in Department.Employees)
            //    Console.WriteLine(E.Name);

            //var eemployee = (from E in context.Employees.Include(E => E.Department)
            //                where E.Id == 1
            //                select E).FirstOrDefault();


            #endregion

            #region Linq Operators (Join)
            //var Result = from E in context.Employees
            //             join D in context.Departments
            //             on E.DepartmentId equals D.DeptId
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DeptName = D.Name

            //             };
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //var Result = from E in context.Employees
            //             join D in context.Departments
            //             on E.DepartmentId equals D.DeptId
            //             where E.Address == "Cairo"
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DeptName = D.Name

            //             };
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            //Result = context.Employees.Join(context.Departments,
            //    E => E.DepartmentId,
            //    D => D.DeptId,
            //    (E, D) => new
            //    {
            //        EmpName = E.Name,
            //        DeptName = D.Name
            //    });


            //var Result = from E in context.Employees
            //             join D in context.Departments
            //             on E.DepartmentId equals D.DeptId
            //             where E.Address == "Cairo"
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DeptName = D.Name,
            //                 EmpAddress = E.Address
            //             };
            //Result = context.Employees.Join(context.Departments,
            //    E => E.DepartmentId,
            //    D => D.DeptId,
            //    (E, D) => new
            //    {
            //        EmpName = E.Name,
            //        DeptName = D.Name,

            //    }).Where(E => E.EmpAddress == "Cairo");
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion


        }
    }
}
