using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse2
{
    public class Item
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int TypeId { get; set; }

        public void sayHello()
        {
            Console.WriteLine("Say Hello");
        }
    }

    public class Item2 : Item
    {
    
        public void sayHello2()
        {
            Console.WriteLine("Say Hello 2");
        }

        public void sayHello ()
        {
            Console.WriteLine("Say Hello 3");
        }

    }

}
