using System.Collections.Generic;
using SQLite;

namespace App1.Models
{
    public class Brewery
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public List<Beer> BeerList { get; set; }
    }
}