using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public enum TerritoryType { SEA, MOUNTAIN, LAND, DESERT }

    public class Territory : EntityObject
    {
        TerritoryType TerritoryType;
        Character Owner { get; set; }

        public Territory() { }
    }
}
