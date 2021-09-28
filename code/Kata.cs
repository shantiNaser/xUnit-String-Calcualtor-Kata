using System;
using System.Linq;
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

        #region  BasicSolution
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
       #endregion

       // Code -- Using Linq ...

       public string ReturnNewFormat(string numbers)
       {
           string subnumbers = numbers.Substring(4);
           return subnumbers;
       }

       public int NegativeNotAllowed(string numbers)
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
            return 0; // it must throw an Exception here
       }

       public int IgnoreBigNumber(int [] collections)
       {
           int result =0;
           foreach (var item in collections)
            {
                if(item >= 1000)
                    {
                        continue;
                    }
                else
                {
                    result += item;
                }
                
            }
            return result;
       }
        
        public int AddUsingLinq(string number)
        {
             var ArrayElemant = string.IsNullOrEmpty(number) ? 0 
                                : number.Contains("-") ? NegativeNotAllowed(number)
                                : number.StartsWith("//") ? 
                                IgnoreBigNumber(ReturnNewFormat(number).Split(number.Substring(2,1)).Select(int.Parse).ToArray())
                                : number.Contains("\n,") || number.Contains(",\n") ? 0
                                : IgnoreBigNumber(number.Split(new Char [] {',' , '\n' }).Select(int.Parse).ToArray());

            
            return ArrayElemant;          
        }
       
       }
    }
