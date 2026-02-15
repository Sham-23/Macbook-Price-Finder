using System;

namespace MacBookFinder.API.Models
{
    public class MacBook
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}