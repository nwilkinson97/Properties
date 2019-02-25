using System;

namespace Properties
{
    class Program
    {
	   static void Main(string[] args)
	   {
		  var person = new Person(new DateTime(1997, 1, 12));
		  Console.WriteLine(person.Age);
	   }
    }
}