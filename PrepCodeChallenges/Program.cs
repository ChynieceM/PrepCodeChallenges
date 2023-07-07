using Microsoft.VisualBasic;

namespace PrepCodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CodeChallenge1();
            //CodeChallenge2();
            //CodeChallenge3();
            CodeChallenge4();
        }

        /*  static void CodeChallenge1()
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
          }*/

        //code challenge 2
        /*static void CodeChallenge2()
        {
            int play = 0;
            do
            {
                Console.WriteLine("Code Challenge 2");
                Console.WriteLine("Choose a year to see if it's a leap year");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput % 4 == 0 || userInput % 100 > 0 && userInput % 400 == 0)
                {
                    Console.WriteLine("This is a leap year");
                }
                else
                {
                    Console.WriteLine("This is not a leap year");
                }
            } while (play == 0);
           
        }*/
        /*static void CodeChallenge3()
        {
            //perfect seq is non negativeintegers, and prod is = to the sum
            Console.WriteLine("Code Challenge 3");
            int[] array = new int[3];
            Console.WriteLine("Input 3 numbers to check if it's a perfect sequence or not");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); 
              
            }
            bool isPerfectSequence = true;
            int sumOf = array.Sum();
            int prodOf = array.Aggregate(1, (current, num) => current * num);

            foreach(int num in array)
            {
                if (num < 0)
                {
                    isPerfectSequence = false;
                    break;
                }
            } if (!isPerfectSequence || sumOf != prodOf)
            {
                Console.WriteLine("This is not a perfect sequence");

            }
            else
            {
                Console.WriteLine("This is a perfect sequence");
            }

            
        }*/
        static void CodeChallenge4()
        {
            Console.WriteLine("Code Challenge 4");

            int[] SumOfRows(int[,] matrix)
            {
                int numRows = matrix.GetLength(0);
                int numCols = matrix.GetLength(1);
                int[] rowSums = new int[numRows];

                for (int i = 0; i < numRows; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < numCols; j++)
                    {
                        Console.Write($"Enter the number for row {i + 1}, column {j + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            matrix[i, j] = number;
                            sum += number;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number.");
                            j--; // Repeat the current column input
                        }
                    }
                    rowSums[i] = sum;
                }

                return rowSums;
            }

            Console.Write("Enter the number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int numRowsInput) && numRowsInput > 0)
            {
                Console.Write("Enter the number of columns: ");
                if (int.TryParse(Console.ReadLine(), out int numColsInput) && numColsInput > 0)
                {
                    int[,] myArray = new int[numRowsInput, numColsInput];
                    int[] sums = SumOfRows(myArray);

                    Console.WriteLine("Sum of each row:");
                    for (int i = 0; i < sums.Length; i++)
                    {
                        Console.WriteLine($"Row {i + 1}: {sums[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Number of columns should be positive.");
                }
            }
            else
            {
                Console.WriteLine("Number of rows should be a positive.");
            }
        }
    }
    
}