using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace ThronesTournamentConsole
{
     class Program
    {
         static void Main(string[] args)
         {
             Character c = new Character();
             Character c1 = new Character("fff","yyh");
             Character c2 = new Character("fff", "yyh",0,0);

            Console.WriteLine(c);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.ReadLine();
         }
    }
}
