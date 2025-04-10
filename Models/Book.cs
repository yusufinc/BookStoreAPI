﻿namespace BookstoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }  // CategoryId'yi ekle
        public Category Category { get; set; }  // Category ile ilişki
    }
}
