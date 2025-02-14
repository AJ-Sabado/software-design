using lab5.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(textBoxAuthorName.Text, textBoxBookTitle.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new AppDbContext())
            {
                var author = new Author() { Name = authorName };
                var book = new Book() { Title = bookTitle, author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetAllBooksWithAuthors()
        {
            using (var context = new AppDbContext())
            {
                var booksWithAuthors = context.Books
                    .Include(book => book.author)
                    .Select(book => $"{book.Title} by {book.author.Name} - Id: {book.BookId}")
                    .ToList();
                return booksWithAuthors;
            }
        }


        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            var booksWithAuthors = GetAllBooksWithAuthors();
            listBoxBooks.DataSource = booksWithAuthors;
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new AppDbContext())
            {
                var book = context.Books.Include(book => book.author).FirstOrDefault(book => book.BookId == bookId);

                if (book != null)
                {
                    if (!string.IsNullOrEmpty(newTitle))
                        book.Title = newTitle;
                    if (!string.IsNullOrEmpty(newAuthorName))
                        book.author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text);
            UpdateBookAndAuthor(bookId, textBoxBookTitle.Text, textBoxAuthorName.Text);
            MessageBox.Show("Book and Author updated successfuly!");
        }

        public void DeleteBook(int bookId)
        {
            using (var context = new AppDbContext())
            {
                var book = context.Books.Include(book => book.author).FirstOrDefault(book => book.BookId == bookId);

                if (book != null)
                    context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text);
            DeleteBook(bookId);
            MessageBox.Show("Book deleted successfuly!");
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new AppDbContext())
            {
                var booksWithAuthors = context.Books
                    .Where(book => book.author.Name == authorName)
                    .Include(book => book.author)
                    .Select(book => $"{book.Title} by {book.author.Name} - Id: {book.BookId}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            var booksWithAuthors = SearchBooksByAuthor(textBoxAuthorName.Text);
            listBoxBooks.DataSource = booksWithAuthors;
        }
    }
}
