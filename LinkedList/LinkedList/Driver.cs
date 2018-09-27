using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       9/27/18 
/// Purpose:    Class Tester
/// </summary>
namespace LinkedListProject
{
    class Driver
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddEnding(10);
            list.AddEnding(8);
            list.AddEnding(9);
            list.AddEnding(4);
            //Since adding to front with each iteration, should add these particular values as if in reverse order
            list.AddToFront(1);
            list.AddToFront(2);
            list.AddToFront(3);
            list.AddToFront(4);

            list.Print();
            ReadKey();         
        }
    }
}
