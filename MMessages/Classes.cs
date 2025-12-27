using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MixedMessagesClient
{
    public class Message
    {
        public string? MessageText { get; }
        public string? MessageDate { get; }
        public bool IsSent { get; set; }
        private int SentById = 0;
        

        public Message(string? text, bool isSent, string? date)
        {
            MessageText = text;
            IsSent = isSent;
            MessageDate = date;

        }
    }

    public class Contact
    {
        public string Tag { get; }
        public string? Nickname { get; set; }
        public string? Image { get; set; } = "E:\\!\\mrbrokenglasses.png";
        //public Image? Pfp { get; set; }

        public Contact(string tag, string nickname)
        {
            Nickname = nickname;
            Tag = tag;
        }
    }
}
