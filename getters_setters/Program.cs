using System;

namespace getters_setters
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
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
            //myObj.Name = "Liam";
            // Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj);
        }
    }
}
