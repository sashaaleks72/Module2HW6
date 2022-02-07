using System;

namespace Module2HW6
{
    public class Starter
    {
        public Starter(IAssessmentService assessmentService, INotificationService notificationService)
        {
            AssessmentService = assessmentService;
            NotificationService = notificationService;
        }

        public IAssessmentService AssessmentService { get; set; }
        public INotificationService NotificationService { get; set; }

        public void Run()
        {
            Teacher curator = new Teacher("Math", 12200, "Viktor", "Reshetnik", 51, new string[] { "Programming", "Math" });
            Student student1 = new Student("XA 1234324", 3, new string[] { "Math", "Physics", "Programming" }, 1980, "Alex", "Seleznev", 20, new string[] { "Programming" }, curator);
            Teacher teacher1 = new Teacher("Programming", 13400, "Alex", "Selikov", 49, new string[] { "Programming", "Math", "Physics" });
            Teacher teacher2 = new Teacher("Physics", 15600, "Vladimir", "Abramov", 38, new string[] { "Math", "Physics" });

            Teacher teacherToShowException = new Teacher("Theory of Algorithms", 15900, "Andrei", "Lomonosov", 67, new string[] { "Math", "Physics", "Theory of Algorithms" });

            try
            {
                AssessmentService.GiveStudentAGrade(teacher1, student1, 89m);
                AssessmentService.GiveStudentAGrade(teacher2, student1, 91m);
                AssessmentService.GiveStudentAGrade(curator, student1, -1m);
            }
            catch (AssessmentException ex)
            {
                ex.PrintException(NotificationService);
            }

            try
            {
                AssessmentService.GiveStudentAGrade(teacherToShowException, student1, 99m);
            }
            catch (AssessmentException ex)
            {
                ex.PrintException(NotificationService);
            }

            Employee[] employees = new Employee[]
            {
                student1, teacher1, teacher2, curator, teacherToShowException
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine($"Employee with the highest salary:\n{employees.GetEmployeeWithTheHighestSalary()}");
        }
    }
}
