﻿using BookShop.Domain.Entities.Books;
using BookShop.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastucture.DbContexts;

public class BookShopDbContext : DbContext
{
    public BookShopDbContext(DbContextOptions<BookShopDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
}
    