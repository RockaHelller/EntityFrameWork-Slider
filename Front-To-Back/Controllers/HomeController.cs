using Front_To_Back.Data;
using Front_To_Back.Models;
using Front_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            HomeVM home = new()
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Strategies = _context.Strategies.ToList()
                
                //Features = GetAllFeatures(),
                //Service = GetAllServices(),



            };
            return View(home);
        }


        private List<Feature> GetAllFeatures()
            {


                Feature f1 = new()
                {
                    Title = "Murad",
                    Description = "Murad description",
                    Icon = "icon-1.png"
                };

                Feature f2 = new()
                {
                    Title = "Musa",
                    Description = "Musa description",
                    Icon = "icon-2.png"
                };

                Feature f3 = new()
                {
                    Title = "Resul",
                    Description = "Resul description",
                    Icon = "icon-3.png"
                };

                Feature f4 = new()
                {
                    Title = "Nicat",
                    Description = "Nicat description",
                    Icon = "icon-4.png"
                };

                List<Feature> features = new() { f1, f2, f3, f4 };
                return features;
            }

        private List<Service> GetAllServices()
        {

            Service s1 = new()
            {
                Title = "Murad",
                Description = "Murad description",
                Icon = "icon-1.png"
            };

            Service s2 = new()
            {
                Title = "Musa",
                Description = "Musa description",
                Icon = "icon-2.png"
            };

            Service s3 = new()
            {
                Title = "Resul",
                Description = "Resul description",
                Icon = "icon-3.png"
            };

            Service s4 = new()
            {
                Title = "Nicat",
                Description = "Nicat description",
                Icon = "icon-4.png"
            };

            Service s5 = new()
            {
                Title = "Mahir",
                Description = "Mahir description",
                Icon = "icon-5.png"
            };

            Service s6 = new()
            {
                Title = "Ramil",
                Description = "Ramil description",
                Icon = "icon-6.png"
            };

            List<Service> services = new() { s1, s2, s3, s4, s5, s6 };
            return services;

        }



        }

    }
