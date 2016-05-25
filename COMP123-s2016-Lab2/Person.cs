using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lab2
{
    /**
    * This class defines a generic Person
    *
    * @class Person
    * @field _name {string}
    */
    public class Person
    {
        // Private Intance variables ++++++++++++++++++++++++++++++++++++
        private string _name;
        //private int _age;

        // Public properties ++++++++++++++++++++++++++++++++++++++++++++


        /**
        * This is a property for our _name field
        *
        * @property {string} Name
        */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        //public int Age
        //{
        //    get
        //    {
        //        return this._age;
        //    }
        //
        //    set
        //    {
        //        this._age = value = 26;
        //    }
        //}
        
        /**
        * This is the default empty constructor for the Persons Class
        *
        * @constructor Person
        */

        public Person()
        {
            this._name = "Meer";
        }

        /**
        * This is a constructor that takes name as a parameter and passes
        * it to the _name private instance variable
        *
        * @constructor Person
        * @param {string} name
        */

        public void SaysHelloMessage()
        {
            Console.WriteLine("{0}, says hello", this._name);
        }
    }
}
