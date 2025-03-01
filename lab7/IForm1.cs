
using Domain.Models;

namespace lab7
{
    public interface IForm1
    {
        Task SaveBookAuthorWithHandling(string bookTitle, string authorName);
        bool Adding { get; set; }

        Task<List<string>> SearchBookByTitle(string bookTitle);

        void DisplaySearchResult(List<string> books);
    }
}