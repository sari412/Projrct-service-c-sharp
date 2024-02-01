using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface BLICrud<T>
    {
        public void Create(T item);

        public void Delete(T item);

        public Task<List<T>> Read();

        public void Update(T item);
    }
}
