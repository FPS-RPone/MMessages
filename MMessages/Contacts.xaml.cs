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
    /// Interaction logic for Contacts.xaml
    /// </summary>
    public partial class Contacts : Window
    {
        public Contacts()
        {
            List<Contact> contacts = new List<Contact>();

            Contact Lainy = new Contact("@Lainy", "Лайни");
            Lainy.Image = "E:\\!\\fsh.png";
            Contact Bill = new Contact("@D-FENS", "Bill");

            contacts.Add(Lainy);
            contacts.Add(Bill);

            InitializeComponent();

            lBoxContacts.ItemsSource = contacts;
        }
    }
}
