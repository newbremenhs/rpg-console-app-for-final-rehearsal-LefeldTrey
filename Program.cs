Random dice = new Random();

int monsterAC = 18;

Console.WriteLine("Press enter to roll your D20.");
Console.ReadLine();

int d20Roll = dice.Next(1, 21);
Console.WriteLine("You rolled a " + Convert.ToString(d20Roll) + ".");

if (d20Roll >= monsterAC)
{
    Console.WriteLine("You hit the monster.");
} else
{
    Console.WriteLine("You missed loser.");
}