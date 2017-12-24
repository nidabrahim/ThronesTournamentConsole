using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntitiesLayer
{

    public class Character : EntityObject
    {
        private string firstName;
        private string lastName;
        
        CharaterTypeEnum Type { get; set; }
        int Bravoury { get; set; }
        int Crazyness { get; set; }
        int Pv { get; set; }
        Dictionary<Character, RelationshipEnum> Relationships { get; set; }

        public Character()
        {
            SetFirstName("Guest");
            SetLastName("Guest");
            Type = CharaterTypeEnum.WARRIOR;
            Bravoury = 0;
            Crazyness = 0;
            Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
          
        }

        public Character(String FirstName, String LastName)
        {
            this.SetFirstName(FirstName);
            this.SetLastName(LastName);
            Type = CharaterTypeEnum.WARRIOR;
            this.Bravoury = 0;
            this.Crazyness = 0;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }

        public Character(String FirstName, String LastName, CharaterTypeEnum CharaterType)
        {
            this.SetFirstName(FirstName);
            this.SetLastName(LastName);
            this.Type = CharaterType;
            this.Bravoury = 0;
            this.Crazyness = 0;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }


        public Character(String FirstName, String LastName, CharaterTypeEnum CharaterType, int Bravoury, int Crazyness)
        {
            this.SetFirstName(FirstName);
            this.SetLastName(LastName);
            this.Type = CharaterType;
            this.Bravoury = Bravoury;
            this.Crazyness = Crazyness;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }

        public string GetLastName()
        {
            return lastName;
        }

        private void SetLastName(string value)
        {
            lastName = value;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        private void SetFirstName(string value)
        {
            firstName = value;
        }

        public void AddRelatives(Character Character, RelationshipEnum Relationship)
        {
            Relationships.Add(Character, Relationship);
        }

        override
        public String ToString()
        {
            String s = GetFirstName() + " " + GetLastName() + "\n- Bravoury : " + Bravoury + "\n- Crazyness : " + Crazyness + "\n- Pv : " + Pv + "\n";
            if (Relationships.Count != 0)
            {
                s += "- Relationships :\n";
                foreach (KeyValuePair<Character, RelationshipEnum> relation in Relationships)
                {
                    s += String.Format("\t{2} with {0} {1}\n", relation.Key.GetFirstName(), relation.Key.GetLastName(), relation.Value);
                }
            }
            

            return s;

        }

    }
}
