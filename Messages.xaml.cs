using IO.Ably;
using IO.Ably.Realtime;
using IO.Ably.Rest;
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
    /// Interaction logic for Messages.xaml
    /// </summary>
    public partial class Messages : Window
    {
        AblyRealtime ably = new AblyRealtime("FAZ-qw.-u0lHw:lyX4DPHqfBMUvs5bWGSpb1HnALRaeGmvP53j7LsTePY");
        public Messages()
        {
            InitializeComponent();
            ably.Connect();
            ably.Connection.On(ConnectionEvent.Connected, args =>
            {
                
            });
        }
        

        private void buttSend_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
