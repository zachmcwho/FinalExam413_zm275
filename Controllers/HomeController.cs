﻿using FinalExam413_zm275.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413_zm275.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // !!! for some reason I was not able to get the Update and Delete functionality to work with the Repository pattern. I figured it would be best to turn in something that works
        // however, I did impement repository pattern first !!!
        //private IEntertainmentAgencyRepository repo;

        //public HomeController(ILogger<HomeController> logger, IEntertainmentAgencyRepository temp)
        //{
        //    _logger = logger;
        //    repo = temp;
        //}

        private EntertainmentAgencyExampleContext context;
        public HomeController(EntertainmentAgencyExampleContext temp)
        {
            
            context = temp;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Entertainers()
        {
            var Entertainers = context.Entertainers.ToList();
            return View(Entertainers);
        }
        [HttpGet]
        public IActionResult EntertainerCreate()
        {
            Entertainers e = new Entertainers();
            return View(e);
        }
        [HttpPost]
        public IActionResult EntertainerCreate(Entertainers e)
        {
            context.Entertainers.Add(e);
            context.SaveChanges();
            return RedirectToAction("Entertainers");
        }
        public IActionResult EntertainerDetails(long id)
        {
            var Entertainer = context.Entertainers.Where(x => x.EntertainerId == id).First();
            return View(Entertainer);
        }
        [HttpGet]
        public IActionResult EntertainerEdit(long id)
        {
            var Entertainer = context.Entertainers.Where(x => x.EntertainerId == id).First();
            return View(Entertainer);
        }
        [HttpPost]
        public IActionResult EntertainerEdit(Entertainers e)
        {
            context.Update(e);
            context.SaveChanges();
            return RedirectToAction("Entertainers");
        }
        [HttpGet]
        public IActionResult EntertainerDelete(long id)
        {
            var Entertainer = context.Entertainers.Where(x => x.EntertainerId == id).First();
            return View(Entertainer);
        }
        [HttpPost]
        public IActionResult EntertainerDelete(Entertainers e)
        {
            context.Entertainers.Remove(e);
            context.SaveChanges();
            return RedirectToAction("Entertainers");
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
    }
}
