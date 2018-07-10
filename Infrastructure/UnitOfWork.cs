using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using blog.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace blog.Infrastructure
{
    public class UnitOfWork
    {
        public TheBlogDb context;

        public UnitOfWork()
        {
            var options = new DbContextOptions<TheBlogDb>();
            context = new TheBlogDb(options);
        }

        public void Commit()
        {
            try
            {
                context.Database.BeginTransaction();

                if (context.ChangeTracker.HasChanges()) {
                    context.SaveChanges();
                }

                context.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                if (context.Database != null) {
                    context.Database.RollbackTransaction();
                }
                context.Dispose();
                throw new Exception($"SaveChanges failed:\r\n{0} \r\n {1} {ex}");
            }
        }
    }
}