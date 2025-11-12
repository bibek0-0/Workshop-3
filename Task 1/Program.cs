namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators ops = new Operators();

            ops.Add(10, 5);
            ops.Subtract(10, 5);
            ops.Multiply(10, 5);
            ops.Divide(10, 5);
            ops.OddEvenFinder(7);
        }
    }
}
