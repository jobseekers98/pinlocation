using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationContext dbcontext;

        private readonly INotyfService _notyf;
        public HomeController(ILogger<HomeController> logger, ApplicationContext _dbcontext, INotyfService notyf)
        {
            _logger = logger;
             dbcontext = _dbcontext;
            _notyf = notyf;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index(tbl_location location)
        {
          
            
                var data = dbcontext.tbl_Locations.Add(location);
                    await dbcontext.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                ViewBag.msg = "Record has been Added";
            
                return View(location);
        }

        public IActionResult Privacy()
        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult BindData() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BindData(tbl_location tbl)
        {
            //tbl_location tbl = new tbl_location();
            //tbl.Id = Id;
            //tbl.Latitude = latitude;
            //tbl.Address = Address;
            //tbl.Longitude = longitude;

            dbcontext.tbl_Locations.Add(tbl);
            await dbcontext.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));
            ViewBag.msg = "Record has been Added";
            return View(tbl);
        }

        public IActionResult ConcateNateQuery(tbl_location tbl)
        {

            return View();
        
        }


        [HttpGet]
        public IActionResult TestAddress() 
        {
            AddressVM model = new AddressVM();
            model.StateDropDownList = dbcontext.tbl_SaveState.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult TestAddress(AddressVM model)
        {
            try
            {
                //int Ack = 0;
              //  bool success;
                //string msg = string.Empty;

                var a = model.Address1.Split(',');
                model.Address1 = $"{a[0]}, {a[1]}, {a[2]}";
                var b = model.Address2.Split(',');
                model.Address2 = $"{a[0]}, {a[1]}, {a[2]}";

                Address vm = new Address()
                {

                    City = model.City,
                    StateId = model.StateId,
                    District = model.District,
                    country = model.country,
                    Latitude = model.Latitude,
                    Longitude = model.Longitude,
                    Postal = model.Postal,
                    Address1 = model.Address1,
                    Address2= model.Address2,
                    StateId1 = model.StateId1,
                    District1 = model.District1,
                    country1 = model.country1,
                    Latitude1 = model.Latitude1,
                    Longitude1 = model.Longitude1,
                    Postal1 = model.Postal1,
                    Distance=model.Distance 

                };
                dbcontext.tbl_SaveAddress.Add(vm);
                int i = dbcontext.SaveChanges();
                if (i == 1)
                {
                    var Jsonobj = new {success = true, msg = "Data save successfuly" };
                    return new JsonResult(Jsonobj);

                }
            }

            catch (Exception ex)
            {
                ex.ToString();
            }
            return View(model);



        }


        [HttpGet]
        public IActionResult TestAddress2()
        {
            AddressVM2 model = new AddressVM2();
            // model.StateDropDownList = dbcontext.tbl_SaveState.ToList();
            return View(model);
        }



        [HttpPost]
        public IActionResult TestAddress2(AddressVM2 model)
        {
            try
            {
                //int Ack = 0;
                //  bool success;
                string msg = string.Empty;
                var a = model.Address1.Split(',');
                model.Address1 = $"{a[0]}, {a[1]}, {a[2]}";
                Address vm = new Address()
                {

                    City = model.City,
                    StateId = model.StateId,
                    District = model.District,
                    country = model.country,
                    Latitude = model.Latitude,
                    Longitude = model.Longitude,
                    Postal = model.Postal,
                    Address1 = model.Address1
                };
                dbcontext.tbl_SaveAddress.Add(vm);
                int i = dbcontext.SaveChanges();
                if (i == 1)
                {
                    var Jsonobj = new { success = true, msg = "Data save successfuly" };
                    return new JsonResult(Jsonobj);

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View(model);



        }

        public IActionResult FindLocation(AddressVM model) 
        {

            return View();
        
        }


    }
}
