namespace Module2HW6
{
    public class Employee : Person
    {
        public Employee(double salary, string firstName, string lastName, int age, string[] hobbies)
            : base(firstName, lastName, age, hobbies)
        {
            Salary = salary;
        }

        public double Salary { get; set; }
    }
}
