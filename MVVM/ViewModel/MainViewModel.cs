﻿using Paneltest_WPF.Core;

namespace Paneltest_WPF.MVVM.ViewModel
{
    internal class MainViewModel : observableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand newView1ViewCommand { get; }
        public RelayCommand newView2ViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public newView1ViewModel newView1VM { get; set; }
        public newView2ViewModel newView2VM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            newView1VM = new newView1ViewModel();
            newView2VM = new newView2ViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            newView1ViewCommand = new RelayCommand(o =>
            {
                CurrentView = newView1VM;
            });

            newView2ViewCommand = new RelayCommand(o =>
            {
                CurrentView = newView2VM;
            });
        }
    }
}