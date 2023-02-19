using Dal.DalApi;
using Dal.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplements
{
    internal class UserService : IUser
    {
        public int Create(User item)
        {
            dbcontext.Users.Add(item??throw new InvalidDataException());
            //  אפשר להחזיר את הuser החדש.
            return 1;
        }

        public int Delete(User item)
        {
            throw new NotImplementedException();
        }

        public List<string> GetSomthing()
        {
            throw new NotImplementedException();
        }

        public List<User> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(User item, User OldItem)
        {
            throw new NotImplementedException();
        }
    }
}
