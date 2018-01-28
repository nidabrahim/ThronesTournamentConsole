﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using WebApiGoT.Models;

namespace WebApiGoT.Controllers
{
    public class WarController : ApiController
    {
        ThronesTournamentManager businessManager = new ThronesTournamentManager();


        public List<WarDTO> GetAllWars()
        {
            List<WarDTO> listWar= new List<WarDTO>();

            foreach (var war in businessManager.ListWars())
            {
                listWar.Add(new WarDTO(war));
            }

            return listWar;
        }
    }
}
