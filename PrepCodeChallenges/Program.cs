namespace PrepCodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CodeChallenge1();
        }

        static void CodeChallenge1()
        {
            Console.WriteLine("Code Challenge 1");

            int[] numbers = new int[5];
            Console.WriteLine("Choose 5 numbers between 1 and 10");

            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                    while (numbers[i] <= 0 || numbers[i] > 10)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("Your numbers are: ");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Choose a number from the array:");
                int choice = Convert.ToInt32(Console.ReadLine());

                int score = 0;
                if (!numbers.Contains(choice))
                {
                    Console.WriteLine("Your score is: 0");
                }
                else
                {
                    foreach (int number in numbers)
                    {
                        if (number == choice)
                        {
                            score += number;
                        }
                    }
                    Console.WriteLine("Your score is: " + score);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Please try again.");
                Console.WriteLine(e.ToString());
            }
        }
    }
}