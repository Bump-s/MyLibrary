
namespace MyLibrary
{
    class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public int? PublishYear { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author {get; set;}

        public void BookInfo(Book book)
        {
            System.Console.WriteLine($"{book.BookId}. Название: {book.BookTitle}, Жанр: {book.BookGenre}, Год публикации: {book.PublishYear}, Автор: {book.Author.AuthorLastName} {book.Author.AuthorName}");
        }
    }
}
