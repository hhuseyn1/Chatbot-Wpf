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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chatbot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Messages = new List<string>();
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
                    Messages.Add(txtbox_Message.Text.ToString());
                    list_Messages.ItemsSource = null;
                    list_Messages.ItemsSource = Messages;
                }
            }
        }
    }
}
