using System.Text;

namespace Module2HW6
{
    public class Student : Employee
    {
        public Student(string studId, int course, string[] subjects, double salary, string firstName, string lastName, int age, string[] hobbies, Teacher curator)
            : base(salary, firstName, lastName, age, hobbies)
        {
            StudentId = studId;
            Course = course;
            Subjects = subjects;
            TotalMarks = new decimal[subjects.Length];
            Curator = curator;
        }

        public string StudentId { get; set; }
        public int Course { get; set; }
        public string[] Subjects { get; set; }

        public decimal[] TotalMarks { get; set; }

        public Teacher Curator { get; set; }

        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.Append($"Student ID: {StudentId}\nCourse: {Course}\nSubjects:\n");
            for (int i = 0; i < Subjects.Length; i++)
            {
                studentInfo.Append($"- {Subjects[i]}({TotalMarks[i]})\n");
            }

            studentInfo.Append($"Scholarship: {Salary} UAH\nFirst name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nCurator: {Curator.FirstName} {Curator.LastName}\n");

            return studentInfo.ToString();
        }
    }
}
