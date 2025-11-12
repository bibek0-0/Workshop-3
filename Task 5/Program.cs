namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators ops = new Operators();

            //For loop
            ops.SumUsingForLoop();

            //While loop 
            ops.PrintNumbersUsingWhileLoop();

            //Foreach loop
            ops.SumArrayUsingForEach();
        }
    }
}