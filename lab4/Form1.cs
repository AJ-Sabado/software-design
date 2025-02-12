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
                Platform = "Kindle"
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
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }
        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";

        }
    }
    public class Ebook : Book
    {
        public string? Platform { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Platform: {Platform}";
        }
    }
    public class TextBook : Book
    {
        public string? Subject { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Subject: {Subject}";
        }
    }
    public class Audiobook : Book
    {
        public string? Narrator { get; set; }
        public int Duration { get; set; }
        public override string GetInfo()
        {
            return $"{Title}, narrated by {Narrator} - Duration: {Duration} minutes";
        }
    }
}
