﻿
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
namespace HotelProject.EntityLayer.Concrate
{
    public class WorkLocation
    {
        public int WorkLocationID { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
