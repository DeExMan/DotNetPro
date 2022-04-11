using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetPro.Core.Entities;
using DotNetPro.Core.Entities.Abstractions;
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace DotNetPro.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Triggers<Author>();
            Triggers<Book>();
            Triggers<Genre>();
            Triggers<Library>();
        }

        private void Triggers<TEntity>()
            where TEntity : class, IEntity
        {
            Triggers<TEntity, ApplicationDbContext>.Inserting += entry =>
            {
                entry.Entity.CreatedDate = DateTime.Now;
                entry.Entity.EditedDate = DateTime.Now;
            };

            Triggers<TEntity, ApplicationDbContext>.Updating += entry =>
            {
                entry.Entity.EditedDate = DateTime.Now;
            };
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return this.SaveChangesWithTriggersAsync(base.SaveChangesAsync, true, cancellationToken);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
    }
}
