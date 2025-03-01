using InvertedDependencyApp.Interfaces;

namespace InvertedDependencyApp
{
    public class WhatsAppNotificationSevice : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
