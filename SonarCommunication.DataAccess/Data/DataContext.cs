using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Domain.Statements;


namespace SonarCommunication.DataAccess.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<Statment> Statments { get; set; }
    public DbSet<StatementImage> StatementImages { get; set; }
    
    //TODO: Сделать раелизацю DBSet, OnConfiguring, OnModelCreating (описать зависимости) 
}