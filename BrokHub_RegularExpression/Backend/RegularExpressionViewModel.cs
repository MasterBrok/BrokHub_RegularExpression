
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
using BrokHub_RegularExpression.Controls.Buttons;
using BrokHub_RegularExpression.Windows;

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
        private ICommand _cmdCopyRegex;
        private ICommand _cmdClose;
        private ICommand _cmdHide;
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
        public ICommand CmdCopyRegex
        {
            get
            {
                if (_cmdCopyRegex == null)
                    _cmdCopyRegex = new RelayCommand(CopyRegex, CanCopyRegex);
                return _cmdCopyRegex;
            }
        }

        public ICommand CmdClose
        {
            get
            {
                if (_cmdClose == null)
                    _cmdClose = new RelayCommand(Close_MouseClick, CnaClose_MouseClick);
                return _cmdClose;
            }
        }
        public ICommand CmdHide
        {
            get
            {
                if (_cmdHide == null)
                    _cmdHide = new RelayCommand(Hide_MouseClick, CanHide_MouseClick);
                return _cmdHide;
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
                    var child = new ccSubRegex() { RegexSubTitle = item.SubTitle, RegexSubDescription = item.SubDescription, RegexSubSource = item.Regex, CommandCopyRegex = CmdCopyRegex };
                    
                    panel.Children.Add(child);
                }
            }
        }


        private bool CanCopyRegex(object obj)
        {
            return true;
        }

        private void CopyRegex(object obj)
        {
            Clipboard.SetText((obj as TextBlock).Text);
        }


        private bool CnaClose_MouseClick(object obj)
        {
            return true;
        }

        private void Close_MouseClick(object obj)
        {
            wRegularExpression page = (obj as wRegularExpression);
            Application.Current.Shutdown();
            page.Close();
        }

        private bool CanHide_MouseClick(object obj)
        {
            return true;
        }

        private void Hide_MouseClick(object obj)
        {
            wRegularExpression page = (obj as wRegularExpression);
            page.WindowState = WindowState.Minimized;
        }
        #endregion

    }

}
