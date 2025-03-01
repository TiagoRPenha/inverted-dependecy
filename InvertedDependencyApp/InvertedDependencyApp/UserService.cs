using InvertedDependencyApp.Interfaces;

namespace InvertedDependencyApp
{
    public class UserService
    {
        private readonly INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            _notificationService = notificationService;            
        }

        public void RegisterUser(string userName)
        {
            Console.WriteLine($"Registered {userName} user");

            _notificationService.Send($"Welcome {userName}");
        }
    }
}
