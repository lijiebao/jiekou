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
        Console.WriteLine("编号\t 姓名");
        Console.WriteLine(ID+"\t"+name);
       }
    }

    }
}
