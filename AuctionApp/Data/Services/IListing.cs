using AuctionApp.Models;

namespace AuctionApp.Data.Services
{
    public interface IListing
    {
        IQueryable<Listing> GetAll();
    }
}
