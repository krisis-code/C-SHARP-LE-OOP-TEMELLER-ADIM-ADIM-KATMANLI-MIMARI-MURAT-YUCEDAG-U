﻿using Microsoft.AspNetCore.Mvc;
using Proje_Opp.AppContext;
using Proje_Opp.Entity;
using System.Linq;

namespace Proje_Opp.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
