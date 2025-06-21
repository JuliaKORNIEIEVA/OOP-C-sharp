public class RegularUser : User
{
    public void PostComment()
    {
        Console.WriteLine("Коментар опубліковано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Звичайний користувач");
    }
}