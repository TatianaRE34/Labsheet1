﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetClassLibrary
{
    public class Class1
    {
        public enum Categories
        {

            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100,

        }
        public void DisplayCategories()
        {
            int count = 0;
            int[] values = (int[])Enum.GetValues(typeof(Categories));
            foreach (var name in Categories.GetNames(typeof(Categories)))
            {
                if (name == "E")
                {
                    Console.WriteLine("Category:" + name + " has range 0 -" + values[count]);
                }
                else
                {
                    Console.WriteLine("Category:" + name + " has range " + ((values[count - 1]) + 1) + " - " + values[count]);

                }
                count++;
            }
        }

        public void CheckRange(int inputValue)
        {
            //int[] value = (int[])Enum.GetValues(typeof(Categories));
            //int count = 0;
            //foreach (var name in Categories.GetNames(typeof(Categories)))
            //{
            //    Console.WriteLine("count: ", count);
            //    Console.WriteLine("Current val: ", value[count]);
            //    Console.WriteLine("Previous val: ",value[count - 1]);
            //    if ((inputValue >= 0) && (inputValue <= value[count]))
            //    {

            //        Console.WriteLine(name);
            //        break;
            //    }
            //    else if((inputValue >(value[count-1])) && (inputValue <= value[count]))
            //    {
            //        Console.WriteLine(name);
            //        break;

            //    }
            //    count++;
            //}
            int[] values=(int[])Enum.GetValues(typeof(Categories));
            int count = 0;
            int lower = 0;
            
            foreach (var name in Categories.GetNames(typeof(Categories)))
            {
                //Console.WriteLine(name+ " "+ count);
                //Console.WriteLine("Current val: "+ values[count]);
                if ((inputValue >= lower) && (inputValue <=values[count])){
                    Console.WriteLine("The category is " + name);
                    break;
                }
                else
                {
                    lower = values[count] + 1;
                    count++;
                }
                 
                
            }
        }
        public void RunCode()
        {
            //enter the
            int intVal;
            do
            {
                //ask user input
                Console.WriteLine("Enter a number between 1 and 100");
                intVal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                DisplayCategories();
                CheckRange(intVal);
                Console.WriteLine();
            } while (intVal!= - 1);
        }
    }
}
