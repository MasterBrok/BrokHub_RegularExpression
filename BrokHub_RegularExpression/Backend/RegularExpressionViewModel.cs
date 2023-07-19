
using BrokHub_RegularExpression.Backend.AppCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using BrokHub_RegularExpression.Models;
using BrokHub_RegularExpression.Controls.ControlListBox;
using System.Windows.Controls;
using System.Windows;
using BrokHub_RegularExpression.BrokData;
using BrokHub_RegularExpression.Controls.ControlRegex;

namespace BrokHub_RegularExpression.Backend
{
    public class RegularExpressionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        #region All Private Property
        private Regex _regex;
        #endregion


        #region All Public Property

        public Regex Regex
        {
            set
            {
                _regex = value;
                Notify(nameof(Regex));
            }
            get
            {
                return _regex;
            }
        }
        public List<Regex>? ListTitleIltem
        {
            get
            {
                return new BrokData.ListData().Regexes;
            }
        }

        #endregion


        #region All Private ICommand
        private ICommand _cmdReadTitle;
        #endregion


        #region All Public ICommand
        public ICommand CmdReadTitle
        {
            get
            {
                if (_cmdReadTitle == null)
                    _cmdReadTitle = new RelayCommand(ReadTitle, CanReadTitle);
                return _cmdReadTitle;
            }
        }



        #endregion

        #region All Function

        public void Notify(string target)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(target));
        }
        private bool CanReadTitle(object obj)
        {
            return true;
        }

        private void ReadTitle(object obj)
        {
            ListBox? box = ((object[])obj)[0] as ListBox;
            StackPanel? panel = ((object[])obj)[1] as StackPanel;
            Regex = new BrokData.ListData().Regexes.LastOrDefault(r => r.Title == (box.SelectedItem as Regex).Title.ToString());
            var sub = new ListData().Regexes.Where(e => e.Title == (box.SelectedItem as Regex).Title.ToString()).Select(f => f.SubRegex);
            panel.Children.Clear();

            foreach (var items in sub)
            {
                foreach (var item in items)
                {
                    //MessageBox.Show(item.SubTitle);
                    panel.Children.Add(new ccSubRegex() { RegexSubTitle = item.SubTitle, RegexSubDescription = item.SubDescription, RegexSubSource = item.Regex });
                }
            }


        }

        #endregion

    }

}
