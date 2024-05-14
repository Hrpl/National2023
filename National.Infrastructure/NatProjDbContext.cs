using Microsoft.EntityFrameworkCore;
using National.Domen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem = National.Domen.Models.Problem;

namespace National.Infrastructure;

public class NatProjDbContext : DbContext
{ 
    public DbSet<CommentOnTask> CommentOnTasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Problem> Problems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NatProj;Trusted_Connection=true;");
    }
}
