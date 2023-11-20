using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of test cases (N):");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter the words for Case {i}:");
                string inputLine = Console.ReadLine();

                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine($"Invalid input for Case {i}");
                    continue;
                }

                string reversedWords = ReverseWords(inputLine);
                Console.WriteLine($"Case {i}: {reversedWords}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid number for the number of test cases.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
