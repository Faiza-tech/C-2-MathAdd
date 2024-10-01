/*Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine($"Dice roll is: {roll}");*/

/*
// This is stateless: 
Console.WriteLine("");

// This is stateful because it depends on the internal state of the Random object:
Random dice = new Random();
int roll = dice.Next(1, 7); // Stateful method due to Random's internal state
Console.WriteLine($"Dice roll is: {roll}"); // Stateless - just prints the result
*/


// Random coins = new Random();  // Creating an instance of Random
//int money = coins.Next();     // Correct way to call the Next() method

Random coins = new Random();
int money = coins.Next(1,10);
Console.WriteLine($"Coins roll is: {money}");

Console.WriteLine("****************");


Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//Code challenge: Implement a method of the Math class that returns the larger of two numbers

int firstValue = 500;
int secondValue = 600;

 // Use Math.Max to find the larger of the two numbers
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);


/* ## Important
This exercise makes extensive use of the System.Random class. You can refer to the Microsoft Learn module titled "Call methods from the .NET Class Library using C#" if you need a refresher how Random.Next() works.
*/