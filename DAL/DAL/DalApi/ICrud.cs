using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi
{
    public interface ICrud<T>
    {
        public  void Create(T item);

        public  void Delete();

        public  Task<List<T>> Read();

        public  void Update();
     
    }
}
