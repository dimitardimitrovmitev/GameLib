using System.ComponentModel.DataAnnotations;
/// <summary>
/// Library
/// </summary>
namespace GameLibrary.Data
{
    /*
    The main Library class
    Contains all methods for setting: Id, Name, Release date, Genre, Priece;
*/
    public class Library
    {
         [Key]
        // Adds/Sets Id to the DataBase
        public int Id { get; set; }
        // Adds/Sets Name to the DataBase
        public string Name { get; set; }
        // Adds/Sets Release date to the DataBase
        public string ReleaseDate{ get; set; }
        // Adds/Sets Genre to the DataBase
        public string Genre { get; set; }
        // Adds/Sets Priece to the DataBase
        public decimal Price { get; set; }
        
    }
}
