using System;

namespace BestPractices.Common
{
    static public class NotificationService
    {
        static public string NotifyTalent(string talentName)
        {
            var message = "talent" + talentName;
            Console.WriteLine(message);
            return message;
        }
    }
}
