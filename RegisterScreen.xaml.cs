using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        public RegisterScreen()
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

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6542;Initial Catalog=MyNotesDB;Integrated Security=True");    
                con.Open();
                string add_data = "INSERT INTO [dbo].[User] VALUES(@username, @password, @email)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@username", RegisterUsernameBox.Text);
                cmd.Parameters.AddWithValue("@password", RegisterPasswordBox.Password);
                cmd.Parameters.AddWithValue("@email", RegisterEmailBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                RegisterUsernameBox.Text = "";
                RegisterPasswordBox.Password = "";
                RegisterEmailBox.Text = "";


                WelcomeScreen w1 = new WelcomeScreen();
                this.Close();
                w1.Show();

            }
            catch
            {
            }
        }
    }
}
