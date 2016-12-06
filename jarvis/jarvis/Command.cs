using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarvis
{
    public class Command
    {

        public string NameCommand;
        public string Answer;

        public void Execute()
        {
            Console.WriteLine(Answer);
        }



    }
}
