using Microsoft.AspNetCore.SignalR.Client;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MixedMessagesClient;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    HubConnection connection;
    public MainWindow()
    {
        InitializeComponent();
        //tBoxPassword.Visibility = Visibility.Hidden;
        
        connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5089/chat")
            .WithAutomaticReconnect()
            .Build();

        connection.On<bool>("GetResult", (result) =>
        {
            Dispatcher.Invoke(() =>
            {
                tBoxStatus.Text = result.ToString();
            });
        });

        try
        {
            connection.StartAsync();
            //tBoxStatus.Text = "Online!";
        }
        catch (Exception ex)
        {
            tBoxStatus.Text = ex.Message;
        }
    }

    private async void buttLogin_Click(object sender, RoutedEventArgs e)
    {
        string password = tBoxPassword.Password;
        string username = tBoxLogin.Text;

        try
        {
            tBoxStatus.Text = "Неправильный логин или пароль";
            
            //await connection.InvokeAsync("Login", username, password);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Не удалось подключиться к серверу", "Ошибка");
            tBlockStatus.Text = ex.ToString();
        }
    }
}