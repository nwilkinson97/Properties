using System;

namespace Properties
{
    public class Person
    {
	   public string Name { get; set; }
	   public string UserName { get; set; }
	   public DateTime BirthDate { get; private set; }

	   public Person(DateTime birthDate)
	   {
		  BirthDate = birthDate;
	   }

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
