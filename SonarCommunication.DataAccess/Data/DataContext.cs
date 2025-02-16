using System;
using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Domain.SearchGroups;
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
    public DbSet<SearchGroup> SearchGroups { get; set; }

    //TODO: Сделать раелизацю DBSet, OnConfiguring, OnModelCreating (описать зависимости) 

    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        opt.UseNpgsql($"Data Source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
        modelBuilder.Entity<SearchGroup>()
            .HasOne(sg => sg.SearchRequest)
            .WithMany(sr => sr.SearchGroups)
            .HasForeignKey(sg => sg.RequestId);

        modelBuilder.Entity<Task>()
            .HasOne(t => t.SearchGroup)
            .WithMany(sg => sg.Tasks)
            .HasForeignKey(t => t.GroupId);

        modelBuilder.Entity<Chat>()
            .HasOne(c => c.SearchGroup)
            .WithMany(sg => sg.Chats)
            .HasForeignKey(c => c.GroupId)
            .OnDelete(DeleteBehavior.SetNull);*/
    }
}