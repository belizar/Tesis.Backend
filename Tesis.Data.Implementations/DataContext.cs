using Microsoft.EntityFrameworkCore;
using System;

namespace Trekko.Data.Implementations
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}
