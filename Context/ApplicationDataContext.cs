using AMST4.Store.Shoes.Models.Entities;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// <author>VitorA</author>
/// </summary>
public class ApplicationDataContext : DbContext
{
public ApplicationDataContext(dbContextoptions<ApplicationDataContext> options):base(options){}

public DbSet<Color> Color { get; set; }
public DbSet<Product> Product { get; set; }
public DbSet<Size> Size { get; set; }





}