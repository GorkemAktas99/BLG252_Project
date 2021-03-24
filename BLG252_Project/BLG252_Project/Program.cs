using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BLG252_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 1;
            string _fear;
            Data data = new Data();
            data.Reading();
            while (select != 0)
            {
                Console.WriteLine("Please select a process");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1-Show All Table");
                Console.WriteLine("2-Show Filtered Fear");
                Console.WriteLine("3-Show Success Proportion of a Fear");
                Console.WriteLine("0-Quit");
                Console.WriteLine("---------------------------");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        data.ShowData();
                        Console.WriteLine("Please enter anything for continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the fear");
                        _fear = Console.ReadLine();
                        data.CollectFear(_fear);
                        Console.WriteLine("Please enter anything for continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Please enter the fear");
                        _fear = Console.ReadLine();
                        Console.WriteLine(data.OvercomingFear(_fear) + " %");
                        Console.WriteLine("Please enter anything for continue");
                        Console.ReadLine();
                        break;
                    case 0: Console.WriteLine("Please Wait, Closing...");
                        break;
                    default:
                        Console.Error.WriteLine("Wrong Process");
                        Console.WriteLine("Please enter anything for continue");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}