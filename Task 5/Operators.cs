namespace Task_5
{
    internal class Operators
    {
        //For loop
        public void SumUsingForLoop()
        {
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum from 1 to {N} is: {sum}");
        }

        //While loop
        public void PrintNumbersUsingWhileLoop()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i == 15)
                {
                    Console.WriteLine("Stopping at 15");
                    break;
                }

                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
            }
        }

        //Foreach loop
        public void SumArrayUsingForEach()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"The sum of array elements is: {sum}");
        }
    }
}

