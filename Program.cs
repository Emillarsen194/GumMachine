using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class Program
    {
        static void Main(string[] args)
        {
           Dispenser Logic = new Dispenser();

            
            Logic.Addgum();

            


  

            Console.WriteLine();
            Console.WriteLine("\n\n");

           

            while (true)
            {
           
            bool handle = false;
            Console.Write("Vil du trække et stykke tyggegummi Ja eller Nej : ");
                String yesOrNo = Console.ReadLine().ToLower();

            switch (yesOrNo)
            {
                    case "ja":
                        handle = true;
                        break;
                    case "j":
                        handle = true;
                        break;
                    case "nej":
                    handle = false;
                        break;
                    case "n":
                        handle = false;
                        break;
                    default:
                    handle = false;
                    break;

    
               
            }
                Console.Clear();
            Logic.PullAGum(handle);

         

                

            }

              
                   
               
        }
    }
}
