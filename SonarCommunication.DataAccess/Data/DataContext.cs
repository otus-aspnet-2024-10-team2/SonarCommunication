using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Domain.Statements;
using SonarCommunication.Core.Domain.VolontersManagment;


namespace SonarCommunication.DataAccess.Data;

public class DataContext : DbContext
{
    public string DbPath { get; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<Statment> Statments { get; set; }
    public DbSet<StatementImage> StatementImages { get; set; }

    public DbSet<Volunteer> Volunteers { get; set; }

    //TODO: Сделать раелизацю DBSet, OnConfiguring, OnModelCreating (описать зависимости) 

    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        opt.UseNpgsql($"Data Source={DbPath}");
    }
}