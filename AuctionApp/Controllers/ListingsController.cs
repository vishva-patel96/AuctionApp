using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuctionApp.Data;
using AuctionApp.Models;
using AuctionApp.Data.Services;

namespace AuctionApp.Controllers
{
    public class ListingsController : Controller
    {
        private readonly IListing _listingService;

        public ListingsController(IListing listingService)
        {
            _listingService = listingService;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _listingService.GetAll();
            return View(await applicationDbContext.ToListAsync());
        }

       
    }
}
