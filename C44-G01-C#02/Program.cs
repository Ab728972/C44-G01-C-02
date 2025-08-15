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
            #region Question 6 - Reference Type Assignment
            static void ReferenceTypeAssignment()
            {
                int[] arr1 = { 1, 2, 3 };
                int[] arr2 = arr1; // Reference copy
                arr2[0] = 100;
                Console.WriteLine($"arr1[0]: {arr1[0]}"); // Output: 100
                                                          // Both variables reference the same object
            }
            #endregion
            #region Question 7 - String Concatenation
            static void ConcatenateStrings()
            {
                string first = "Hello";
                string second = "World";
                string combined = first + " " + second;
                Console.WriteLine(combined); // Output: "Hello World"
            }
            #endregion
            #region Question 8 - Boolean Conversion
            static void BooleanConversion()
            {
                // Answer: b) A value 1 will be assigned to d
                // Because !(30 < 20) evaluates to true, which converts to 1
            }
            #endregion
            #region Question 9 - Integer Division and Modulus
            static void DivisionAndModulus()
            {
                // Answer: d) 6 1
                // Because 13/2 performs integer division (6) and 13%2 gives remainder (1)
            }
            #endregion
            #region Question 10 - Increment/Decrement
            static void IncrementDecrement()
            {
                // Answer: d) 7 7
                // Because:
                // !(1 <= 0) is true, so first branch executes
                // ++num (pre-increment) makes num=2
                // z++ (post-increment) uses 5 then increments to 6
                // ++z (pre-increment) makes z=7
                // Calculation: 2 + 5 + " " + 7 → "7 7"
            }
            #endregion
        }
    }
}
