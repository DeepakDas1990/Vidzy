using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbContext = new VidzyDbContext();
            DbContext.AddVideo("Zurassic World", new DateTime(2016, 9, 23), 1);
            DbContext.AddVideo("The Lord of The Rings", new DateTime(2001,6, 12), 4);
            DbContext.AddVideo("The Hateful Eight", new DateTime(2007, 8, 9), 4);
            DbContext.SaveChanges();
        }
    }
}
