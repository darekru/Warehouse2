﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.App.Abstract;
using Warehouse.Domain.Common;

namespace Warehouse.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity



    {
        public List<T> Items { get; set; }
        public BaseService() 
        {
            Items = new List<T>();  
        }

        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
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
