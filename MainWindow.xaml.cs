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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_GoToLogIn(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Button pressed");
            LogInScreen logInScreen = new LogInScreen();
            logInScreen.Owner = this;
            this.Hide();
            logInScreen.Show();
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            RegisterScreen r1 = new RegisterScreen();
            this.Close();
            r1.Show();
        }
    }
}
