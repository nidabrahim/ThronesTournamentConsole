using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntitiesLayer
{

    public enum CharaterTypeEnum { WARRIOR, WITCH, TACTICIAN, LEADER, LOSER};
    public enum RelationshipEnum { FRIENDSHIP, LOVE, HATRED, RIVALRY }

    public class Character : EntityObject
    {
     
        int Bravoury { get; set; }
        int Crazyness { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        int Pv { get; set; }
        Dictionary<RelationshipEnum, CharaterTypeEnum> Relationships { get; set; }

        public Character()
        {
            FirstName = "toto";
            LastName = "titi";
            Bravoury = 0;
            Crazyness = 0;
            Pv = 100;
            Relationships = null;
          
        }

        public Character(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Bravoury = 0;
            this.Crazyness = 0;
            this.Pv = 100;
        }


        public Character(String FirstName, String LastName, int Bravoury, int Crazyness) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Bravoury = Bravoury;
            this.Crazyness = Crazyness;
            this.Pv = 100;
        }

        public void AddRelatives(RelationshipEnum relation, CharaterTypeEnum character)
        {
            Relationships.Add(relation, character);
        }

        override
        public String ToString()
        {
            String s = FirstName + " | " + LastName + " | " + Bravoury + " | " + Crazyness + " | " + Pv + "\n";
            if (Relationships != null)
            {
                foreach (KeyValuePair<RelationshipEnum, CharaterTypeEnum> relation in Relationships)
                {
                    s += String.Format("{0} ; {1} \n", relation.Key, relation.Value);
                }
            }

            return s;

        }

    }
}
