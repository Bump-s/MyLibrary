using System.Collections.Generic;
namespace MyLibrary
{
    class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName{ get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorPseudonym { get; set; }
        public string AuthorBirthDate { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public void AuthorInfo(Author author)
        {
            System.Console.WriteLine($"Id:{author.AuthorId}. {author.AuthorName} {author.AuthorLastName} ({author.AuthorPseudonym}), {author.AuthorBirthDate}");
        }
    }
}
