namespace Module2HW6
{
    public class Aspirant : Student
    {
        public Aspirant(string dissertationTopic, string studId, int course, string[] subjects, double salary, string firstName, string lastName, int age, string[] hobbies, Teacher curator)
            : base(studId, course, subjects, salary, firstName, lastName, age, hobbies, curator)
        {
            DissertationTopic = dissertationTopic;
        }

        public string DissertationTopic { get; set; }
    }
}
