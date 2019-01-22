using SQLite;

namespace App1.Models
{
    public class Beer
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public Brewery Brewery { get; set; }
        public int Rate { get; set; }
    }
}