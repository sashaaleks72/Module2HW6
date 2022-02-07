using Autofac;

namespace Module2HW6
{
    public class DIConfig
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<AssessmentExceptionFactory>().As<IAssessmentExceptionFactory>();
            builder.RegisterType<AssessmentService>().As<IAssessmentService>();
            builder.RegisterType<Starter>();

            var container = builder.Build();

            return container;
        }
    }
}
