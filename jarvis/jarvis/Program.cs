using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserCommand="";
           Assistant assistant = new Assistant();

            UserCommand=Console.ReadLine();
            assistant.ExecuteRequest(UserCommand);

   


            Console.ReadLine();
            
        }
        
    }
   
}
