using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MixedMessagesClient
{
    /// <summary>
    /// Логика взаимодействия для Mess.xaml
    /// </summary>
    public partial class Mess : Window
    {
        public class Message
        {
            string? Text;
            string? Date;

            public Message(string? text, string? date)
            {
                Text = text;
                Date = date;
            }
        }

        List<Message> messages = new List<Message>();
        public Mess()
        {
            InitializeComponent();
            messages.Add(new Message("meeee", "9.9.9"));
            messages.Add(new Message("aaaaaa", "9.9"));
            messages.Add(new Message("wtf", "91.9.9"));

            lBoxMessages.ItemsSource = messages;
        }
    }
}
