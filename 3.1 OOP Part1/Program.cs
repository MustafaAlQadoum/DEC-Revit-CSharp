using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp0201
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             *   emp1 {id=1, name="a" , salary=1500 ,vacation_days = 10}
                   emp1 {id=2, name="b" , salary=6000,vacation_days=15}
                  emp1 {id=3, name="c" , salary=11000,vacation_days=25}
                    emp1 {id=4, name="d" , salary=12000,vacation_days=30 }
             */
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "a", 1500, 10));
            employees.Add(new Employee(2, "b", 6000, 15));
            employees.Add(new Employee(3, "c", 11000, 25));
            employees.Add(new Employee(4, "d", 12000, 30));

            #region 3.1 OOP Part1 — 1

            List<Employee> employeesWithSalary10kPlus = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.Salary >= 10000)
                {
                    employeesWithSalary10kPlus.Add(employee);
                }
            }
            // Using LINQ —— other solution to loop the list and make new list with the specified criteria salary > 10K
            IEnumerable<Employee> employee_10kPlus = from employe in employees
                                                     where employe.Salary > 10000
                                                     select employe;
            Console.WriteLine("Employee with Salary more than 10K ");
            foreach (var employee in employeesWithSalary10kPlus) Console.WriteLine($"{employee.Name}");

            #endregion 3.1 OOP Part1 — 1

            #region 3.1 OOP Part1 — 2

            Console.WriteLine("Enter The Employee ID to get his Name and Salary");
            int.TryParse(Console.ReadLine(), out int employeeID);

            foreach (var employee in employees)
            {
                if (employee.Id == employeeID)
                {
                    Console.WriteLine($"Employee name: {employee.Name} and Salary: {employee.Salary}");
                }
                else
                {
                    // Console.WriteLine("User Doesn't exist");
                }
            }
            // Using LINQ
            IEnumerable<Employee> employee_ = from employeee in employees
                                              where employeee.Id == employeeID
                                              select employeee;
            // foreach (var employeee in employee_) Console.WriteLine($"Employee name: {employeee.Name} and Salary: {employeee.Salary}");

            #endregion 3.1 OOP Part1 — 2

            #region 3.1 OOP Part1 — 3 - Bouns Function

            // Adding Bounce to a specific employee
            // employees[1].Bounce(0.2);
            // Console.WriteLine(employees[1].Salary);

            #endregion 3.1 OOP Part1 — 3 - Bouns Function

            #region 3.1 OOP Part1 — 4 — Average Saraly

            double totalSalary = employees.Sum(emp => emp.Salary); //  Lambda expression → we can also loop the list to sum numbers to new variable
            double employeesNo = employees.Count();
            double averageSalary = totalSalary / employeesNo;
            Console.WriteLine("Average Salary is {0}", averageSalary);

            #endregion 3.1 OOP Part1 — 4 — Average Saraly

            #region 3.1 OOP Part1 — 5 — Highest Saraly

            double highestSalary = Double.MinValue;

            foreach (var emp in employees)
            {
                if (emp.Salary >= highestSalary)
                {
                    highestSalary = emp.Salary;
                }
            }
            Console.WriteLine($"Highest salary is {highestSalary}");

            #endregion 3.1 OOP Part1 — 5 — Highest Saraly

            #region 3.1 OOP Part1 — 6 — Lowest Saraly

            double lowestSalary = Double.MaxValue;
            foreach (var emp in employees)
            {
                if (emp.Salary <= lowestSalary)
                {
                    lowestSalary = emp.Salary;
                }
            }
            Console.WriteLine($"Lowest salary is {lowestSalary}");

            #endregion 3.1 OOP Part1 — 6 — Lowest Saraly

            #region 3.1 OOP Part1 — 7 — Exceeding Vacations Limit

            // Using LINQ —— other solution to loop the list and make new list with the specified criteria vacation > 21 day
            IEnumerable<Employee> employee_excedingVacations = from employe in employees
                                                               where employe.VacationDays > 21
                                                               select employe;
            Console.WriteLine("Employees who exceed 21 days vacation limit:");
            foreach (var employee in employee_excedingVacations) Console.WriteLine($"{employee.Name}");

            #endregion 3.1 OOP Part1 — 7 — Exceeding Vacations Limit

            #region 3.1 OOP Part1 — 8 — DeductSalary

            //  employees[1].DeductSalary();
            // Console.WriteLine(employees[1].Salary);

            #endregion 3.1 OOP Part1 — 8 — DeductSalary

            #region 3.1 OOP Part1 — 9 — Deduct Salary for Exceeding Vacation Limit

            // function at Employee.cs file

            #endregion 3.1 OOP Part1 — 9 — Deduct Salary for Exceeding Vacation Limit

            #region 3.1 OOP Part1 — 10 — The total detucted anount

            List<double> orginalSalary = new List<double>();
            List<double> deductedSalary = new List<double>();
            foreach (var emp in employees)
            {
                orginalSalary.Add(emp.Salary);
                deductedSalary.Add(emp.DeductSalary());
            }

            var totalDeduction = orginalSalary.Sum() - deductedSalary.Sum();
            Console.WriteLine($"Total Salaries: {orginalSalary.Sum()}");
            Console.WriteLine($"Total Deducted Salaries: {deductedSalary.Sum()}");
            Console.WriteLine($"Total Deduction: {totalDeduction}");

            #endregion 3.1 OOP Part1 — 10 — The total detucted anount

            Console.ReadKey();
        }
    }
}