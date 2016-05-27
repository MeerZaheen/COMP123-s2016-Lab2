using System;
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
            // create a new instance of the Person class
            Console.WriteLine();

            Person Ashley = new Person();
            Ashley.Name = "Ashley";
            Ashley.Profession = "Nurse";
            Ashley.CollegeOrUniversity = "Ryerson University";
            Ashley.Age = 22;
            Ashley.SaysHello();
            Ashley.ShowAge();
            Ashley.ShowProfession();
            Ashley.ShowCollegeOrUniversity();

            Console.WriteLine();

            Person Meer = new Person("Meer");
            Meer.Profession = "Student";
            Meer.CollegeOrUniversity = "Centennial College";
            Meer.Age = 26;
            Meer.SaysHello();
            Meer.ShowAge();
            Meer.ShowProfession();
            Meer.ShowCollegeOrUniversity();

            Console.WriteLine();
        }
    }
}

        /* MY CODE MISTAKES

        public static void Main(string[] args)
        {
            Person person;

            // create a new instance for the Person class
            person = new Person();

            //Console.WriteLine(person.Name);

            // set a value in the Name properly of the Person class
            //person.Name = ("Meer");
            //person.Age = (26);

            // get the Name Value and print to console
            Console.WriteLine("{0} says hello", person.Name);
            Console.WriteLine("{0} is {1} years old", person.Name, person.Age);
        }
        */
