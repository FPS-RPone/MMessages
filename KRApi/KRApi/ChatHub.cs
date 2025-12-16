using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace KRApi
{
    public class ChatHub : Hub {
        internal static DbChatContext db = new DbChatContext();

        public async Task Send(int SentById, int ChatId, string MessageText)
        {  
            try {
                var chat = await db.Chats.FirstOrDefaultAsync(x => x.Id == ChatId);

                List<Message> messages;

                await Task.Run(() =>
                {
                    if (chat != null && chat.messages != null)
                        messages = chat.messages;
                    else messages = new List<Message>();

                        var Message = new Message(SentById, MessageText, DateTime.Now.ToString());

                    chat!.messages.Add(Message);
                });

                await Clients.Caller.SendAsync(messages);
            }
            catch(Exception ex)
            {
                await Clients.Caller.SendAsync(ex.ToString());
            }
        }

    }
}
