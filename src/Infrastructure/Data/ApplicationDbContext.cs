using System.Reflection;
using GoatFarmManagement.Application.Common.Interfaces;
using GoatFarmManagement.Domain.Entities;
using GoatFarmManagement.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoatFarmManagement.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TodoList> TodoLists => Set<TodoList>();

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
