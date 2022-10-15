using System;
using System.Collections;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public WelcomeScreen()
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

        private void Button_AddItem(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void Button_DeleteItem(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }

        private void Button_AddNewNote(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show("Add new note");
            Note note = new Note();

            Random random = new Random();
            SolidColorBrush brush =
            new SolidColorBrush(
                Color.FromRgb(
                (byte)random.Next(255),
                (byte)random.Next(255),
                (byte)random.Next(255)
                ));

            //note.Background = brush;
            note.NoteTextBox.Background = brush;

            note.Show();
        }
       
    }
}
