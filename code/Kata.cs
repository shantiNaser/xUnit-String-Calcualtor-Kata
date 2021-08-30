using System;
using System.Collections;
 using System.Collections.Generic;


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
           
            else if(numbers.EndsWith(","))
            {
                return true;
            }
            else
            {
                return true;
            }
       }  

       public int ReturnTheFinalResult(string [] collections)
       {
           int result =0;
           foreach (var item in collections)
            {
                if(Int16.Parse(item) >= 1000)
                    {
                        continue;
                    }
                else
                {
                    result += Int16.Parse(item);
                }
                
            }
            return result;
       }

       public bool isSpecialCharacter(string numbers)
       {
           return (numbers.StartsWith("//"));
       }


       public bool CheckForNegativeNumber(string numbers)
       {
        var list = new List<char>();
        for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]== '-')
                {
                    list.Add(numbers[i+1]);
                    continue;
                }
            }
            string Msg = $"negatives not allowed  : -{string.Join(", -", list)}";
            System.Console.WriteLine(Msg);
            return true;
             // throw new ArgumentException(Msg);
        
       }


       public int add(string numbers)
       {
           if(String.IsNullOrEmpty(numbers))
           {
               return 0;
           }
           else
           {
               try
               {
                    // CheckForNegativeNumber(numbers);
                    bool Check = CheckForValid(numbers);
                    if(Check)
                    {   

                        if(isSpecialCharacter(numbers))
                        {
                            string subnumbers = numbers.Substring(4);
                            string[] collection = subnumbers.Split(numbers.Substring(2,1));
                            return ReturnTheFinalResult(collection);
                        }
                        else
                        {
                            if(numbers.EndsWith(","))
                            {
                                string FinallNumber = numbers.Substring(0,numbers.Length -1);
                                string [] collection = FinallNumber.Split(",");
                                return ReturnTheFinalResult(collection);
                            }

                            else
                            {

                            string[] collection = numbers.Split(new Char [] {',' , '\n' });
                            return ReturnTheFinalResult(collection);
                        }
                            }
                            
                    
                    }
                    else
                    {    
                        System.Console.WriteLine("the following input is NOT ok:");
                        return 0;
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
