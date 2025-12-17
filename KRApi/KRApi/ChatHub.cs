using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace KRApi
{
    public class ChatHub : Hub {
        internal static DbChatContext db = new DbChatContext();
        internal static List<Tuple<string, int>> connectedAccounts = new List<Tuple<string, int>>();
        //ConnectionId - AccountId
        public async Task Login(string username, string password)
        {
            var account = db.accounts.Where(x => (x.Name == username && x.Password == password)).FirstOrDefaultAsync();
            if (account == null)
            {
                await Clients.Caller.SendAsync("GetResult", false);
                return;
            }
            else await Clients.Caller.SendAsync("GetResult", true);
            connectedAccounts.Add(new Tuple<string, int>(Context.ConnectionId, account.Id));
        }
    }
}
