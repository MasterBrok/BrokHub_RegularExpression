using System.Windows;
using System.Windows.Controls;

namespace BrokHub_RegularExpression.Controls.ControlListBox
{
   
    public class ccListBox : ListBox
    {
        static ccListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccListBox), new FrameworkPropertyMetadata(typeof(ccListBox)));
        }
    }
}
