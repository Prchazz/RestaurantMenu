using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RestaurantMenu
{
    class Program

    {

       static void Main(string[] args)
        {
            
            Menu.PrintMenu();
            MenuItem.NewItem();
            Console.WriteLine(Menu.GetTimeStamp(DateTime.Now));
        }
    }
}
