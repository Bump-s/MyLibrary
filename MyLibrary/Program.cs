using System.Collections.Generic;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var dataBase = new LibraryDbContext())
            {
                
                var author1 = new Author() { AuthorName = "Александр", AuthorLastName= "Пушкин", AuthorBirthDate="1799", AuthorPseudonym = "Иван Петрович Белкин", };
                dataBase.Authors.Add(author1);

                var author2 = new Author() { AuthorName = "Фёдор", AuthorLastName = "Тютчев", AuthorBirthDate = "1803", AuthorPseudonym = "Т.Ч.В.", };
                dataBase.Authors.Add(author2);
                dataBase.SaveChanges();

                var books = new List<Book>() 
                { 
                    new Book {BookTitle = "Дубровский", BookGenre = "Роман", PublishYear = 1833, AuthorId = author1.AuthorId},
                    new Book {BookTitle = "Капитанская дочка", BookGenre = "Роман", PublishYear = 1836, AuthorId = author1.AuthorId},
                    new Book {BookTitle = "Есть в осени первоначальной…", BookGenre = "Лирика", PublishYear = 1857, AuthorId = author2.AuthorId}
                };

                dataBase.Books.AddRange(books);
                dataBase.SaveChanges();

                foreach (var book in books)
                {
                    book.BookInfo(book);
                }

                System.Console.ReadLine();
            }
        }
    }
}
