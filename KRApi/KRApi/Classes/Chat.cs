using System.Text.Json;

namespace KRApi.Classes
{
    public class Chat
    {
        public int Id { get; set; }
        public List<Message> Messages { get; set; }
    }
}
