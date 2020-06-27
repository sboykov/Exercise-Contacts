using LiteDB;
using Microsoft.Extensions.Options;
using SingleStone.API.LiteDb;

namespace SingleStone.API
{
    public class DbContext : IDbContext
    {
        public LiteDatabase Database { get; }

        public DbContext(IOptions<DbOptions> options)
        {
            Database = new LiteDatabase(options.Value.DatabaseLocation);
        }
    }
}