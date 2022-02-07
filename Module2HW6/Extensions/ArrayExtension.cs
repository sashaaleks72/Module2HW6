namespace Module2HW6
{
    public static class ArrayExtension
    {
        public static Employee GetEmployeeWithTheHighestSalary(this Employee[] employees)
        {
            int? indexOfEmployeeWithTheHighestSalary = null;
            double salary = employees[0].Salary;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Salary > salary)
                {
                    salary = employees[i].Salary;
                    indexOfEmployeeWithTheHighestSalary = i;
                }
            }

            return employees[indexOfEmployeeWithTheHighestSalary.Value];
        }
    }
}
