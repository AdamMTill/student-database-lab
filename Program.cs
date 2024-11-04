// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

string[] studentNames = new string[]
{
    "Daniel",
    "Andy",
    "Taj",
    "Min",
    "Adam",
    "Benia",
    "Michael",
    "Devipriya",
    "Syeda",
};

string[] hometowns = new string[]
{
    "Rome",
    "Traverse City",
    "India",
    "Troy",
    "Hamtramak",
    "Austin",
    "Paris",
    "Akron",
    "Birmingham",
};

string[] favoriteFood = new string[]
    {
    "sushi",
    "thai",
    "thai",
    "french fries",
    "pizza",
    "pasta",
    "banana pudding",
    "pizza",
    "burgers",
};

while (true)
{


    Console.WriteLine($"Greetings! Which student would you like to learn more about? Enter a number 1-9: " +
        $"Enter a number 1-{studentNames.Length}");

    string userInput = "";
    int arrayIndex = -1;

    bool output = false;

    while (output == false)
    {
        userInput = Console.ReadLine();

        if (int.TryParse(userInput, out arrayIndex) == true)
        {
            if (arrayIndex >= 1 && arrayIndex <= studentNames.Length)
            {
                output = true;
            }
            else
            {
                Console.WriteLine("Enter a number within the valid range.");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid number! Try again.");
        }
    }

    Console.WriteLine($"Student {userInput} is {studentNames[arrayIndex - 1]}.");
    Console.WriteLine("What would you like to know about them ? Enter \"hometown\" or \"favorite food\"");

    output = false;
    string userCategory = "";
    while (output == false)
    {
        userCategory = Console.ReadLine().ToLower().Trim();

        if (userCategory == "hometown" || userCategory == "favorite food")
        {
            output = true;
        }
        else
        {
            Console.WriteLine("That category does not exist.");
            Console.WriteLine("Enter \\\"hometown\\\" or \\\"favorite food\\\"");
        }
    }

    switch (userCategory)
    {
        case "hometown":
            Console.WriteLine($"{studentNames[arrayIndex - 1]} is from {hometowns[arrayIndex - 1]}");
            break;
        case "favorite food":
            Console.WriteLine($"{studentNames[arrayIndex - 1]} favorite food is {favoriteFood[arrayIndex - 1]}");
            break;
    }

    Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\": ");

    string userAnswer = Console.ReadLine().ToLower().Trim();

    if (userAnswer != "y")
    {
        break;
    }
}

Console.WriteLine("Press any key to exit the application. Thank you for your time!");
Console.ReadKey();