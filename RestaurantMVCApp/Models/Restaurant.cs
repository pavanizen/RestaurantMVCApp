﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMVCApp.Models
{
    
   
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string RestaurantName { get; set; }
        public  CusineType Cusine { get; set; }
    }
}