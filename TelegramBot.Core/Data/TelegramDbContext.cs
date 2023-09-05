using Microsoft.EntityFrameworkCore;
using TelegramBot.Core.Entities;

namespace TelegramBot.Core.Data;
public class TelegramDbContext : DbContext
{
    public TelegramDbContext(DbContextOptions<TelegramDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}

