using System;

namespace Module2HW6
{
    public static class NotificationServiceExtension
    {
        public static void ShowErrorMsg(this INotificationService notificationService, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
