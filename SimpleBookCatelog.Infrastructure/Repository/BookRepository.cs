using Microsoft.EntityFrameworkCore;
using SimpleBookCatelog.Application.Interfaces;
using SimpleBookCatelog.Domain.Entitys;
using SimpleBookCatelog.Infrastructure.AppDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatelog.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleBookDBContext _dbContext;
        public BookRepository(IDbContextFactory<SimpleBookDBContext> factory)
        {
            _dbContext= factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if(book is not null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var books= await _dbContext.Books.ToListAsync();
            return books;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
