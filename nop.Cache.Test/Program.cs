using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.Cache.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //CacheHelper.Insert("name", "张三");
            string name = CacheHelper.Get<string>("name");
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
