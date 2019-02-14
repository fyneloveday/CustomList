using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomList<int> custom = new MyCustomList<int>();

            custom.Add(5);
            custom.Add(10);
            custom.Add(15);
            custom.Add(20);
            custom.Add(25);
            custom.Add(30);
            custom.Add(35);
            custom.Add(40);
            custom.Add(45);
            custom.Add(50);



            //List<int> userList = new List<int>();
            //userList.Add(5);
            //userList.Add(10);
            //userList.Add(15);
            //userList.Add(20);
            //userList.Add(25);

            //userList.Remove(5);
            //userList.Remove(20);
        }
    }
}
