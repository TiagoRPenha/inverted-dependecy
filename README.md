I created this repository to implement the use of the dependency inversion principle. As a way to learn and practice.

By applying the dependency inversion principle, it allows class A "UserService" to call methods in an abstraction "INotificationService" implemented by class(es) B "EmailNotificationService, SmsNotificationService, WhatsAppNotificationService).
Making it possible for A to call B at runtime, but for B to depend on an interface controlled by A at compile time (therefore inverting the typical dependency at compile time).

Example 1: Failure to use inversion of control, generating a high dependency at compile time

![image](https://github.com/user-attachments/assets/ac696b88-3049-49c0-86ba-d4609dd4356f)

Example 2: Use of inversion of control, generating more flexible code (maintenance, scalability, testing)

![image](https://github.com/user-attachments/assets/c2cbc101-49c1-4105-82aa-2996c2219361)
