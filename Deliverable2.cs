using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string actDone;
            string travMode;

            Console.WriteLine("Hello, what are you in the mood for?");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("    1) Action");
            Console.WriteLine("    2) Chilling");
            Console.WriteLine("    3) Danger");
            Console.WriteLine("    4) Good Food");
            var act1 = float.Parse(Console.ReadLine());

            if (act1 == 1)
            {
                actDone = "Since you want action, you should go stock car racing ";
            }
            else if (act1 == 2)
            {
                actDone = "Since you want to just chill, you should go hiking ";
            }
            else if (act1 == 3)
            {
                actDone = "Since you seek danger, then go skydiving ";
            }
            else if (act1 == 4)
            {
                actDone = "In the mood for some good food, try some Taco Bell ";
            }
            else
            { Console.WriteLine("Sorry, please choose either option 1, 2,3 or 4."); }


            Console.WriteLine("And how many people are you bringing with you?");
            var totpeeps = float.Parse(Console.ReadLine());

            if (totpeeps == 0)
            {
                travMode = " sneakers";
            }
            else if (totpeeps >= 1 && totpeeps <= 4)
            {
                travMode = " a sedan";
            }
            else if (totpeeps >= 5 && totpeeps <= 10)
            {
                travMode = " a Volkswagen bus";
            }
            else
            {
                travMode = " an airplane";
            }

            Console.WriteLine(actDone + "and you should travel by " + travMode);

        }     

    }
}
