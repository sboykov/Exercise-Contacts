using LiteDB;

namespace SingleStone.API.LiteDb
{
    public interface IDbContext
    {
        LiteDatabase Database { get; }
    }
}