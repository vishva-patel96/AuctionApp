using AuctionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionApp.Data.Services
{
    public class ListingService : IListing
    {
        private readonly ApplicationDbContext _context;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
