namespace Assignment5_1_2
{
    internal class Program
    {
        // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of int 12345: {IntegerDigitSummation(12345)}"); //15
            Console.WriteLine($"Sum of int -12345: {IntegerDigitSummation(-12345)}"); //13
            Console.WriteLine($"Sum of string 12345: {StringDigitSummation("12345")}"); //15
            Console.WriteLine($"Sum of string -12345: {StringDigitSummation("-12345")}"); //13
            Console.WriteLine($"Sum of string -3njkfno-1dl53nsdf543: {StringDigitSummation("-3njkfno-1dl53nsdf543")}"); //16
        }

        // Sums digits if input is an int
        static int IntegerDigitSummation(int nums)
        {
            // Check to see if number entered is negative, if so, get absolute value and set isNeg to true
            bool isNeg = false;
            if(nums < 0)
            {
                nums = Math.Abs(nums);
                isNeg = true;
            }

            int sum = 0;
            for (int i = nums; i > 0; i/=10)
            {
                if(i < 10 && isNeg == true) //If it is the last digit and isNeg is true subtract the last digit instead
                {
                    sum -= i % 10;
                }
                else
                {
                    sum += i % 10;
                }
            }
            return sum;
        }

        //Sums digits if input is a string
        static int StringDigitSummation(string nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == '-' && char.IsDigit(nums[i+1]))
                {
                    sum -= nums[i+1] - '0';
                    i++;
                }
                else if(char.IsDigit(nums[i]))
                {
                    sum += nums[i] - '0';
                }
            }
            return sum;
        }
    }
}
