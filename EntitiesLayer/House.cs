using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        public String Name { get; set; }

        private int numberOfUnities;

        /*public int NumberOfUnities
        {
            get { return numberOfUnities; }
            set { numberOfUnities = value; }
        }*/

        List<Character> Housers { get; set; }

        


        public House()
        {
            Name = "Guest";
            SetNumberOfUnities(GlobalVar.NUMBEROfUNITIES);
            Housers = new List<Character>();
        }

        public House(String Name)
        {
            this.Name = Name;
            SetNumberOfUnities(GlobalVar.NUMBEROfUNITIES);
            Housers = new List<Character>();
        }

        public House(String Name, int NumberOfUnities)
        {
            this.Name = Name;
            this.SetNumberOfUnities(NumberOfUnities);
            Housers = new List<Character>();
        }

        public int GetNumberOfUnities()
        {
            return numberOfUnities;
        }

        private void SetNumberOfUnities(int value)
        {
            numberOfUnities = value;
        }

        public void AddHousers(ref Character character)
        {
            Housers.Add(character);
        }

        override
        public String ToString()
        {
            String s = Name + "\n- Number of unities : " + GetNumberOfUnities() + "\n";

            if (Housers.Count != 0)
            {
                s += "- Housers :\n";
                foreach (Character character in Housers)
                {
                    s += "\t" + character.GetLastName() + " " + character.GetFirstName() + "\n";
                }
            }

            return s;
        }


        /*
        private String _name;
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        */
    }
}
