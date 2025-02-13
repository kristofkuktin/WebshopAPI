﻿using System.ComponentModel.DataAnnotations;

namespace WebshopAPI.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock {  get; set; }
    }
}
