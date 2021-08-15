using System;

namespace code
{
    public class Kata
    {
       public bool CheckForValid(string numbers)
       {
            if(numbers.Contains(",\n") || numbers.Contains("\n,"))
            {
              return false;
            }
           
            else
            {
                return true;
            }
       }  


       public int add(string numbers)
       {
           int result =0;
           if(numbers == "" || numbers == null)
           {
               return 0;
           }
           else
           {
               try
               {
                    bool Check = CheckForValid(numbers);
                    if(Check)
                    {
                    string[] collection = numbers.Split(new Char [] {',' , '\n' });
                    foreach (var item in collection)
                    {
                        result += Int16.Parse(item);
                    }
                    return result;
                    }
                    else
                    {
                        System.Console.WriteLine("Invalied Operater ...");
                        return -99999;
                    }
                    
               }
               catch 
               {
                   
                   return 0;
               }
            
           }
       }

       
       }
    }
