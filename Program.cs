using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> list = new List<product>();
            list.Add(
                new product
                {
                    Id = 100,
                    Title = "Bat",
                    Price =  200,
                    Owner = "Yanshik"
                });
            list.Add(new product
            {
                Id = 101,
                Title = "Ball",
                Price = 200,
                Owner = "Sachin"
            });
            list.Add(new product
            {
                Id = 102,
                Title = "Bails",
                Price = 500,
                Owner = "gaurav"
            });
            list.Add(new product
            {
                Id = 103,
                Title = "Stumps",
                Price = 2000,
                Owner = "Nick"
            });

            //var Owner = list.Where(p => p.Price > 300).Select(p=>p.Owner).ToList();
            //Owner.ForEach(a => Console.WriteLine(a));
           var llist = (from r in list where r.Price > 300 select (r.Owner, r.Id)).ToList();
            llist.ForEach(a => Console.WriteLine(a));
        }
        
    }
}
