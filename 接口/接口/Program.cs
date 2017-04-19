using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 接口;

namespace 接口
{
    class Program : ImyIneterface
    {
        string id = "";
        string name = "";
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("编号\t 姓名");
            Console.WriteLine(ID + "\t" + name);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            ImyInterfance imyIneterface = program;
            imyIneterface.ID = "TMD";
            imyIneterface.Name = "放开那个女孩，让我来";
            imyIneterface.ShowInfo();

        }
    }
}

