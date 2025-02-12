using Domain.Models;

namespace lab4_test;

[TestClass]
public class Task3
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestBookEmptyTitle()
    {
        var book = new Book()
        {
            Title = "",
            Author = "John Doe"
        };
        book.Validate();
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestMagazineNegativeIssue()
    {
        var magazine = new Magazine()
        {
            Title = "Invalid",
            Author = "Jane Doe",
            IssueNumber = -1
        };
        magazine.Validate();
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestTextBookEmptySubject()
    {
        var textbook = new TextBook()
        {
            Title = "Learning C#",
            Author = "John Doe",
            Subject = ""
        };
        textbook.Validate();
    }
}
