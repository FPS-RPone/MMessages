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
        public string? MessageText { get; set; }
        public string? MessageDate { get; set; }
        public bool isSent { get; set; } = false;

        public Message(string? text, string? date)
        {
            MessageText = text;
            MessageDate = date;
        }
    }

    public class Contact
    {
        public int? Id { get; } = 0;
        public string? Name { get; set; }
        public string? Pfp { get; set; } = "mrbrokenglasses.png";
        //public Image? Pfp { get; set; }

        public Contact(string? name) {
            Name = name;
        }
    }
}
