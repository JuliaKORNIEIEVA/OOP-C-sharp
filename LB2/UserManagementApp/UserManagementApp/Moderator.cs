public class Moderator : User
{
    public void ModerateContent()
    {
        Console.WriteLine("Контент модеровано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Модератор");
    }
}