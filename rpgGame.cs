// Healthbars
int playerHealth = 100;
int monsterHealth = 100;

//vairables to generate random atk or healing numbers
int atkPower = Random.Shared.Next(1, 21);
int healPower = Random.Shared.Next(1,11);

bool allAlive = true;
while (allAlive)
{
    Console.WriteLine("Your turn:");
    Console.WriteLine("");
    Console.WriteLine("press 1 to attack.\npress 2 to heal.");
    
    int userNum;
    
    while (int.TryParse(Console.ReadLine(), out userNum) == false || (userNum != 1 && userNum != 2))
    {
        Console.WriteLine("Wrong input, try again...");
    }
    if (userNum == 1)
    {
        monsterHealth = monsterHealth - atkPower;
        Console.WriteLine($"You attack and deal {atkPower} dmg to the monster\n monster has {monsterHealth} health left");
    }
    else if (userNum == 2)
    {
        playerHealth = playerHealth + healPower;
        Console.WriteLine($"You used heal ({healPower}) you now have {playerHealth} health left");
    }



}