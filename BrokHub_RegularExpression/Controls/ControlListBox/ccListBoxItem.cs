using System;

using System.Windows;
using System.Windows.Controls;

namespace BrokHub_RegularExpression.Controls.ControlListBox
{
    
    public class ccListBoxItem : ListBoxItem
    {
        static ccListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccListBoxItem), new FrameworkPropertyMetadata(typeof(ccListBoxItem)));
        }
    }
}
