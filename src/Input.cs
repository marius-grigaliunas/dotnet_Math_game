using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.src
{
    internal class Input
    {
        public static void CheckInput(string input, out bool end, out string returnMessage)
        {
            returnMessage = "";
            end = false;

            switch(input)
            {
                case "exit":
                    end = true;
                    returnMessage = "Program ended press any button to close.";
                    break;
                default:
                    returnMessage = "command not recognized, you can type 'help' for a list of commands";
                    break;
            }
        }
    }
}
