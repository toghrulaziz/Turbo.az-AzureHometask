using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace turboazAzureHometask.Models;

public partial class TurboazDbContext : DbContext
{
    public TurboazDbContext()
    {
    }

    public TurboazDbContext(DbContextOptions<TurboazDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:azurehometasksdb.database.windows.net,1433;Initial Catalog=TurboazDb;Persist Security Info=False;User ID=toghrulaziz;Password=Toghrul1609;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
