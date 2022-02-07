using System;

namespace Module2HW6
{
    public class AssessmentException : Exception
    {
        public AssessmentException(string msg, INotificationService notificationService)
            : base(msg)
        {
            NotificationService = notificationService;
        }

        public INotificationService NotificationService { get; set; }

        public void PrintException()
        {
            NotificationService.ShowErrorMsg(Message);
        }
    }
}
