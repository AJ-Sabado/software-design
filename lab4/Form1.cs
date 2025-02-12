using Domain.Models;

namespace lab4
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

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }
        public string[] GetAllInfo(Book[] books)
        {
            List<string> results = new List<string>();
            foreach (var book in books)
            {
                results.Add(book.GetInfo());
            }
            return results.ToArray();
        }
        private void buttonShowBookList_Click(object sender, EventArgs e)
        {
            var magazine = new Magazine()
            {
                Title = "Daily Planet",
                Author = "Jona Jameson",
                IssueNumber = 34
            };
            var ebook = new Ebook()
            {
                Title = "A Feast for Crows",
                Author = "George R. R. Martin",
                FileSizeMB = 9
            };
            var textbook = new TextBook()
            {
                Title = "Object Oriented Programming",
                Author = "Jay Al",
                Subject = "Computer Science"
            };
            var audiobook = new Audiobook()
            {
                Title = "Lord of the Rings",
                Author = "J.R.R. Tolkien",
                Narrator = "Keanu Reaves",
                Duration = 300
            };
            Book[] books = { magazine, ebook, textbook, audiobook };
            string[] results = GetAllInfo(books);
            listBoxResults.DataSource = results;
        }
    }
}
