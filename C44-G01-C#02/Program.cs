namespace C44_G01_C_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 - Basic Input/Output
            static void PrintEnteredNumber()
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            #endregion

        }
    }
}
