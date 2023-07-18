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

namespace BrokHub_RegularExpression.Windows
{
    /// <summary>
    /// Interaction logic for wMainPage.xaml
    /// </summary>
    public partial class wMainPage : Window
    {
        public wMainPage()
        {
            InitializeComponent();
        }

        private void wn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
