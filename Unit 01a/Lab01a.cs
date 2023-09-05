public class Program
{
	public ArmourStats chestPlate; // creating chestPlate object in ArmourStats class
	public ArmourUpgrade newUpgrade; // creating newUpgrade object in ArmourUpgrade class
	
	public void Main()
	{
		chestPlate = new ArmourStats(); // assigning chestPlate object with values of ArmourStats class
		newUpgrade = new ArmourUpgrade(); // assigning newUpgrade object with values of ArmourUpgrade class
		
		chestPlate.armourEqip = true; // Equipping chestPlate
		chestPlate.armourStrength += newUpgrade.upgradeStrength; // Adding armourStrength and upgradeStrength together for new armourStrength
		Console.WriteLine(chestPlate.armourPiece + " has been equipped.");
		Console.WriteLine(chestPlate.armourPiece + " has a strength of " + chestPlate.armourStrength + ".");
	}
}

public class ArmourStats
{
	public bool armourEqip = false; // inital equip state
	public int armourStrength = 50; // initial armourStrength
	public string armourPiece = "Chestplate"; // armourPiece name
}

public class ArmourUpgrade
{
	public int upgradeStrength = 10; // Upgrade value	
}