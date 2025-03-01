﻿using InvertedDependencyApp.Interfaces;

namespace InvertedDependencyApp
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
