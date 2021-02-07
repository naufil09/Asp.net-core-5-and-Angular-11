using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence
{
    public class AdminApplicationDbContext : DbContext
    {
        public AdminApplicationDbContext(DbContextOptions<AdminApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
