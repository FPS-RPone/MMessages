using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<Message> messages;
        public Mess()
        {
            messages = new List<Message>();

            messages.Add(new Message("Привет", true, DateTime.Now.ToString()));
            messages.Add(new Message("Привет", false, DateTime.Now.ToString()));
            messages.Add(new Message("И тебе привет", true, DateTime.Now.ToString()));
            messages.Add(new Message("Как жизнь?", false, DateTime.Now.ToString()));
            messages.Add(new Message("Всё хорошо!", true, DateTime.Now.ToString()));
            messages.Add(new Message("Пока ;)", false, DateTime.Now.ToString()));

            InitializeComponent();

            lBoxMessages.ItemsSource = messages;
        }

        private void buttSend_Click(object sender, RoutedEventArgs e)
        {
        }

        private void tBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            lBoxMessages.ItemsSource = null;
            if (tBoxSearch.Text != null && tBoxSearch.Text != "")
            {
                lBoxMessages.ItemsSource = messages.Where(x => x.MessageText!.Contains(tBoxSearch.Text)).ToList();
            }
            else
                lBoxMessages.ItemsSource = messages;
        }
    }
}
