using System.Text;

namespace Module2HW6
{
    public class Teacher : Employee
    {
        public Teacher(string subject, double salary, string firstName, string lastName, int age, string[] hobbies)
            : base(salary, firstName, lastName, age, hobbies)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.Append($"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nSubject: {Subject}\nSalary: {Salary} UAH\n");
            foreach (string hobby in Hobbies)
            {
                studentInfo.Append($"- {hobby}\n");
            }

            return studentInfo.ToString();
        }
    }
}
