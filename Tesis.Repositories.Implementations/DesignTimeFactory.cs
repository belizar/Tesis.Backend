using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<AlimaDataContext>
    {
        public AlimaDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlimaDataContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AlimaTest;Integrated Security=True");

            return new AlimaDataContext(optionsBuilder.Options);
        }
    }
}
