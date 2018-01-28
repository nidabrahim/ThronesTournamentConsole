using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;

namespace WebApiGoT.Models
{
    public class WarDTO
    {
        public List<FightDTO> Fights;


        public WarDTO(War war) { }
    }
}