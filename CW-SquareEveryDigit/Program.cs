using System;

namespace CW_SquareEveryDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SquareMe = new Program();
            // 9119
            Console.WriteLine("please enter an integer to square");
            var userInput = Console.ReadLine();
            var numToSquare = int.Parse(userInput);
            SquareMe.squareDigits(numToSquare);
        }

        public int squareDigits(int theUnfrankedNumber)
        {
            // first we need to cast the number to a string to get the length
            var num2String = theUnfrankedNumber.ToString();

            // this will be the final result
            var output = "";

            // here we're spinning across each digit
            for (var i = 0; i < num2String.Length; i++)
            {
                // set get one character at a time
                char oneChar = num2String[i];
                System.Console.WriteLine(oneChar);

                // cast that character back to an integer
                int oneNum = int.Parse(oneChar.ToString());

                // square the integer 
                output += (oneNum * oneNum);
            }

            // set the output back to an integer and return
            Console.WriteLine(output);
            Console.WriteLine("OK Gotta Go!");
            Environment.Exit(0);
            return int.Parse(output);

            
        }
    }
}
