using System;

namespace code
{
    public class Kata
    {
       public int add(string numbers)
       {
           int result =0;
           if(numbers == "" || numbers == null)
           {
               return 0;
           }
           else
           {
            string[] collection = numbers.Split(",");
            foreach (var item in collection)
            {
                result += Int16.Parse(item);
            }
            return result;
           }
       }

       
       }
    }
