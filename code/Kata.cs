using System;
using System.Collections;


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

       public void CheckForNegativeNumber(string numbers)
       {
          char[] Arr = numbers.ToCharArray();
          var arlist = new ArrayList();
          char result ;
          foreach(var item in Arr)
          {
           arlist.Add(item);
          }
          for(int i=0 ; i<arlist.Count ; i++)
          {
              result = Convert.ToChar(arlist[i]);
              if(result == '-')
              {
                string Msg = $"negatives not allowed: -{arlist[i+1]}";
                throw new ArgumentException(Msg);
              }
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
                    CheckForNegativeNumber(numbers); 
                    bool Check = CheckForValid(numbers);
                    if(Check)
                    {   

                        if(isSpecialCharacter(numbers))
                        {
                            char[] diamaters = numbers.ToCharArray(); 
                            string subnumbers = numbers.Substring(4);
                            string[] collection = subnumbers.Split(diamaters[2]);
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
