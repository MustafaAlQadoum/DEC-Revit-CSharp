namespace ConsoleApp0201
{
    internal class Employee
    {
        //    emp1 {id=1, name="a" , salary=1500 ,vacation_days = 10}
        public int Id { get; set; }

        public string Name { get; set; }
        public double Salary { get; set; }
        public double VacationDays { get; set; }

        public Employee(int id, string name, double salary, double vacationDays)
        {
            Id = id;
            Name = name;
            Salary = salary;
            VacationDays = vacationDays;
        }

        #region 3.1 OOP Part1 — 3 - Bouns Function

        public double Bounce(double Percentage)
        {
            return Salary = Salary * (1 + Percentage);
        }

        #endregion 3.1 OOP Part1 — 3 - Bouns Function

        #region 3.1 OOP Part1 — 8 — DetuctSalary

        public double DeductSalary()
        {
            double deductionAmount = 0;
            for (double i = 0; i < VacationDays; i++)
            {
                deductionAmount += Salary * 0.02;
            }

            Salary = Salary - deductionAmount;
            return Salary;
        }

        #endregion 3.1 OOP Part1 — 8 — DetuctSalary

        #region 3.1 OOP Part1 — 9 — Deduct Salary for Exceeding Vacation Limit

        public double DeductSalary_ExceedingLimit()
        {
            if (VacationDays > 21)
            {
                return Salary * (1 - 0.25);
            }
            else
            {
                return Salary;
            }
        }

        #endregion 3.1 OOP Part1 — 9 — Deduct Salary for Exceeding Vacation Limit
    }
}