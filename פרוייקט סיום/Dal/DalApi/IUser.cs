using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DO;
namespace Dal.DalApi
{
    internal interface IUser:ICrud<User>
    {
        public List<string> GetSomthing();
    }
}
