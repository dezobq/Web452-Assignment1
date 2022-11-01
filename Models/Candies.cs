using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Candies
    {
        public int Id { get; set; }
        public string Candie { get; set; }
        public string Descripion { get; set; }
        public decimal Price { get; set; }
    }
}
