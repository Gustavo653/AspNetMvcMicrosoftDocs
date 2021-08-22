using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetMvcMicrosoftDocs.Models;

namespace AspNetMvcMicrosoftDocs.Data
{
    public class AspNetMvcMicrosoftDocsContext : DbContext
    {
        public AspNetMvcMicrosoftDocsContext (DbContextOptions<AspNetMvcMicrosoftDocsContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetMvcMicrosoftDocs.Models.Movie> Movie { get; set; }
    }
}
