using Microsoft.EntityFrameworkCore;
using BlazingPizza.Model;

namespace BlazingPizza.Data;

public class PizzaStoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<PizzaSpecial> Specials { get; set; }
}