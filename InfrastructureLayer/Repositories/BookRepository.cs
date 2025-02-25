using Database.Data;
using DomainLayer.Models;

namespace InfrastructureLayer.Repositories
{
    public class BookRepository
    {
        private readonly DatabaseContext _dbContext;

        public BookRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Book book)
        { 
            
        }
    }
}
