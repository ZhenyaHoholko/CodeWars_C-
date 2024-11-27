using System;
using System.Collections.Generic;


public class User
{
    public string Name;
    public string Email;
    public string Password;

    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
}
public class UserManager
{
    public List<User> Users { get; } = new List<User>();
    public event EventHandler<UserRegisteredEventArgs> UserRegistered;
    public void Register(User user)
    {
        Users.Add(user);
        UserRegistered?.Invoke(this, new UserRegisteredEventArgs(user.Email));
    }
}
public class UserRegisteredEventArgs : EventArgs
{
    public string Email { get; }

    public UserRegisteredEventArgs(string email)
    {
        Email = email;
    }
}
public static class CodeGenerator
{
    public static int Get()
    {
        return new Random().Next(1000, 9999);
    }
}
public class TwoFactorAuthentication
{
    private UserManager userManager { get; }
    public TwoFactorAuthentication(UserManager userManager)
    {
        this.userManager = userManager;
    }
    private void SendCode(object sender, UserRegisteredEventArgs e)
    {
        int code = CodeGenerator.Get();
        Console.WriteLine($"Код подтверждения: {code} отправлен на почту: {e.Email}");
    }
    public void TurnOn()
    {
        userManager.UserRegistered += SendCode;
    }
    public void TurnOff()
    {
        userManager.UserRegistered -= SendCode;
    }
}
public class Advertisement
{
    private UserManager userManager { get; }
    public Advertisement(UserManager userManager)
    {
        this.userManager = userManager;
    }
    private void SendAds(object sender, UserRegisteredEventArgs e)
    {
        Console.WriteLine($"Последний день приобрести курс Технология Git по скидке. Отправлено на почту {e.Email}");
    }
    public void TurnOn()
    {
        userManager.UserRegistered += SendAds;
    }
    public void TurnOff()
    {
        userManager.UserRegistered -= SendAds;
    }
}
class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();
        userManager.UserRegistered += (sender, e) =>
        {
            Console.WriteLine($"Уведомление: пользователь с Email {e.Email} успешно зарегистрирован!");
        };
        userManager.Register(new User("Алексей", "a.potapov@gmail.com", "qwerty123"));
        Console.WriteLine($"Пользователь {userManager.Users[0].Name} зарегистрирован");
        Console.ReadLine();
    }
}