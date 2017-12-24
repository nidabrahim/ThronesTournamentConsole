using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    
    public class Territory : EntityObject
    {
        TerritoryType TerritoryType;
        Character Owner { get; set; }

        public Territory()
        {
            TerritoryType = TerritoryType.DESERT;
            Owner = null;
        }

        public Territory(TerritoryType TerritoryType)
        {
            this.TerritoryType = TerritoryType;
            Owner = null;
        }

        public Territory(TerritoryType TerritoryType, Character Owner)
        {
            this.TerritoryType = TerritoryType;
            this.Owner = Owner;
        }
    }
}
