namespace Module2HW6
{
    public class AssessmentExceptionFactory : IAssessmentExceptionFactory
    {
        public AssessmentExceptionFactory(INotificationService notificationService)
        {
            NotificationService = notificationService;
        }

        public INotificationService NotificationService { get; set; }

        public AssessmentException Create(string msg)
        {
            return new AssessmentException(msg, NotificationService);
        }
    }
}
