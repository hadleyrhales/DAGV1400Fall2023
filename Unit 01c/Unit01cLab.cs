using System;
					
public class Program
{
	public void Main()
	{
		// asking user for input
		Console.WriteLine("How many rows do you want the pyramid to have?");
		// converting input into an integer and adding 1
		int rows = Convert.ToInt32(Console.ReadLine()) + 1;
		// console.writeline to separate input from output
		Console.WriteLine("Creating Number Pyramid...");
		
		// first for loop creates lines with numbers in ascending order
		// second for loop writes the appropriate quantity of numbers in each line
		for(int i = 0; i < rows;){
			for(int j = rows - i++; j < rows;){
				Console.Write(i - 1);
				j++;
			}
			Console.WriteLine();
		}
	}
}