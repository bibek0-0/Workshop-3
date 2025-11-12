namespace Task_2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            //Declare and assign null
            string username = null;

            //Ternary operator to check null
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine(message);

            //Null-Coalescing Operator (??)
            Console.WriteLine(username ?? "Username is not available");

            //Null-Coalescing Assignment Operator (??=)
            username ??= "GuestUser";
            Console.WriteLine($"Updated username: {username}");
        }
    }
}
