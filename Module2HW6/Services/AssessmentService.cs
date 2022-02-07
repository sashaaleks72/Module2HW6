using Autofac;

namespace Module2HW6
{
    public class AssessmentService : IAssessmentService
    {
        public void GiveStudentAGrade(Teacher teacher, Student student, decimal totalMark)
        {
            AssessmentException exception;

            if (totalMark < 0 || totalMark > 100)
            {
                exception = new DIConfig().Build().Resolve<IAssessmentExceptionFactory>().Create("Incorrect mark");
                throw exception;
            }

            for (int i = 0; i < student.Subjects.Length; i++)
            {
                if (teacher.Subject == student.Subjects[i])
                {
                    student.TotalMarks[i] = totalMark;
                    return;
                }
            }

            exception = new DIConfig().Build().Resolve<IAssessmentExceptionFactory>().Create($"The student with ID {student.StudentId} isn't taught a subject {teacher.Subject}");
            throw exception;
        }
    }
}
