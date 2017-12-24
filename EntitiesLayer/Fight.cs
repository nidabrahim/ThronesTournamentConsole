using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Fight : EntityObject
    {
     
        House houseChalleging;
        House houseChalleged;
        House winningHouse;
        Territory territory;

        public Fight(House houseChalleging, House houseChalleged, Territory territory)
        {
            this.houseChalleging = houseChalleging;
            this.houseChalleged = houseChalleged;
            this.territory = territory;


            this.winningHouse = this.houseChalleging;


        }

        public void Winner()
        {
            Console.WriteLine("The winner is : \n" + winningHouse);
        }
    }
}
