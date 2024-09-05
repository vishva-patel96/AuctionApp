namespace AuctionApp.Data.Services
{
    public interface IListing
    {
        IQueryable<Models.Listing> GetAll();
    }
}
