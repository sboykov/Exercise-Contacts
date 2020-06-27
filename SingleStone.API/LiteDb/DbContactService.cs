using LiteDB;
using SingleStone.API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SingleStone.API.LiteDb
{
    public class DbContactService : IDbContactService
    {

        private LiteDatabase _liteDb;

        public DbContactService(IDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }

        public IEnumerable<Contact> FindAll()
        {
            var result = _liteDb.GetCollection<Contact>("Contact")
                .FindAll();
            return result;
        }

        public Contact FindOne(int id)
        {
            return _liteDb.GetCollection<Contact>("Contact")
                .Find(x => x.Id == id).FirstOrDefault();
        }

        public int Insert(Contact contact)
        {
            return _liteDb.GetCollection<Contact>("Contact")
                .Insert(contact);
        }

        public bool Update(Contact contact)
        {
            return _liteDb.GetCollection<Contact>("Contact")
                .Update(contact);
        }

        public int Delete(int id)
        {
            return _liteDb.GetCollection<Contact>("Contact")
                .Delete(x => x.Id == id);
        }
    }

}
