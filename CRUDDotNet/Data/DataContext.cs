using CRUDDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDDotNet.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Person> Persons { get; set; }
}

