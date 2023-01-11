using Microsoft.EntityFrameworkCore;

namespace CurrencyConverterTask
{
    internal class ConverterContext : DbContext
    {
        public DbSet<LogModel> logModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = $@"{AppDomain.CurrentDomain.BaseDirectory}/../../../ConverterDb.db";
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
