using System;
namespace CombatGame{
class ProgramCombatgame
{
    public static void Main()
    {
        // Customize player and enemy attributes
        string playerName = GetUserInput("Player Name: ");
        int playerHealth = GetIntInput("Player Health: ");
        int playerAttack = GetIntInput("Player Attack: ");
        int playerDefense = GetIntInput("Player Defense: ");

        string enemyName = GetUserInput("Enemy Name: ");
        int enemyHealth = GetIntInput("Enemy Health: ");
        int enemyAttack = GetIntInput("Enemy Attack: ");
        int enemyDefense = GetIntInput("Enemy Defense: ");

        // Main game loop
        while (playerHealth > 0 && enemyHealth > 0)
        {
            // Player's turn
            AttackTarget(playerName, playerAttack, playerDefense, enemyName, ref enemyHealth);
            DisplayCharacterStats(enemyName, enemyHealth);

            // Check for victory
            if (enemyHealth <= 0)
            {
                Console.WriteLine($"{playerName} wins!");
                break;
            }

            // Enemy's turn
            AttackTarget(enemyName, enemyAttack, enemyDefense, playerName, ref playerHealth);
            DisplayCharacterStats(playerName, playerHealth);

            // Check for defeat
            if (playerHealth <= 0)
            {
                Console.WriteLine($"{enemyName} wins!");
                break;
            }
        }
    }

    public static void AttackTarget(string attackerName, int attackerAttack, int targetDefense, string targetName, ref int targetHealth)
    {
        int damage = Math.Max(0, attackerAttack - targetDefense);
        targetHealth -= damage;
        Console.WriteLine($"{attackerName} attacks {targetName} for {damage} damage!");
    }

   public static void DisplayCharacterStats(string name, int health)
    {
        Console.WriteLine($"{name} Health: {health}");
    }

    public static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static int GetIntInput(string prompt)
    {
        Console.Write(prompt);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Please enter a valid number.");
            Console.Write(prompt);
        }
        return result;
    }
}
}
