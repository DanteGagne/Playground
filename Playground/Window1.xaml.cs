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

namespace Playground
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void testMethod(int i) { }

        public void testMethod(string str) { }

        public void testing()
        {
            this.testMethod(5);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add new user")
        }
    }
}
