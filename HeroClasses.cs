using System;

public class Program
{	
	public static void Main()
	{
		Hero heroOne = new Hero();
		Hero heroTwo = new Hero();
		Hero heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.specialAttack = "Plasma Explosion";
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.specialAttack = "Laser Vision";

		heroThree.health = 6;
		heroThree.powerLevel = 8;
		heroThree.specialAttack = "Blink";
		
		Console.WriteLine("Hero One Health: " + heroOne.health);
		Console.WriteLine("Hero One Power Level: " + heroOne.powerLevel);
        Console.WriteLine("Hero One Special Attack: " + heroOne.specialAttack);
		
		Console.WriteLine("Hero Two Health: " + heroTwo.health);
		Console.WriteLine("Hero Two Power Level: " + heroTwo.powerLevel);
        Console.WriteLine("Hero Two Special Attack: " + heroTwo.specialAttack);

		Console.WriteLine("Hero Three Health: " + heroThree.health);
		Console.WriteLine("Hero Three Power Level: " + heroThree.powerLevel);
        Console.WriteLine("Hero Three Special Attack: " + heroThree.specialAttack);
	}
}

public class Hero
{
	public int health;
	public int powerLevel;
    public string specialAttack;
}
}
