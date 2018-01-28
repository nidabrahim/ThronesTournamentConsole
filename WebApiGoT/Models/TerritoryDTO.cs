﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;

namespace WebApiGoT.Models
{
    public class TerritoryDTO
    {
        public string Owner;


        public TerritoryDTO(Territory territory) {

            this.Owner = territory.Owner.FirstName + " " + territory.Owner.LastName;
        }
    }
}