﻿using System;
using Microsoft.EntityFrameworkCore;
using RegisterApi;

namespace RegisterApi
{ 
    public class BookContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BookContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("BooksApi"));
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
     
    }
}

