namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public static Author FindAuthor(List<Author> authors,string author_name) 
        {
            return authors.Where(a => a.Name == author_name).FirstOrDefault();
        }
    }
}
