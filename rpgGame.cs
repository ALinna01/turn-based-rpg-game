
bool isRunning = true;
while (isRunning)
{
Console.Clear();

// Healthbars
int playerHealth = 100;
int monsterHealth = 100;

Console.WriteLine("");
Console.WriteLine("Villager: Oh traveler help!!! The monster is attacking our village!!!");
Console.ReadLine();
Console.WriteLine("You can defeat the evil monster by attacking it, but be careful if you are low on health try to heal yourself!!");
Console.ReadLine();
Console.WriteLine("Are you ready? Then go and defend the village!!");
Console.ReadLine();


bool allAlive = true;
while (allAlive)
{

//moved the variables (NOT HEALTHBARS BECAUSE THEY WOULD RESTART EACH ATK ROUND) inside while loop so they generate new numbers each round



 //vairables to generate random atk or healing numbers FOR HERO
    int atkPower = Random.Shared.Next(1, 21);
    int healPower = Random.Shared.Next(1,11);

//FOR MONSTER
    int atkPower1 = Random.Shared.Next(1, 21);
    int healPower1 = Random.Shared.Next(1,11);

//Variable for monster to choose wheter to attack or heal
    int monsterChoice = Random.Shared.Next(1,3);



    Console.WriteLine("Your turn:");
    Console.WriteLine("");
    Console.WriteLine("press 1 to attack.\npress 2 to heal.");
    
    int userNum;
    
    while (int.TryParse(Console.ReadLine(), out userNum) == false || (userNum != 1 && userNum != 2))
    {
        Console.WriteLine("Wrong input, try again...");
    }
    if (userNum == 1 && playerHealth != 0)
    {

//using Math.Clamp to ensure the health min value is 0 and max value is 100
        monsterHealth = Math.Clamp(monsterHealth - atkPower, 0, 100);
        Console.WriteLine($"You attack and deal {atkPower} dmg to the monster\nmonster has {monsterHealth} health left");
        Console.ReadLine(); 

//Adding monster attack player scenarios... and adding them under usernum 1 and usernum 2 so random monsterchoice happens whatever number player chooses
        if (monsterChoice == 1 && monsterHealth != 0)
        {
        playerHealth = Math.Clamp(playerHealth - atkPower1, 0, 100);
        Console.WriteLine($"Monster attacked you and dealt {atkPower1} dmg to you\nyou now have {playerHealth} health left");
        Console.ReadLine();
        }

        else if (monsterChoice == 2 && monsterHealth != 0)
            {
                monsterHealth = Math.Clamp(monsterHealth + healPower1, 0,100);
                Console.WriteLine($"Monster used heal ({healPower1}) it now has {monsterHealth} health left");
                Console.ReadLine();
            }

        }
        
    

    else if (userNum == 2 && playerHealth != 0)
    {
        playerHealth = Math.Clamp(playerHealth + healPower, 0,100);
        Console.WriteLine($"You used heal ({healPower}) you now have {playerHealth} health left");
        Console.ReadLine();


        if (monsterChoice == 1 && monsterHealth != 0)
        {
        playerHealth = Math.Clamp(playerHealth - atkPower1, 0, 100);
        Console.WriteLine($"Monster attacked you and dealt {atkPower} dmg to you\nyou now have {playerHealth} health left");
        Console.ReadLine();
        }

        else if (monsterChoice == 2 && monsterHealth != 0)
            {
                monsterHealth = Math.Clamp(monsterHealth + healPower1, 0,100);
                Console.WriteLine($"Monster used heal ({healPower}) it now has {monsterHealth} health left");
                Console.ReadLine();
            }

        }
        if(monsterHealth <= 0)
    {
        allAlive = false;
        Console.WriteLine("Horray you defeated the monster!!");
    }
        else if(playerHealth <= 0)
    {
        allAlive = false;
        Console.WriteLine("You failed to slay the monster and died in battle");
    }



}
                //Ending the isRunning loop & making sure the user inputs letter y or n.
                Console.WriteLine("");
                Console.WriteLine("Do you wish to try again? y/n");
                string yesNo = Console.ReadLine();
                
                while (yesNo != "y" && yesNo != "n")
                {
                    Console.WriteLine("invalid input!!! enter either 'y' or 'n!'");
                    yesNo = Console.ReadLine();
                }
                if(yesNo == "n")
                {
                    isRunning = false; //ends the program loop
                    Console.WriteLine("Thank you for playing!!!");
                }
                
}


