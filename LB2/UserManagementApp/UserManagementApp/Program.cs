class Program
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new Admin { UserName = "AdminUser", Email = "admin@example.com" },
            new Moderator { UserName = "ModUser", Email = "mod@example.com" },
            new RegularUser { UserName = "RegUser", Email = "user@example.com" }
        };

        users[0].SetPassword("admin123");
        users[1].SetPassword("wrongpass");
        users[2].SetPassword("user123");

        Console.WriteLine("=== Інформація про користувачів ===");
        foreach (var user in users)
        {
            user.DisplayInfo();
        }

        Console.WriteLine("\n=== Тестування методів ===");
        foreach (var user in users)
        {
            if (user is Admin admin)
                admin.BlockUser(users[2]);
            else if (user is Moderator mod)
                mod.ModerateContent();
            else if (user is RegularUser reg)
                reg.PostComment();
        }

        Console.WriteLine("\n=== Перевірка аутентифікації ===");
        Console.WriteLine($"AdminUser: {(users[0].Authenticate("admin123") ? "Успішна" : "Невірна")} аутентифікація");
        Console.WriteLine($"ModUser: {(users[1].Authenticate("mod123") ? "Успішна" : "Невірна")} аутентифікація");
        Console.WriteLine($"RegUser: {(users[2].Authenticate("user123") ? "Успішна" : "Невірна")} аутентифікація");
    }
}