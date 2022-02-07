namespace Module2HW6
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, string[] hobbies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hobbies = hobbies;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string[] Hobbies { get; set; }
    }
}
