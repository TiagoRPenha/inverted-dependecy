namespace InvertedDependencyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userServiceEmail = new UserService(new EmailNotificationService());
            userServiceEmail.RegisterUser("Tiago");

            var userServiceSms = new UserService(new SmsNotificationService());
            userServiceSms.RegisterUser("Pedro");
        }
    }
}
