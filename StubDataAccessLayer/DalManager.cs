using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {

        public DalManager()
        { }

        public List<House> GetAllHouses()
        {
            List<House> houses = new List<House>();
            houses.Add(new House("H1"));

            return houses;
        }

        public List<House> GetAllHousesSup200Unit()
        {
            List<House> houses = GetAllHouses();
            foreach(House h in houses)
            {
                if (h.GetNumberOfUnities() < 200) houses.Remove(h);
            }
            return houses;
        }

        public List<Territory> GetAllTerritory()
        {
            List<Territory> territories = new List<Territory>();
            territories.Add(new Territory(TerritoryType.DESERT));

            return territories;
        }

        public List<Character> GetAllCharacter()
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Character());

            return characters;
        }

    }
}
