using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DalInstanceSqlServer : IDal
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
                        house.idEntityObject = Int32.Parse(sqlDataReader["idHouse"].ToString());
                        house.Name = sqlDataReader["name"].ToString();
                        house.NumberOfUnities = Int32.Parse(sqlDataReader["name"].ToString());

                        houses.Add(house);
                    }
                }

                foreach (House house in houses)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM Character WHERE house_id = " + house.idEntityObject, sqlConnection);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        List<Character> characters = new List<Character>();
                        while (sqlDataReader.Read())
                        {
                            Character character = new Character();
                            character.idEntityObject = Int32.Parse(sqlDataReader["idCharacter"].ToString());
                            character.FirstName = sqlDataReader["firstName"].ToString();
                            character.LastName = sqlDataReader["lastName"].ToString();
                            character.Bravoury = Int32.Parse(sqlDataReader["bravoury"].ToString());
                            character.Crazyness = Int32.Parse(sqlDataReader["crazyness"].ToString());
                            character.Pv = Int32.Parse(sqlDataReader["pv"].ToString());
                            //_relationships

                            characters.Add(character);

                        }
                        house.Housers = characters;
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
                if (h.NumberOfUnities < 200) houses.Remove(h);
            }
            return houses;
        }

        public House GetHouseById(int id)
        {
            House house = new House();

            using (SqlConnection sqlConnection = new SqlConnection(connexionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM House WHERE IdHouse = " + id, sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        house.Name = sqlDataReader["name"].ToString();
                        house.NumberOfUnities = Int32.Parse(sqlDataReader["name"].ToString());
                        //Characters


                    }
                }
                sqlConnection.Close();
            }

            return house;
        }

        public void SaveHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void UpdateHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void DeleteHouse(House house)
        {
            throw new NotImplementedException();
        }



        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public Character GetCharacterById(int id)
        {
            Character character = new Character();

            using (SqlConnection sqlConnection = new SqlConnection(connexionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Character WHERE IdCharacter = " + id, sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        character.FirstName = sqlDataReader["FirstName"].ToString();
                        character.LastName = sqlDataReader["LastName"].ToString();
                        character.Bravoury = Int32.Parse(sqlDataReader["Bravoury"].ToString());
                        character.Crazyness = Int32.Parse(sqlDataReader["Crazyness"].ToString());
                        character.Pv = Int32.Parse(sqlDataReader["Pv"].ToString());
                        //_relationships

                    }
                }
                sqlConnection.Close();
            }

            return character;
        }

        public void SaveCharacter(Character character)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacter(Character character)
        {
            throw new NotImplementedException();
        }

        public void DeleteCharacter(Character character)
        {
            throw new NotImplementedException();
        }



        public List<Fight> GetAllFights()
        {
            throw new NotImplementedException();
        }

        public Fight GetFightById(int id)
        {
            Fight fight = new Fight();

            using (SqlConnection sqlConnection = new SqlConnection(connexionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Fight WHERE IdFight = " + id, sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        //Fight. = sqlDataReader["FirstName"].ToString();


                    }
                }
                sqlConnection.Close();
            }

            return fight;
        }

        public void SaveFight(Fight fight)
        {
            throw new NotImplementedException();
        }

        public void UpdateFight(Fight fight)
        {
            throw new NotImplementedException();
        }

        public void DeleteFight(Fight fight)
        {
            throw new NotImplementedException();
        }



        public List<Territory> GetAllTerritories()
        {
            throw new NotImplementedException();
        }
        
        public Territory GetTerritoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveTerritory(Territory territory)
        {
            throw new NotImplementedException();
        }

        public void UpdateTerritory(Territory territory)
        {
            throw new NotImplementedException();
        }

        public void DeleteTerritory(Territory territory)
        {
            throw new NotImplementedException();
        }

       

        
    }
}
