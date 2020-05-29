using System.ComponentModel.DataAnnotations;
/// <summary>
/// Library
/// </summary>
namespace GameLibrary.Data
{
    public class Library
    {
         [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate{ get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        
    }
}
