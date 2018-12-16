using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class Brewery
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public List<Beer> BeerList { get; set; }
    }
}
