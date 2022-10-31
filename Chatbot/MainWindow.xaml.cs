using Chatbot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chatbot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Message> Messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Messages = new List<Message>();
        }

        private void İmage_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Sendbtn_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if (!string.IsNullOrEmpty(txtbox_Message.Text) && !string.IsNullOrWhiteSpace(txtbox_Message.Text))
                {
                    list_Messages.ItemsSource = null;
                    Messages.Add(new Message() {
                        Sender="Me",
                        MessageText=txtbox_Message.Text,
                        SendedTime=DateTime.Now
                    });
                    
                    Thread.Sleep(1000);
                    Messages.Add(new Message()
                    {
                        Sender = "DomToretto",
                        MessageText = txtbox_Message.Text,
                        SendedTime = DateTime.Now
                    });
                    
                    txtbox_Message.Text=string.Empty;
                    list_Messages.ItemsSource = null;
                    list_Messages.ItemsSource = Messages;
                }
            }
        }
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Sender is DomToretto Family is Everyhting", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
