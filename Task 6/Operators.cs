namespace Task_6
{
    internal class Operators
    {
        public void NumberInputTryCatch()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Zero is not allowed.");
                }
                else
                {
                    Console.WriteLine($"You entered: {number}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

        }

        public void PasswordCheck()
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}

