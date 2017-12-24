using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StubDataAccessLayer;
using EntitiesLayer;

namespace BusinessLayer
{
    public class ThronesTournamentManager
    {
        private DalManager dalManager;

        public ThronesTournamentManager()
        {
            dalManager = new DalManager();
        }

        public String ListHouses()
        {
            List<House> houses = dalManager.GetAllHouses();
            String res = "";

            return res;
        }

        public String ListHousesSup200Unit()
        {
            List<House> houses = dalManager.GetAllHousesSup200Unit();
            String res = "";

            return res;
        }

        public String ListCharacter()
        {
            List<Character> character = dalManager.GetAllCharacter();
            String res = "";

            return res;
        }

        public String ListTerritory()
        {
            List<Territory> Territory = dalManager.GetAllTerritory();
            String res = "";

            return res;
        }




    }
}
