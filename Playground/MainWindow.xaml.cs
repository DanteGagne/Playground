#region Header Goes Here
// This is a file header line 1
// I don't believe in weaponized fowl
// This is a file header line 3
#endregion


using System.Windows;

// This is a file header line 1
// I don't believe in weaponized turkeys
// This is a file header line 3

namespace Playground // TODO: Do the thing
    // TODO: Do the other thing
    // TODO: Don't do the thing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml Hello
    /// World
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Hello
            this.InitializeComponent();
            // World
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int j = 8;
            // Hello World
            string MyString = string.Concat("This is a click handler " + j.ToString());
            MessageBox.Show(MyString);

            Class1 c1 = new Class1();
            c1.Junk();
        }
    }
}
