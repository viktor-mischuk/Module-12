namespace Module_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Login = "Ma47",
                    Name = "Игорь",
                    IsPremium = true,
                },
                new User()
                {
                    Login = "VV2024",
                    Name = "Сергей",
                    IsPremium = false,
                }
            };

            foreach (User user in users)
            {
                if (user is null) continue;
                if (!user.IsPremium) ShowAds();
                Greating(user);
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                Console.WriteLine();
            }

        }
        
        static void Greating(User user)
        {
            Console.WriteLine($"Здравствуйте, {user.Name}");
            Console.WriteLine();
        }
        
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
