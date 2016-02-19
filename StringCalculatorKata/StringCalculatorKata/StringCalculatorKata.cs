using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
   public class StringCalculatorKata
    {
        public int Add(string numbers)
        {
            int sum = 0;

            if (numbers == "")
            {
                return sum;
            }

            /* int numbersInArray = array.Length; No Longer Needed */

            char[] delimeters;
            if (numbers.StartsWith("//")) //if string numbers starts with \\ 
            {
                string[] inputArray = numbers.Split('\n'); // split the string using delimeter defined as \n
                string del = inputArray[0].Substring(2);  // define string del & call the first portion of array with 3rd character in the array which is *
                char delimeter = char.Parse(del); // char delimeter  equals the variable del parsed
                delimeters = new char[] {delimeter}; // 

                numbers = inputArray[1];
            }

            else
            {
                delimeters = new char[] {',', '\n'};
            }

            string[] array = numbers.Split(delimeters);



        foreach (string number in array)
         {
           sum += int.Parse(number);
         }
            return sum;
        }
    }
}
