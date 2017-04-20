using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        interface ImyInterfance
    {
        string ID
        {
            get;
            set;
        }
        string Name
        {   

            get;
            set;
        }
        void ShowInfo();
       {
        Console.WriteLine("happy\t happy");
        Console.WriteLine(ID+"\t"+name);
        Console.WriteLine(ID+"\t"+ID); 
        Console.WriteLine("happy\t year"); 
       }
    }

    }
}
