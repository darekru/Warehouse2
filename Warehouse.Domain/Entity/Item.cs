using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Common;

namespace Warehouse.Domain
{
    public class Item : BaseEntity
    {
        //public int Id { get; set; } bo z BaseEntity

        public String Name { get; set; }

        public int TypeId { get; set; }

        public int Quantity {  get; set; }
        protected bool isLowInWarehouse;

        /*
        public void sayHello()
        {
            Console.WriteLine("Say Hello");
        }
        */
    }


}
