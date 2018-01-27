using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntitiesLayer
{

    public class Character : EntityObject
    {
        private string _firstName;
        private string _lastName;
        private CharaterTypeEnum _type;
        private int _bravoury;
        private int _crazyness;
        private int _pv;
        private Dictionary<Character, RelationshipEnum> _relationships;


        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public CharaterTypeEnum Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Bravoury
        {
            get { return _bravoury; }
            set { _bravoury = value; }
        }

        public int Crazyness
        {
            get { return _crazyness; }
            set { _crazyness = value; }
        }

        public int Pv
        {
            get { return _pv; }
            set { _pv = value; }
        }

        public Dictionary<Character, RelationshipEnum> Relationships
        {
            get { return _relationships; }
            set { _relationships = value; }
        }


        public Character()
        {
            FirstName = "Guest";
            LastName = "Guest";
            Type = CharaterTypeEnum.WARRIOR;
            Bravoury = 0;
            Crazyness = 0;
            Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
          
        }

        public Character(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Type = CharaterTypeEnum.WARRIOR;
            this.Bravoury = 0;
            this.Crazyness = 0;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }

        public Character(String FirstName, String LastName, CharaterTypeEnum CharaterType)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Type = CharaterType;
            this.Bravoury = 0;
            this.Crazyness = 0;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }


        public Character(String FirstName, String LastName, CharaterTypeEnum CharaterType, int Bravoury, int Crazyness)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Type = CharaterType;
            this.Bravoury = Bravoury;
            this.Crazyness = Crazyness;
            this.Pv = GlobalVar.PV;
            Relationships = new Dictionary<Character, RelationshipEnum>();
        }


        public void AddRelatives(Character Character, RelationshipEnum Relationship)
        {
            Relationships.Add(Character, Relationship);
        }

        override
        public String ToString()
        {
            String s = FirstName + " " + LastName + "\n- Bravoury : " + Bravoury + "\n- Crazyness : " + Crazyness + "\n- Pv : " + Pv + "\n";
            if (Relationships.Count != 0)
            {
                s += "- Relationships :\n";
                foreach (KeyValuePair<Character, RelationshipEnum> relation in Relationships)
                {
                    s += String.Format("\t{2} with {0} {1}\n", relation.Key.FirstName, relation.Key.LastName, relation.Value);
                }
            }
            

            return s;

        }

    }
}
