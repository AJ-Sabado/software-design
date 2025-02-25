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

        public async Task Add(Book book)
        { 
            
        }

        public async Task Update(Book book)
        { 
        
        }

        public async Task DeleteById(int id)
        { 
        
        }

        public async Task<ICollection<Book>> GetAll()
        { 
            var books = new List<Book>();
            return books;
        }
    }
}
