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

public class Person
{
    /// <summary>
    /// Full Name of User
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// User Name assigned for login purposes
    /// </summary>
    public string UserName { get; set; }
    /// <summary>
    /// Set the Birthdate appropriately
    /// </summary>
    public DateTime BirthDate { get; private set; }
    /// <summary>
    /// DEFAULT Class Constructor for the Person Class. 
    /// </summary>
    /// <param name="birthDate">Assign the value of the property BirthDate on implementation of class</param>
    public Person(DateTime birthDate)
    {
	   BirthDate = birthDate;
    }

    public int Age
    {
	   get
	   {
		  //  get TimeSpan value showing how old a person is
		  var timespan = DateTime.Today - BirthDate;
		  //  Divide the TimeSpan.Days by Number of Days in a Year
		  var years = timespan.Days / 365;
		  //  Return Age of Person
		  return years;
	   }
    }
}
