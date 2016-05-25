﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lab2
{
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * the main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
        {
            Person person;

            // create a new instance for the Person class
            person = new Person();

            Console.WriteLine(person.Name);

            // set a value in the Name properly of the Person class
            person.Name = ("Meer");

            // get the Name Value and print to console
            Console.WriteLine("{0} says hello", person.Name);
        }
    }
}
