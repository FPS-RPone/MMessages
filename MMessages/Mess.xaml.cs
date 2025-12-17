using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Win32;
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

            InitializeComponent();

            lBoxMessages.ItemsSource = messages;

            lBoxContacts.ItemsSource = contacts;
        }

        private void buttSend_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
