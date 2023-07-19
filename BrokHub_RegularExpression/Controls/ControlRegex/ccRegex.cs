using System.Windows;
using System.Windows.Controls;

namespace BrokHub_RegularExpression.Controls.ControlRegex
{
    public class ccRegex : Control
    {
        static ccRegex()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccRegex), new FrameworkPropertyMetadata(typeof(ccRegex)));
        }


        public string RegexTitle
        {
            get { return (string)GetValue(RegexTitleProperty); }
            set { SetValue(RegexTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegexTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexTitleProperty =
            DependencyProperty.Register("RegexTitle", typeof(string), typeof(ccRegex), new PropertyMetadata(string.Empty));




        public string RegexCode
        {
            get { return (string)GetValue(RegexCodeProperty); }
            set { SetValue(RegexCodeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Code.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexCodeProperty =
            DependencyProperty.Register("RegexCode", typeof(string), typeof(ccRegex), new PropertyMetadata(string.Empty));



        public string RegexDescription
        {
            get { return (string)GetValue(RegexDescriptionProperty); }
            set { SetValue(RegexDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexDescriptionProperty =
            DependencyProperty.Register("RegexDescription", typeof(string), typeof(ccRegex), new PropertyMetadata(string.Empty));




    }
}
