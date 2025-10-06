using DocumentFormat.OpenXml.Bibliography;
using StackExchange.Redis;

namespace AuctionApp.Service

{
    public class LeaderboardService
    {
        private readonly IdDatabase_db;
        private const string LeaderBoardKey = "LeaderBoard";
        public LeaderboardService(IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
        }
        public async Task AddOrUpdateScoreAsync(string PlayerName, double Score)
        {
            await_db.SortedSetAddAsync(LeaderBoardKey, PlayerName, Score);
        }
    }
}
