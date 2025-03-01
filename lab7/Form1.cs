using Domain.Models;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form, IForm1
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Adding { get; set; } = false;

        private const int pageSize = 10;
        private int currentPage = 1;

        private async void Form1_Load(object sender, EventArgs e)
        {
            var books = await GetBooksByPage(currentPage);
            UpdateDisplay(books, currentPage);
        }

        private void UpdateDisplay(List<string> books, int pageNumber)
        {
            listBoxBooks.DataSource = books;
            labelPage.Text = $"Page: {pageNumber}";
        }

        public void DisplaySearchResult(List<string> books)
        {
            listBoxBooks.DataSource = books;
            labelPage.Text = $"Results: {books.Count()}";
        }

        private async Task<List<string>> GetBooksByPage(int pageNumber)
        {
            using (var context = new Context())
            {
                var books = await context.Books
                                         .Include(b => b.Author)
                                         .OrderBy(b => b.Id)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize)
                                         .Select(b => $"{b.Title} by {b.Author.Name}")
                                         .ToListAsync();
                return books;
            }
        }

        public async Task SaveBookAuthorWithHandling(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new Context())
                {
                    var author = new Author()
                    {
                        Name = authorName
                    };
                    var book = new Book()
                    {
                        Title = bookTitle,
                        Author = author
                    };

                    await context.Authors.AddAsync(author);
                    await context.Books.AddAsync(book);

                    await context.SaveChangesAsync();

                    MessageBox.Show("Book added successfuly!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        public async Task<List<string>> SearchBookByTitle(string bookTitle)
        {
            try
            {
                using (var context = new Context())
                {
                    var book = await context.Books
                                            .Include(b => b.Author)
                                            .Where(b => b.Title == bookTitle)
                                            .Select(b => $"{b.Title} by {b.Author.Name}")
                                            .ToListAsync();
                    return book;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return new List<string>();
            }
        }

        private async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPage(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async Task ImportBooksAsync(List<Book> books)
        {
            using (var context = new Context())
            {
                try
                { 
                    foreach (var book in books)
                    {
                        await context.Authors.AddAsync(book.Author);
                        await context.Books.AddAsync(book);
                        await context.SaveChangesAsync();
                    }
                    MessageBox.Show("Books imported successfuly!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }

        private async void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
                return;

            currentPage--;
            var books = await GetBooksByPage(currentPage);
            UpdateDisplay(books, currentPage);
        }

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPage(currentPage);
            if (books.Count() != 0)
            {
                UpdateDisplay(books, currentPage);
            }
            else
            {
                MessageBox.Show("Last page reached!");
                currentPage--;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!Adding)
            {
                var addBookForm = new AddBookForm(this);
                addBookForm.Show();
            }
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "TextFiles (*.txt)|.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfuly!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchBookForm = new SearchBookForm(this);
            searchBookForm.Show();
        }

        private async void buttonImport_Click(object sender, EventArgs e)
        {
            var books = new List<Book>();
            var openFileDialog = new OpenFileDialog()
            { 
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Import Book List"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var line = string.Empty;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        var elements = line.Split(" by ");
                        var newAuthor = new Author()
                        {
                            Name = elements[1]
                        };
                        var newBook = new Book()
                        {
                            Title = elements[0],
                            Author = newAuthor
                        };
                        books.Add(newBook);
                    }
                    await ImportBooksAsync(books);
                }
            }
        }
    }
}
