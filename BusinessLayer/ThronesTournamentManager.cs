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

        public List<String> ListHouses()
        {
            List<String> res = new List<String>();
            dalManager.GetAllHouses().ForEach(h => res.Add(h.ToString()) );

            return res;
        }

        public List<String> ListHousesSup200Unit()
        {
            List<String> res = new List<String>();
            dalManager.GetAllHousesSup200Unit().ForEach(h => res.Add(h.ToString()));

            return res;

        }

        public List<String> ListCharacter()
        {
            List<String> res = new List<String>();
            dalManager.GetAllCharacter().ForEach(c => res.Add(c.ToString()));

            return res;
        }

        public List<String> ListTerritory()
        {
            List<String> res = new List<String>();
            dalManager.GetAllTerritory().ForEach(t => res.Add(t.ToString()));

            return res;
        }

    }
}
