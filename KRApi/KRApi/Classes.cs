using static System.Reflection.Metadata.BlobBuilder;
using System.Text.Json;

namespace KRApi
{
    public class Account
    {
        internal int Id { get; set; }
        public string Tag { get; set; }
        public string Nickname { get; set; }
        internal string? ImagePath { get; set; } = "resources/pfptemp.png";

        public Account(int id, string tag, string nickname)
        {
            Id = id;
            Tag = tag;
            Nickname = nickname;
        }
    }
    public class Chat
    {
        internal static string FilePath = "chats/";
        internal int Id { get; set; }
        internal List<Account> accounts { get; set; } = new List<Account>();
        internal List<Message> messages { get; set; } = new List<Message>();

        internal Chat(List<Account> accounts, List<Message> messages)
        {
            this.accounts = accounts;
            this.messages = messages;
        }

        internal List<Chat> LoadJson()
        {
            if (!File.Exists($"{FilePath}{Id}"))
                return new List<Chat>();
            string json = File.ReadAllTextAsync(FilePath).ToString()!;
            return JsonSerializer.Deserialize<List<Chat>>(json)!;
        }

        internal void SaveJson(List<Chat> chat)
        {
            string json = JsonSerializer.Serialize(chat, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllTextAsync($"{FilePath}{Id}", json);
        }
    }
    public class Message
    {
        internal int ChatId { get; set; }
        internal int SentById { get; set; }
        public string? MessageText { get; set; }
        public string MessageDate { get; set; } = DateTime.Now.ToString();

        public Message(int sentById, string? messageText, string messageDate)
        {
            SentById = sentById;
            MessageText = messageText;
            MessageDate = messageDate;
        }
    }
}
