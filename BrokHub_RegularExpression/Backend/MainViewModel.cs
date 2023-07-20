
using BrokHub_RegularExpression.Backend.AppCommands;
using BrokHub_RegularExpression.Controls.ControlMenu;
using BrokHub_RegularExpression.Windows;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;

namespace BrokHub_RegularExpression.Backend
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        #region All Private Property
        private Uri _sourcePage = new Uri("\\Pages\\Home.xaml", UriKind.Relative);
        #endregion

        #region All Private Command 

        private ICommand _cmdChangeSourcePage;
        private ICommand _cmdOpenWindow;
        private ICommand _cmdPopup;
        private ICommand _cmdClose;
        private ICommand _cmdHide;
        #endregion

        #region All Public Property
        public Uri SourcePage
        {
            get { return _sourcePage; }
            set
            {
                _sourcePage = value;
                Notify(nameof(SourcePage));
            }
        }

        #endregion

        #region All Command Property
        public ICommand CmdChangedSourcePage
        {
            get
            {
                if (_cmdChangeSourcePage == null)
                    _cmdChangeSourcePage = new RelayCommand(ChangedSourcePage_Click, CanChangedSourcePage_bool);
                return _cmdChangeSourcePage;
            }
        }

        public ICommand CmdPopup
        {
            get
            {
                if (_cmdPopup == null)
                    _cmdPopup = new RelayCommand(Popup_MouseDown, CnaPopup_MouseDown);
                return _cmdPopup;
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
                    _cmdHide= new RelayCommand(Hide_MouseClick, CanHide_MouseClick);
                return _cmdHide;
            }
        }

        private bool CnaPopup_MouseDown(object obj)
        {
            return true;
        }

        private void Popup_MouseDown(object obj)
        {
            wMainPage page = (obj as wMainPage);
            page.DragMove();
        }

        public ICommand CmdOpenWiundow
        {
            get
            {
                if (_cmdOpenWindow == null)
                    _cmdOpenWindow = new RelayCommand(OpenWindow_Click, CanOpenWindow_Click);
                return _cmdOpenWindow;
            }
        }

        #endregion

        #region All Function

        private bool CnaClose_MouseClick(object obj)
        {
            return true;
        }

        private void Close_MouseClick(object obj)
        {
            wMainPage page = (obj as wMainPage);
            Application.Current.Shutdown();
            page.Close();
        }

        private bool CanHide_MouseClick(object obj)
        {
            return true;
        }

        private void Hide_MouseClick(object obj)
        {
            wMainPage page = (obj as wMainPage);
            page.WindowState = WindowState.Minimized;
        }



        private bool CanDrogMove_MouseDown(object obj)
        {
            return true;
        }

        private void DrogMove_MouseDown(object obj)
        {
            wMainPage page = obj as wMainPage;
            page.DragMove();
        }


        private bool CanChangedSourcePage_bool(object obj)
        {
            return true;
        }

        private void ChangedSourcePage_Click(object obj)
        {
            string? header = (obj as ccMenuItem)?.Header.ToString();
            switch (header)
            {
                case "Developer":
                    SourcePage = new Uri("\\Pages\\Developer.xaml", UriKind.Relative);
                    break;
                case "Home":
                    SourcePage = new Uri("\\Pages\\Home.xaml", UriKind.Relative);
                    break;
                default:
                    break;
            }

        }
        private bool CanOpenWindow_Click(object obj)
        {
            return true;
        }

        private void OpenWindow_Click(object obj)
        {
            wMainPage main = obj as wMainPage;
            main.Visibility = Visibility.Hidden;
            wRegularExpression window = new();

            window.ShowDialog();
        }


        public void Notify(string Target)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Target));
        }






        #endregion

    }
}
