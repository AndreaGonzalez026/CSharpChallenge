using System;

public class Program
{	
	public static void Main()
	{
		Weapon gun = new Weapon();
		Weapon grenade = new Weapon();
		Weapon knife = new Weapon();
		
		gun.speed = 2;
		gun.powerLevel = 2;
		gun.type = "Firearms";
		
		grenade.speed = 2;
		grenade.powerLevel = 3;
		grenade.type = "Thrown Weapon";

		knife.speed = 1;
		knife.powerLevel = 2;
		knife.type = "Hand to Hand";
		
		Console.WriteLine("Gun Speed: " + gun.speed);
		Console.WriteLine("Gun Power Level: " + gun.powerLevel);
        Console.WriteLine("Gun Type: " + gun.type);
		
		Console.WriteLine("Grenade Speed: " + grenade.speed);
		Console.WriteLine("Grenade Power Level: " + grenade.powerLevel);
        Console.WriteLine("Grenade Type: " + grenade.type);

		Console.WriteLine("Knife Speed: " + knife.speed);
		Console.WriteLine("Knife Power Level: " + knife.powerLevel);
        Console.WriteLine("Knife Type: " + knife.type);
	}
}

public class Weapon
{
	public int speed;
	public int powerLevel;
    public string type;
}
