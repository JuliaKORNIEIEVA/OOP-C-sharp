public class Admin : User
{
    public void BlockUser(User user)
    {
        Console.WriteLine($"Користувача {user.UserName} заблоковано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Адміністратор");
    }
}