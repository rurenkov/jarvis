using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarvis
{
   

    public class Assistant
    {


        Command[] comands ={ new Command() {NameCommand= "Send SMS to ", Answer = "ok, I will do it"},
                             new Command() {NameCommand= "Send MAIL to ", Answer = "ok, I will do it"},
                             new Command() {NameCommand= "Turn on", Answer = "ok, I will do it"}
                           };

        public void ExecuteRequest(string UserCommand)
        {
            for (int i = 0; i < comands.Length; i++)
            {
                if (comands[i].NameCommand == UserCommand)
                {
                    Console.WriteLine(comands[i].Answer);
                    break;
                }
                else if  (i==(comands.Length-1))
                {
                    Console.WriteLine("fuck off");
                    
                }
            }

          



        }

        internal void ExecuteRequest()
        {
            throw new NotImplementedException();
        }
    }
}
