namespace Module2HW6
{
    public class AssessmentService : IAssessmentService
    {
        public void GiveStudentAGrade(Teacher teacher, Student student, decimal totalMark)
        {
            if (totalMark < 0 || totalMark > 100)
            {
                throw new AssessmentException($"Incorrect mark");
            }

            for (int i = 0; i < student.Subjects.Length; i++)
            {
                if (teacher.Subject == student.Subjects[i])
                {
                    student.TotalMarks[i] = totalMark;
                    return;
                }
            }

            throw new AssessmentException($"The student with ID {student.StudentId} isn't taught a subject {teacher.Subject}");
        }
    }
}
