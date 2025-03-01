using InvertedDependencyApp.Interfaces;

namespace InvertedDependencyApp
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
