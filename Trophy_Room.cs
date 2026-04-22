class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome Home, Dr. Doom. Here before you is a memory room of your greatest triumph's.\n");

        // Array of Marvel items
        string[] items =
        {
            "Captain America's Shield",
            "Mjolnir",
            "Arc Reactor",
            "Eye of Agamotto",
            "Black Panther's Habit",
            "Infinity Gauntlet"
        };

        // Matching rarity scores (0–100)
        int[] rarity =
        {
            70,   // Cap's Shield
            90,   // Mjolnir
            60,   // Arc Reactor
            85,   // Eye of Agamotto
            75,   // Panther Habit
            100   // Infinity Gauntlet
        };

        // Loop through the trophy case
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"Item: {items[i]}");

            // Call method to get rarity description
            string description = DescribeRarity(rarity[i]);

            Console.WriteLine($"Rarity Score: {rarity[i]} — {description}\n");
        }

        Console.WriteLine("End of Trophy Case. A true collector knows the value of every relic.");
    }

    // Method that accepts a parameter and returns a value
    static string DescribeRarity(int score)
    {
        if (score >= 95)
        {
            return "A mythical artifact of immeasurable power.";
        }
        else if (score >= 80)
        {
            return "A legendary relic known across the multiverse.";
        }
        else if (score >= 60)
        {
            return "A rare and highly valuable piece of Marvel history.";
        }
        else
        {
            return "A common but cherished collectible.";
        }
    }
}

