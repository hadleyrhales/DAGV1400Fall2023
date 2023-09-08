
/* I do not know how to have a Console.WriteLine command show up
before the user has to input into the console, but I tried my best
to incorporate user input. */
public class Track
{
	public CarAttribute goKart;
	public CarUpgrade betterEngine;
	
	public void Main()
	{
		goKart = new CarAttribute();
		betterEngine = new CarUpgrade();
		
		Console.WriteLine("Go-kart power is " + goKart.horsePower + ".");
		Console.WriteLine("Acceleration rate is " + goKart.accelerationRate + ".");
		
		goKart.betterEngineState = true;
		goKart.accelerationRate += betterEngine.engineUpgrade;
		
		Console.WriteLine("Better Engine has been equipped.");
		Console.WriteLine("Go-Kart acceleration rate is now " + goKart.accelerationRate + ".");
		
		Console.WriteLine("Go-Kart power is now " + goKart.horsePower * betterEngine.powerMultiplier);
		
		Console.WriteLine("Run again with a different input to experiment with go-kart power.");
	}
}

public class CarAttribute
{
	public int horsePower = 70;
	public float accelerationRate = 2.5f;
	public bool betterEngineState = false;
}

public class CarUpgrade
{
	public float engineUpgrade = 3.5f;
	public int powerMultiplier = Convert.ToInt32(Console.ReadLine());
}