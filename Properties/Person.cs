using System;

namespace Properties
{
    public class Person
    {
	   public DateTime BirthDate { get; set; }

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
