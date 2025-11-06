namespace fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user for input of number of terms in the fibonacci sequence 
            Console.WriteLine("Please enter the number of terms in the Fibonacci sequence you'd like to calculate: ");

            int noOfTerms; //a variable to store user input

            //Use appropriate control statements to handle cases where the user enters an invalid number of terms or the sequence cannot be calculated or the data range overflows.
            try //use a try block to catch errors during input
            {
                noOfTerms = Convert.ToInt32(Console.ReadLine()); //read input as a string and convert to an integer
                //check if input is less or equal to 0
                if (noOfTerms <= 0)
                {
                    Console.WriteLine("Please enter a positive integer");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex) //catch errors when user enters a text instead of a number
            {
                Console.WriteLine($"Please enter a positive integer");
                Environment.Exit(0);
                return;
            }
            
            long[] fibonacci = new long[noOfTerms]; //create an array to store the fibonacci sequence, handle large numbers with long

            for(int i = 0; i < noOfTerms; i++) //use a loop to calculate each term in the sequence
            {
                fibonacci[i] = CalcFibonacci(i);

                string message = i switch // use switch expression to format the output based on term index
                {
                    0 => $"{fibonacci[i]} (first term)",
                    1 => $"{fibonacci[i]} (second term)",
                    _ => $"The sum of term {i} and term {i + 1} is {fibonacci[i]}"
                };
                Console.WriteLine($"Term {i +1}: {message}"); //print out the formatted message for the current term

                if (fibonacci[i] < 0) //this part checks for overflow, incase of negative values
                {
                    Console.WriteLine("Value exceeded data range!"); //exit loop when value exceeds long limit
                    break;
                }
            }
        }

        static long CalcFibonacci(int term)
        {
            switch (term) //return 0 for term index 0 and 1 for term index 1
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:   //initialize variable to calculate iteratively
                    long a = 0, b = 1, sum = 0;
                    for (int i = 2; i <= term; i++) //this updates a and b from calculating the fibonacci value iteratively
                    {
                        sum = a + b;
                        a = b;
                        b = sum;
                    }
                    return b;
            }
        }
    }
}
