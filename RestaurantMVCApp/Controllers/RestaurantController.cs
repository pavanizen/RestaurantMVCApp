using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCApp.Models;

namespace RestaurantMVCApp.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            var rest = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="PlainPizza",RestaurantName="Swagath",Cusine=CusineType.Italian},
                 new Restaurant{Id=2,Name="Burger",RestaurantName="Bawarchi",Cusine=CusineType.French},
                  new Restaurant{Id=3,Name="FrenchFries",RestaurantName="Sitara",Cusine=CusineType.Indian},
                   new Restaurant{Id=4,Name="Samosa",RestaurantName="NVillage",Cusine=CusineType.None}

            };
            return View(rest);
        }
        public ActionResult FoodImage()
        {
            return View();
        }
        public ActionResult RestaurantNames()
        {
            var rests = new List<Restaurant>
            {
                new Restaurant{RestaurantName="Swagath"},
                new Restaurant{RestaurantName="Bawarchi"},
                new Restaurant{RestaurantName="Sitara"}
            };
            return View(rests);
        }
        //public ActionResult RestaurantDetails()
        //{
        //    var rests = new List<Restaurant>
        //    {
        //        new Restaurant{RestaurantName="Swagath"},
        //        new Restaurant{RestaurantName="Bawarchi"},
        //        new Restaurant{RestaurantName="Sitara"}
        //    };
        //}
       
public ActionResult Details(int id)
        {
            var rest = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="PlainPizza",RestaurantName="Swagath",Cusine=CusineType.Italian},
                 new Restaurant{Id=2,Name="Burger",RestaurantName="Bawarchi",Cusine=CusineType.French},
                  new Restaurant{Id=3,Name="FrenchFries",RestaurantName="Sitara",Cusine=CusineType.Indian},
                   new Restaurant{Id=4,Name="Samosa",RestaurantName="NVillage",Cusine=CusineType.None}

            };
    Restaurant re = null;
    foreach(var item in rest)
    {
        if(item.Id==id)
        {
            re = item;
        }
    }
            return View(re);
        }
    }
}