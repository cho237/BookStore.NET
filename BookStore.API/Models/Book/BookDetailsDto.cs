﻿namespace BookStore.API.Models.Book
{
    public class BookDetailsDto
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
