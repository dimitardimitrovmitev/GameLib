using GameLibrary.Data;
using System;

/// <summary>
/// The main Presentation class
/// Contains all run functions and display information.
/// </summary>
public class Presentation
    {
    private Logic logic = new Logic();

    public Presentation()
    {
        
        Console.WriteLine("Hello! Welcome to GameLibrary - the place where you can store all your games!!!. To see the avalable commands type [H]");
        while (true)
        {
            
            Console.Write("Choice: ");
            var key = Console.ReadKey().Key.ToString();
            
                Console.WriteLine();

            //choose which case to use
            switch (key)
                {
                    //When pressed Adds element
                    case "A": Add(); break;
                    //When pressed prints database
                    case "G": Read(); break;
                    //When pressed shows special game
                    case "P": ReadOne(); break;
                    //When pressed delete one game by Id
                    case "D": Delete(); break;
                    //When pressed Updates a certain game based on the id
                    case "U": Update(); break;
                    //When pressed shows help menu
                    case "H":
                        Console.WriteLine("List of commands:");
                        var color = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[A]dd - Adds new game to the database!");
                        Console.WriteLine("[G]et - Prints all games in the database!");
                        Console.WriteLine("[P]rint - Prints a specific game based on the id!");
                        Console.WriteLine("[D]elete - Deletes centain game from the database!!");
                        Console.WriteLine("[U]pdate - Updates a certain game based on the id!");
                        // Color
                        Console.ForegroundColor = color;
                        break;
                    default: return;

                    
                }
            
        }
    }
    // Adding new game specifications
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
        //Displays all the games
        public void Read()
        {
                var game = logic.GetAll();
                   
                
                foreach (var item in game)
                {
                
                 Console.WriteLine($"Id: {item.Id} Name: {item.Name} Release Date: {item.ReleaseDate} Price: {item.Price}$ Genre: {item.Genre}");
                 
                }
                
               
        }
    //Displays specific game by Id 
    public void ReadOne()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        var game = logic.Get(id);
        if (game != null) Console.WriteLine($"Id: {game.Id} Name: {game.Name} Release Date: {game.ReleaseDate} Price: {game.Price}$ Genre: {game.Genre}");
        else Console.WriteLine("Id not found!");
    }
    
    //Updating certain game
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
    //Deleting certain game by ID
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

    }