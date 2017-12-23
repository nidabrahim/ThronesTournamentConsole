using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
       
        List<Character> Housers { get; set; }
        String Name { get; set; }
        int NumberOfUnities { get; set; }

    
        
        public void AddHousers(Character character) { }

        public House() { }
    }
}
