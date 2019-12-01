using System;
using System.Linq;

namespace _11ArrayManipulator
{
    class Program
    {
        public static int[] numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "end")
            {
                string command = commandArgs[0];

                if (command == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);
                    Exchange(index);
                }
                else if (command == "max")
                {
                    string type = commandArgs[1];
                    GetMax(type);

                }
                else if (command == "min")
                {
                    string type = commandArgs[1];
                    GetMin(type);
                }
                else if (command == "first")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count > numbers.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string type = commandArgs[2];
                        GetFirst(type, count);

                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count > numbers.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string type = commandArgs[2];
                        GetLast(type, count);
                    }
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void GetLast(string type, int count)
        {
            if (type == "even")
            {
                GetLastEvens(count);
            }
            else if (type == "odd")
            {
                GetLastOdds(count);
            }
        }

        private static void GetLastOdds(int count)
        {
            int[] temp = new int[count];
            int currentCount = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (currentCount == count)
                {
                    break;
                }

                if (numbers[i] % 2 != 0)
                {
                    temp[currentCount] = numbers[i];
                    currentCount++;
                }
            }

            Print(temp.Take(currentCount).Reverse().ToArray());
        }

        private static void GetLastEvens(int count)
        {
            int[] temp = new int[count];
            int currentCount = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (currentCount == count)
                {
                    break;
                }

                if (numbers[i] % 2 == 0)
                {
                    temp[currentCount] = numbers[i];
                    currentCount++;
                }
            }

            Print(temp.Take(currentCount).Reverse().ToArray());

        }

        private static void GetFirst(string type, int count)
        {
            if (type == "even")
            {
                GetFirstEvens(count);
            }
            else if (type == "odd")
            {
                GetFirstOdds(count);
            }
        }

        private static void GetFirstOdds(int count)
        {
            int[] temp = new int[count];
            int currentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (currentCount == count)
                {
                    break;
                }
                if (numbers[i] % 2 != 0)
                {
                    temp[currentCount] = numbers[i];
                    currentCount++;
                }
            }

            Print(temp.Take(currentCount).ToArray());

        }

        private static void GetFirstEvens(int count)
        {
            int[] temp = new int[count];
            int currentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (currentCount == count)
                {
                    break;
                }
                if (numbers[i] % 2 == 0)
                {
                    temp[currentCount] = numbers[i];
                    currentCount++;
                }
            }

            Print(temp.Take(currentCount).ToArray());
        }

        private static void GetMin(string type)
        {
            if (type == "even")
            {
                GetMinEven();
            }
            else if (type == "odd")
            {
                GetMinOdd();
            }
        }

        private static void GetMinOdd()
        {
            int minOdd = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= minOdd)
                {
                    minOdd = numbers[i];
                    minIndex = i;
                }
            }

            if (minIndex >= 0)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void GetMinEven()
        {
            int minOdd = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minOdd)
                {
                    minOdd = numbers[i];
                    minIndex = i;
                }
            }

            if (minIndex >= 0)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void GetMax(string type)
        {
            if (type == "even")
            {
                GetMaxEven();
            }
            else if (type == "odd")
            {
                GetMaxOdd();
            }
        }

        private static void GetMaxOdd()
        {
            int maxOdd = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] >= maxOdd)
                {
                    maxOdd = numbers[i];
                    maxIndex = i;
                }
            }

            if (maxIndex >= 0)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void GetMaxEven()
        {
            int maxEven = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= maxEven)
                {
                    maxEven = numbers[i];
                    maxIndex = i;
                }
            }

            if (maxIndex >= 0)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void Print(int[] temp)
        {
            Console.WriteLine($"[{string.Join(", ", temp)}]");
        }

        private static void Exchange(int index)
        {
            int[] temp = new int[numbers.Length];
            int k = 0;
            if (index < 0 || index >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            for (int i = index + 1; i < numbers.Length; i++, k++)
            {
                temp[k] = numbers[i];
            }

            for (int i = 0; i <= index; i++, k++)
            {
                temp[k] = numbers[i];
            }

            numbers = temp;
        }
    }
}
