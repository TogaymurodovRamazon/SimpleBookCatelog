using Microsoft.EntityFrameworkCore;
using SimpleBookCatelog.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatelog.Infrastructure.AppDBContext
{
    public class SimpleBookDBContext : DbContext
    {
        public SimpleBookDBContext(DbContextOptions<SimpleBookDBContext> options) :base(options) { }
        


        public virtual DbSet<Book> Books { get; set; }

    }
}
