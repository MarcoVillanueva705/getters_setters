using System;

namespace getters_setters
{
    class Person
    {
        private string name = "jojo"; // field

        public string Name   // property
        {
            get { return name; }

            //commenting out below would be read only or 'get'
            //would return 'jojo'
            //set
            //{
            //    if (value != "jojo")
            //    {
            //        name = value;
            //    }
                 

            //}

            //but if you also have 'set', you can assign a new value to 'Person.Name'
            //belwo would return 'Liam'
            set { name = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //.WriteLine("Hello World!");
            //code will go here for Sunday
            //will start with get set properties
            Person myObj = new Person();
            myObj.Name = "Liam";
            // Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj.Name);
        }
    }
}
