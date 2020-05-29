using GameLibrary.Data;
using System;

public class Presentation
    {
    private Logic logic = new Logic();

    public Presentation()
    {
        Console.WriteLine("Здравейте! Добре дошли в GameLibrary - мястото където съхранявате свойте игри. За листа от команди напишете [H]");
        while (true)
        {
            Console.Write("Choice: ");
            var key = Console.ReadKey().Key.ToString();
            
                Console.WriteLine();

                
                switch (key)
                {
                    case "A": Add(); break;
                    case "G": Read(); break;
                    case "P": ReadOne(); break;
                    case "D": Delete(); break;
                    case "U": Update(); break;
                    case "H":
                        Console.WriteLine("Лист с команди:");
                        var color = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[A]dd - Добавете нова игра към базата данни!");
                        Console.WriteLine("[G]et - Вижте всяка игра от базата данни!");
                        Console.WriteLine("[P]rint - Вижте определена игра от базата данни чрез ID!");
                        Console.WriteLine("[D]elete - Изтрийте игра от базата данни!");
                        Console.WriteLine("[U]pdate - Обновете информация за дадена игра!");
                        
                        Console.ForegroundColor = color;
                        break;
                    default: return;
                }
            
        }
    }
        public void Add()
        {
            Library game = new Library();
            
            Console.Write("Name: ");
            game.Name = Console.ReadLine();

            Console.Write("Price: ");
            game.Price = decimal.Parse(Console.ReadLine()); 

            Console.Write("ReleaseDate: ");
            game.ReleaseDate = Console.ReadLine();

            Console.WriteLine("Choose genre: ");
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[A] - Action - Action games emphasize physical challenges that require hand-eye coordination and motor skill to overcome.");
            Console.WriteLine("[D] - Adventure games were some of the earliest games created, beginning with the text adventure Colossal Cave Adventure in the 1970s.");
            Console.WriteLine("[C] - Action-adventure - Action-adventure games combine elements of their two component genres, typically featuring long-term obstacles that must be overcome.");
            Console.WriteLine("[R] - Role-playing - video games draw their gameplay from traditional role-playing games like Dungeons & Dragons.");
            Console.WriteLine("[S] - Simulation video games - is a diverse super-category of games, generally designed to closely simulate aspects of a real or fictional reality.");
            Console.WriteLine("[T] - Strategy - video games focus on gameplay requiring careful and skillful thinking and planning in order to achieve victory.");
            Console.WriteLine("[P] - Sports - are video games that simulate sports. This opposing team(s) can be controlled by other real life people or artificial intelligence.");
            Console.WriteLine("[O] - Other - Genres not listed above!");
            Console.ForegroundColor = color;
            Console.Write("Genre: ");
            var genre = Console.ReadKey().Key.ToString();
            Console.WriteLine();
        switch (genre)
             {
                case "A": game.Genre = "Action"; break;
                case "D": game.Genre = "Adventure"; break;
                case "C": game.Genre = "Action-adventure"; break;
                case "R": game.Genre = "Role-playing"; break;
                case "S": game.Genre = "Simulation"; break;
                case "T": game.Genre = "Strategy"; break;
                case "P": game.Genre = "Sports"; break;
                case "O": game.Genre = "Other"; break;
                default: Console.Write("Wrong Genre!"); return;

            }
 
            logic.Add(game);
            Console.WriteLine("Added!");
            
        }

        public void Read()
        {
                var game = logic.GetAll();
                   
                
                foreach (var item in game)
                {
                
                 Console.WriteLine($"Id: {item.Id} Name: {item.Name} Release Date: {item.ReleaseDate} Price: {item.Price}$ Genre: {item.Genre}");
                 
                }
                
               
        }
    public void ReadOne()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        var game = logic.Get(id);
        if (game != null) Console.WriteLine($"Id: {game.Id} Name: {game.Name} Release Date: {game.ReleaseDate} Price: {game.Price}$ Genre: {game.Genre}");
        else Console.WriteLine("Id not found!");
    }

    public void Update()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Library game = logic.Get(id);
        if (game != null)
        {
            Console.Write("Name: ");
            game.Name = Console.ReadLine();
            Console.Write("Price: ");
            game.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Release date: ");
            game.ReleaseDate = Console.ReadLine();
            Console.Write("Genre: ");
            game.Genre = Console.ReadLine();
            logic.Update(game);
            Console.WriteLine("Updated!");
        }
        else
        {
            Console.WriteLine("Not found!");
        }
        
    }
    public void Delete()
    {
        
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Library game = logic.Get(id);
        var gamee = logic.GetAll();
        if(game != null)
        {
            logic.Delete(id);
            Console.WriteLine("Deleted!");
            
        }
        else
        {
            Console.WriteLine("Not Found!");
        }

        
    }
    //public void Random() 
    //{
    //    var game = logic.GetAll();
        
    //    Random rand = new Random();
    //    int randomid = rand.Next(1, game.Count);
    //    var gamee = logic.Get(randomid);
    //    Console.WriteLine($"Id: {gamee.Id} Name: {gamee.Name} Release Date: {gamee.ReleaseDate} Price: {gamee.Price}$ Genre: {gamee.Genre}");
    }

