using SingleStone.API.Entities;
using System.Collections.Generic;

namespace SingleStone.API.LiteDb
{
    public interface IDbContactService
    {
        int Delete(int id);
        IEnumerable<Contact> FindAll();
        Contact FindOne(int id);
        int Insert(Contact contact);
        bool Update(Contact contact);
    }
}