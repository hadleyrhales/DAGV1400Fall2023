using System;
					
public class Program
{
	// calling TempAdvise class
	public TempAdvise myAdvisor;
	
	public void Main()
	{
		// establishing that myAdvisor is connected to TempAdvise class and executing the function TempCheck within that class
		myAdvisor = new TempAdvise();
		myAdvisor.TempCheck();
	}
	
}

public class TempAdvise {
	
	// TempCheck function
	public void TempCheck() {

		// asking user for input and using the converted input as the tempInput variable
		Console.WriteLine("What is the temperature today in Celcius?");
		int tempInput = Convert.ToInt32(Console.ReadLine());
		
		// using if else statement to display the correct response for if the temp is over 30 and under 30
		if(tempInput >= 30) {
			Console.WriteLine("Be sure to drink lots of water today and don't stay out in the sun too long.");
		} else {
			Console.WriteLine("Be sure to enjoy today's pleasant weather.");
		}
	}
}