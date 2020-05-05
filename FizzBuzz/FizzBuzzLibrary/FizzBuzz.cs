using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
       public string GetResults(int inputParam)
       {
           try {
               string outputValue = string.Empty;

               if (inputParam >= 1000) {outputValue="InvalidNumber"; return outputValue;}
                
               for (int i=1; i <= inputParam; i++)
               {
                   if (i % 3 == 0)
                   {
                       outputValue += "Fizz ";
                   }
                   else if (i % 5 == 0)
                   {
                       outputValue += "Buzz ";
                   }
                   else
                   {
                        outputValue += i.ToString() + " ";
                   }
               }

               return outputValue;
           }
           catch(Exception ex)
           {
               return ex.Message;
           }
       }
    }
}
