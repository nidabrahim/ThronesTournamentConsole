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
    public class HouseController : ApiController
    {
        ThronesTournamentManager businessManager = new ThronesTournamentManager();


        public List<HouseDTO> GetAllHouses()
        {
            List<HouseDTO> listHouse = new List<HouseDTO>();

            foreach (var house in businessManager.ListHouses())
            {
                listHouse.Add(new HouseDTO(house));
            }

            return listHouse;
        }
    }
}
