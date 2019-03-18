using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv2
{
    class Program
    {
        

        static void Main(string[] args)
        {
           

            Console.WriteLine("What are you in the mood to do?");
           
                Console.WriteLine("Here are your options:");
                Console.WriteLine("    1) Action");
                Console.WriteLine("    2) Chilling");
                Console.WriteLine("    3) Danger");
                Console.WriteLine("    4) Good Food");
                string userInput = Console.ReadLine(); //user enters an integer here.  
                int act1 = 0;
                
                while(!Int32.TryParse(userInput, out act1) || act1 <=0 || act1 >= 5) //makes sure the input is an integer
                    {
                    Console.WriteLine("Selection not valid.  Please choose again and pick an option from above.");
                    userInput = Console.ReadLine();
                }

            string userAct = Convert.ToString(act1); 

                switch (act1)
                {
                    case 1:
                    userAct = "Since you want action, you should go Stock Car Racing";
                       break;
                    case 2:
                    userAct = "If you want to chill, you should go Hiking";
                        break;
                    case 3:
                    userAct = "You're wanting danger, then you should go Skydiving";
                        break;
                    default:
                    userAct = "If you want good food, head to Taco Bell";
                        break;
                }

            Console.WriteLine("How many people are you bringing with you?");
            string peepsInput = Console.ReadLine();
            int totPeople = 0;

            while (!Int32.TryParse(peepsInput, out totPeople) || totPeople <0)
            {
                Console.WriteLine("Invalid option.  Please enter the number of people you are bringing with you.");
                peepsInput = Console.ReadLine();
            }

            string travMode = Convert.ToString(totPeople);

            if (totPeople == 0)
            {
                travMode = "sneakers";
            }
            else if (totPeople >= 1 && totPeople <= 4)
            {
                travMode = "a sedan";
            }
            else if (totPeople >= 5 && totPeople <= 10)
            {
                travMode = "a Volkswagen bus";
            }
            else
            {
                travMode = "an airplane";
            }

            Console.WriteLine(userAct + " and you should use " + travMode + ".");
            Console.WriteLine( "Have fun and good bye!");
        }



    }
}
