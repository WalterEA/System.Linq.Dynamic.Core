﻿#if NETSTANDARD1_0 || NETSTANDARDAPP1_0
using Microsoft.EntityFrameworkCore;
#else
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
#endif

namespace System.Linq.Dynamic.Core.Tests.Helpers.Entities
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}