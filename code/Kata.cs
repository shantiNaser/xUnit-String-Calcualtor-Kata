using System;

namespace code
{
    public class Kata
    {
       public char[] SpecialDileamter = { ';', '\n' };
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

       public bool isSpecialCharacter(string numbers)
       {
           return (numbers.StartsWith("//"));
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
                        if(isSpecialCharacter(numbers))
                        {
                            string subnumbers = numbers.Substring(4);
                            string[] collection = subnumbers.Split(SpecialDileamter);
                            foreach (var item in collection)
                            {
                                result += Int16.Parse(item);
                            }
                            return result;
                        }
                        else
                        {
                            string[] collection = numbers.Split(new Char [] {',' , '\n' });
                            foreach (var item in collection)
                            {
                                result += Int16.Parse(item);
                            }
                            return result;
                        }
                    
                    }
                    else
                    {    
                            // not special character and not valid number 
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
