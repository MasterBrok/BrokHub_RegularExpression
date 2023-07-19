﻿using System.Windows;
using System.Windows.Controls;

namespace BrokHub_RegularExpression.Controls.ControlRegex
{
    
    public class ccSubRegex : Control
    {
        static ccSubRegex()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccSubRegex), new FrameworkPropertyMetadata(typeof(ccSubRegex)));
        }

        public string RegexSubTitle
        {
            get { return (string)GetValue(RegexSubTitleProperty); }
            set { SetValue(RegexSubTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegexSubTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexSubTitleProperty =
            DependencyProperty.Register("RegexSubTitle", typeof(string), typeof(ccSubRegex), new PropertyMetadata(string.Empty));



        public string RegexSubDescription
        {
            get { return (string)GetValue(RegexSubDescriptionProperty); }
            set { SetValue(RegexSubDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegexSubDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexSubDescriptionProperty =
            DependencyProperty.Register("RegexSubDescription", typeof(string), typeof(ccSubRegex), new PropertyMetadata(string.Empty));



        public string RegexSubSource
        {
            get { return (string)GetValue(RegexSubSourceProperty); }
            set { SetValue(RegexSubSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegexSubSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegexSubSourceProperty =
            DependencyProperty.Register("RegexSubSource", typeof(string), typeof(ccSubRegex), new PropertyMetadata(string.Empty));


    }
}
