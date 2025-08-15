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

            #region Question 2 - String to Int Conversion
            static void ConvertStringToInt()
            {
                string input = "123abc";
                try
                {
                    int result = Convert.ToInt32(input);
                    Console.WriteLine($"Conversion result: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Input string contains non-numeric characters");
                }
                
            }
            #endregion
            #region Question 3 - Floating-Point Arithmetic
            static void FloatingPointOperation()
            {
                double a = 0.1;
                double b = 0.2;
                double sum = a + b;
                Console.WriteLine($"0.1 + 0.2 = {sum}");
                // Note: Result may show floating-point precision issue (0.30000000000000004)
            }
            #endregion
            #region Question 4 - Substring Extraction
            static void ExtractSubstring()
            {
                string text = "Hello World";
                string sub = text.Substring(6, 5); // Starts at index 6, takes 5 characters
                Console.WriteLine($"Substring: {sub}"); // Output: "World"
            }
            #endregion
            #region Question 5 - Value Type Assignment
            static void ValueTypeAssignment()
            {
                int a = 10;
                int b = a; // Value copy
                b = 20;
                Console.WriteLine($"a: {a}, b: {b}"); // a remains 10, b becomes 20
                                                      // Value types create independent copies
            }
            #endregion
        }
    }
}
