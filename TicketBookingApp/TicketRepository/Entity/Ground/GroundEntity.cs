﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.City;

namespace TicketRepository.Entity.Ground
{
    public class GroundEntity
    {
        public int Id { get; set; }
        public string GroundName { get; set; }
        public CityEntity  City { get; set; }
        public int CityId { get; set; }
    }
}
