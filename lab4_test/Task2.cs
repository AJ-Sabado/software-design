using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4_test;

[TestClass]
public class Task2
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestInvalidMagazineCreation()
    {
        var magazine = new Magazine()
        {
            Title = "Invalid",
            Author = "Jane Doe",
            IssueNumber = -1
        };
        magazine.Validate();
    }
}
