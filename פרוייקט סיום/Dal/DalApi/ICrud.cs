using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface ICrud<T>
    {
        public int Create(T item);
        public List<T> Read();

        public bool Update(T item, T OldItem);

        public int Delete(T item);
    }
}
