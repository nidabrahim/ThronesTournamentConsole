using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class DalInstanceSqlServer : IDal
    {

        private static string connexionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\youssefNIDA\\Documents\\ISIMA\\S2\\web Services\\DB\\db_thrones.mdf';Integrated Security = True; Connect Timeout = 30";

        public DalInstanceSqlServer() { }


        public List<House> GetAllHouses()
        {
            List<House> houses = new List<House>();

            using (SqlConnection sqlConnection = new SqlConnection(connexionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM House", sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        House house = new House();
                        house.Name = sqlDataReader["name"].ToString();
                        
                        houses.Add(house);
                    }
                }
                sqlConnection.Close();
            }

                return houses;
        }

        public List<House> GetAllHousesSup200Unit()
        {
            List<House> houses = GetAllHouses();
            foreach (House h in houses)
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

        public List<Fight> GetAllFights()
        {
            throw new NotImplementedException();
        }

        public List<Territory> GetAllTerritories()
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }
    }
}
