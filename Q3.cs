﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6
{
    internal class Qn3
    {
        static void Main(string[] args)
        {
            /* Write an executable program in C# that will hold the employee code and employee names available in 
             an Organization using Collections.When the data is displayed it should be in a sorted manner.Choose an
 appropiate type of Collection.*/
            SortedList sl = new SortedList();
            sl.Add(100, "Alan");
            sl.Add(103, "Stefin");
            sl.Add(102, "Amal");
            sl.Add(104, "Akhil");
            sl.Add(107, "Edwin");

            foreach (var item in sl.Keys)
            {
                Console.WriteLine($"Emp_Id:{item} Name:{sl[item]}");
            }
        }
    }
}
