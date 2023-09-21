using System;
					
public class Program
{
	public void Main()
	{
		// asking user what their top 3 favorite foods are
		Console.WriteLine("What is your favorite food?");
		string faveOne = Console.ReadLine();
		
		Console.WriteLine("What is your second favorite food?");
		string faveTwo = Console.ReadLine();
		
		Console.WriteLine("What is your third favorite food?");
		string faveThree = Console.ReadLine();
		
		// creating an array with the user's answers to the previous questions
		string[] faveFoods = {faveOne, faveTwo, faveThree};
		
		// having a foreach loop use the array values to type multiple statement in the console
		foreach (string food in faveFoods) {
			Console.WriteLine("I love " + food + "!");
		}
	}
}