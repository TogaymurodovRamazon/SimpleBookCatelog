﻿using SimpleBookCatelog.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatelog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
        Task<List<Book>> GetAllAsync();

        Task<Book> GetByIdAsync(int id);
        Task UpdateAsync(Book book);
        Task DeleteByIdAsync(int id);
    }
}
