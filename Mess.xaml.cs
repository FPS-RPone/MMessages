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
        public Mess()
        {
            List<Message> messages = new List<Message>();

            List<Contact> contacts = new List<Contact>();

            messages.Add(new Message("meeee", DateTime.Now.ToString()));
            messages.Add(new Message("i luv my bf :3", DateTime.Now.ToString()));
            messages.Add(new Message("wtf", DateTime.Now.ToString()));
            messages.Add(new Message("meeee", DateTime.Now.ToString()));
            messages.Add(new Message("i luv my bf :3", DateTime.Now.ToString()));
            messages.Add(new Message("wtf", DateTime.Now.ToString()));
            messages.Add(new Message("meeee", DateTime.Now.ToString()));
            messages.Add(new Message("i luv my bf :3", DateTime.Now.ToString()));
            messages.Add(new Message("wtf", DateTime.Now.ToString()));
            messages.Add(new Message("meeee", DateTime.Now.ToString()));
            messages.Add(new Message("i luv my bf :3", DateTime.Now.ToString()));
            messages.Add(new Message("wtf", DateTime.Now.ToString()));

            contacts.Add(new Contact("Honse"));

            foreach(var message in messages)
            {
                if (message.MessageText == "i luv my bf :3")
                    message.isSent = true;
            }

            InitializeComponent();

            lBoxMessages.ItemsSource = messages;

            lBoxContacts.ItemsSource = contacts;
        }
    }
}
