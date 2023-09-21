using System;
					
public class Program
{
	public void Main()
	{
		// generating random number and making it a variable
		Random rnd = new Random(); 
		int num = rnd.Next(1, 11);
		
		Console.WriteLine(num);
		
		// asking user for input and turning it into a variable
		Console.WriteLine("Guess a number between 1 and 10.");
		int guessNum = Convert.ToInt32(Console.ReadLine());
		
		// first for loop is executed when the user's input doesn't match the generated number
		for(int i = num; i != guessNum;){
			// the following for loop is executed when user's input is greater than the generated number
			for(int j = num; j > guessNum;){
				Console.WriteLine("Good guess, but it is incorrect. Try a higher number.");
				guessNum = Convert.ToInt32(Console.ReadLine());
			}
			// the following for loop is executed when user's input is less than the generated number
			for(int j = num; j < guessNum;){
				Console.WriteLine("Good guess, but it is incorrect. Try a lower number.");
				guessNum = Convert.ToInt32(Console.ReadLine());
			}
		}
		// second for loop is executed when user's input is equal to the generated number
		for(int i = num; i == guessNum;){
			Console.WriteLine("Congrats! You guessed the correct number, " + i + ".");
			break;
		}
	}
}