using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******Hello welcome to iphone saving app!******\n");
            bool value = true;
            var EXIT_CHAR = 'q';
            var name = "";
            var unitCost = 0.0m;
            var affordableCost = "";
            var iphonemodel = "";
            var memory = 0;
            var discount = 0.15;
            var tax = 0.25;
            var totalcost = 0.0m;
            
        
            while(value)
            {
            Console.WriteLine("***********************************");
            Console.WriteLine("\nApp that tells the price of the Iphones based on the memory size"); 
            Console.WriteLine("Enter any variable to continue or 'q' to quit");
            var str = Console.ReadLine();
            if(Convert.ToChar(str) == EXIT_CHAR)
            {
            Console.WriteLine("Done!");
            break;
            }
            Console.WriteLine($"Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Please enter your iphone model and memory without spaces: ");
            iphonemodel = Console.ReadLine();
            Console.WriteLine($"Enter the amount to purchase mobile : ");
            affordableCost = Console.ReadLine();
            
           switch(iphonemodel.ToLower())
           {
            case "iphonex32" :  
                            memory = 32;
                            unitCost =  800.0m;
                            Console.WriteLine($"Final price of iphonex with 32 gb memory is:  ${calculation(unitCost,memory)}");
                            balance();
                            break;

            case "iphonex64" :  
                            memory = 64;
                            unitCost =  900.0m;
                            Console.WriteLine($"Final price of iphonex with 64 gb memory is: ${calculation(unitCost,memory)}");
                            balance();
                            break;

             case "iphonex128" :  
                            memory = 128;
                            unitCost =  1000.0m;
                            Console.WriteLine($"Final price of iphonex with 128 gb memory is: ${calculation(unitCost,memory)}");
                            balance();
                            break;               

            case "iphonexsmax32" :
                            memory = 32;
                            unitCost =  1050.0m;
                            Console.WriteLine($"Final price of iphonexs max with 32 gb memory is: ${calculation(unitCost,memory)}");
                            balance();
                            break;

            case "iphonexsmax64" :
                            memory = 64;
                            unitCost =  1200.0m;
                            Console.WriteLine($"Final price of iphonexs max with 64 gb memory is: ${calculation(unitCost,memory)}");
                            balance();
                            break;

            case "iphonexsmax128" :
                            memory = 128;
                            unitCost =  1400.0m;
                            Console.WriteLine($"Final price of iphonexs max with 32 gb memory is: ${calculation(unitCost,memory)}");
                            balance();
                            break;

            default :     Console.WriteLine("Provide correct details");
                           break;

           }

           decimal calculation(decimal uCost, int mem)
           {
               var t = Convert.ToDecimal(tax);
                var d = Convert.ToDecimal(discount);
               if(mem == 32)
               {
                   
                totalcost = uCost + (t * uCost) ; 
                  
               }
               if(mem == 64)
               {
                   
                totalcost = uCost + (t * uCost) - (d*uCost);   
               }
               if(mem == 128)
               {
                totalcost = uCost - (d * uCost);   
               }
               Console.WriteLine($"\n***********Details*************");
               Console.WriteLine($"NAME : {name}");
               Console.WriteLine($"IPHONE MODEL is {iphonemodel} ");
           
            return totalcost;
               
           }

           void balance()
           {
            var cost = Convert.ToDecimal(affordableCost);
               if((cost - totalcost) >= 0.0m)
               {
                  Console.WriteLine($"Remaining balance after purchasing iphone is ${cost - totalcost}");

               }
               else if ((cost - totalcost) < 0.0m)
               {
                Console.WriteLine($"Need more money ${totalcost - cost} to purchase mobile ");
                
               }
                         }
           
            } 
           
       

        }
    }
}
