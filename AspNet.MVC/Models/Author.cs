﻿namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Author()
        { 
            Books = new List<Book>();
        }
        public List<Book> FindBooks(List<Book> books) 
        {
            return books.Where(b => b.Author.Equals(this)).ToList();
        }
    }
}
