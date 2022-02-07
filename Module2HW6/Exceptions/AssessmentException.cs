using System;

namespace Module2HW6
{
    public class AssessmentException : Exception
    {
        public AssessmentException(string msg)
            : base(msg)
        {
        }

        public void PrintException(INotificationService notificationService)
        {
            notificationService.ShowErrorMsg(Message);
        }
    }
}
