using DomainLayer.Models;
using InfrastructureLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public async Task<List<string>> GetBooksAsync()
        {

            using (var dbContext = new DatabaseContext())
            {
                var books = await dbContext.Books.Include(b => b.Author)
                                                   .Select(b => $"Book Id:{b.Id}; {b.Title} by {b.Author.Name}")
                                                   .ToListAsync();
                return books;
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var dbContext = new DatabaseContext())
            {
                var author = new Author() { Name = authorName };
                var book = new Book() { Title = bookTitle };
                book.Author = author;
                await dbContext.Authors.AddAsync(author);
                await dbContext.Books.AddAsync(book);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateBookAndAuthor(int bookId, string newBookTitle, string newAuthorName)
        {
            using (var dbContext = new DatabaseContext())
            {
                var book = await dbContext.Books.Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.Id == bookId);
                if (book != null)
                {
                    book.Title = newBookTitle;
                    book.Author.Name = newAuthorName;
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteBookById(int bookId)
        {
            using (var dbContext = new DatabaseContext())
            {
                var book = await dbContext.Books.FirstOrDefaultAsync(b => b.Id == bookId);
                if (book != null)
                {
                    dbContext.Books.Remove(book);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task<List<string>> GetByTitle(string bookTitle)
        {
            using (var dbContext = new DatabaseContext())
            {
                var books = await dbContext.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title == bookTitle)
                    .Select(b => $"Book Id:{b.Id}; {b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return books;
            }
        }

        private async void buttonFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();
            listBoxBooks.DataSource = books;
        }

        private async void buttonAddBook_Click(object sender, EventArgs e)
        {
            await SaveBookAsync(textBoxBookTitle.Text.Trim(), textBoxAuthorName.Text.Trim());
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text.Trim());
            await UpdateBookAndAuthor(bookId, textBoxBookTitle.Text.Trim(), textBoxAuthorName.Text.Trim());
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text.Trim());
            await DeleteBookById(bookId);
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            var books = await GetByTitle(textBoxSearchTitle.Text.Trim());
            listBoxSearchResult.DataSource = books;
        }
    }
}
