namespace KRApi.Classes
{
    public class Message
    {
        public string MessageText { get; set; } = "";
        public string MessageDate { get; set; } = DateTime.Now.ToString();
        public int SentBy { get; set; }

        public Message(string messageText, int sentBy)
        {
            MessageText = messageText;
            SentBy = sentBy;
        }
    }
}
