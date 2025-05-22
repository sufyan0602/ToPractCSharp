using System; // Import the System namespace, which gives access to things like Console

class Program // Define a class named Program (all C# programs need a class)
{
    static void Main() // Main method is the entry point — the first code that runs
    {
        // Ask the user what the weather is like
        Console.WriteLine("What is the weather like today? [Sunny, Rainy, Snowy]");

        // Read the user's response (can be null)
        string? weatherInput = Console.ReadLine();

        // If it's null, default to "Unknown"
        string weather = weatherInput ?? "Unknown";

        // Check if the user typed "Sunny"
        if (weather == "Sunny")
        {
            Console.WriteLine("Wear sunglasses!"); // Respond with sunny advice
        }
        // Check if the user typed "Rainy"
        else if (weather == "Rainy")
        {
            Console.WriteLine("Take an umbrella."); // Respond with rainy advice
        }
        // Check if the user typed "Snowy"
        else if (weather == "Snowy")
        {
            Console.WriteLine("Bundle up, it's cold!"); // Respond with snowy advice
        }
        // Catch any other input
        else
        {
            Console.WriteLine("I don't know that kind of weather..."); // Unknown weather
        }
    }
}