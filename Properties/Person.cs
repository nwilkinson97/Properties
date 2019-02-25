using System;

namespace Properties
{
    public class Person
    {
	   public Person(DateTime birthDate)
	   {
		  BirthDate = birthDate;
	   }
	   public DateTime BirthDate { get; private set; }

	   public int Age
	   {
		  get
		  {
			 var timespan = DateTime.Today - BirthDate;
			 var years = timespan.Days / 365;

			 return years;
		  }
	   }
    }
}
