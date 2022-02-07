using System;

namespace Module2HW6
{
    public class NotificationService : INotificationService
    {
        public void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
