using Domain.Models;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
