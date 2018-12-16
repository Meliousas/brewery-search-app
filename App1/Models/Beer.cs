using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class Beer
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public Brewery Brewery { get; set; }
    }
}
