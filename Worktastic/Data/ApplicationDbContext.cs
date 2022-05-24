using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Worktastic.Models;

namespace Worktastic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Jobposting> JobPostings { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
