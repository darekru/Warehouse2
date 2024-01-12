using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.App.Abstract;

namespace Warehouse.App.Common
{
    public class BaseService<T> : IService<T>


    {
        public List<T> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int AddItem(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(T item)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
