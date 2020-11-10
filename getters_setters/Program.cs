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
            //below would return 'Liam'
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
        //Why Encapsulation?
        //Better control of class members (reduce the possibility 
        //of yourself (or others) to mess up the code)
        //Fields can be made read-only (if you only use the get method), 
        //or write-only (if you only use the set method)
        //Flexible: the programmer can change one part of the code without affecting other parts
        //Increased security of data

    }
}
