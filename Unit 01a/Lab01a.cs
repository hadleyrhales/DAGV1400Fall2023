public class Program
{
	public ArmourStats chestPlate;
	public ArmourUpgrade newUpgrade;
	
	public void Main()
	{
		chestPlate = new ArmourStats();
		newUpgrade = new ArmourUpgrade();
		
		chestPlate.armourEqip = true;
		chestPlate.armourStrength += newUpgrade.upgradeStrength;
		Console.WriteLine(chestPlate.armourPiece + " has been equipped.");
		Console.WriteLine(chestPlate.armourPiece + " has a strength of " + chestPlate.armourStrength + ".");
	}
}

public class ArmourStats
{
	public bool armourEqip = false;
	public int armourStrength = 50;
	public string armourPiece = "Chestplate";
}

public class ArmourUpgrade
{
	public int upgradeStrength = 10;	
}