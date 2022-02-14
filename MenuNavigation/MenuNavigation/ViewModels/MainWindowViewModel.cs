using MenuNavigation.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace MenuNavigation.ViewModels
{
    
    public class MainWindowViewModel : ViewModel
    {
        #region Polja
        private bool checker;

        private NavigationService navService;

        private string currentLanguage;

        public bool Checker
        {
            get { return checker; }
            set
            {
                checker = value;
                OnPropertyChanged();
            }
        }

        public NavigationService NavService
        {
            get { return navService; }
            set
            {
                navService = value;
            }
        }

        public string CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;
            }
        }
        #endregion

        #region Komande
        private RelayCommand navigateToMainPageCommand;

        private RelayCommand navigateToStudentPageCommand;

        private RelayCommand openMenuCommand;

        private RelayCommand navigateToTeacherCommand;

        private RelayCommand navigateToSubjectCommand;

        private RelayCommand switchLanguageCommand;

        public RelayCommand NavigateToMainPageCommand
        {
            get { return navigateToMainPageCommand; }
            set
            {
                navigateToMainPageCommand = value;
            }
        }

        public RelayCommand NavigateToStudentPageCommand
        {
            get { return navigateToStudentPageCommand; }
            set
            {
                navigateToStudentPageCommand = value;
            }
        }

        public RelayCommand NavigateToTeacherPageCommand
        {
            get { return navigateToTeacherCommand; }
            set
            {
                navigateToTeacherCommand = value;
            }
        }

        public RelayCommand NavigateToSubjectPageCommand
        {
            get { return navigateToSubjectCommand; }
            set
            {
                navigateToSubjectCommand = value;
            }
        }

        public RelayCommand OpenMenuCommand
        {
            get { return openMenuCommand; }
            set
            {
                openMenuCommand = value;
            }
        }

        public RelayCommand SwitchLanguageCommand
        {
            get { return switchLanguageCommand; }
            set
            {
                switchLanguageCommand = value;
            }
        }
        #endregion

        #region Akcije
        private void Execute_NavigateToMainPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Pocetna.xaml", UriKind.Relative));
        }

        private bool CanExecute_NavigateCommand(object obj)
        {
            return true;
        }

        private void Execute_NavigateToStudentPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Students.xaml", UriKind.Relative));
        }

        private void Execute_NavigateToSubjectPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Classes.xaml", UriKind.Relative));
            //alternativa
            //Page predmeti = new Classes();
            //this.frame.NavigationService.Navigate(predmeti);
        }

        private void Execute_NavigateToTeacherPageCommand(object obj)
        {
            this.NavService.Navigate(
                new Uri("Views/Teachers.xaml", UriKind.Relative));
            //alternativa
            //Page nastavnici = new Teachers();
            //this.frame.NavigationService.Navigate(nastavnici);
        }

        private void Execute_SwitchLanguageCommand(object obj)
        {
            var app = (App)Application.Current;
            if (CurrentLanguage.Equals("en-US"))
            {                
                CurrentLanguage = "sr-LATN";
            }
            else
            {                
                CurrentLanguage = "en-US";
            }
            app.ChangeLanguage(CurrentLanguage);
        }
        #endregion

        #region Konstruktori
        public MainWindowViewModel(NavigationService navService)
        {
            this.NavigateToMainPageCommand = new RelayCommand(Execute_NavigateToMainPageCommand, CanExecute_NavigateCommand);
            this.NavigateToStudentPageCommand = new RelayCommand(Execute_NavigateToStudentPageCommand, CanExecute_NavigateCommand);
            this.NavigateToTeacherPageCommand = new RelayCommand(Execute_NavigateToTeacherPageCommand, CanExecute_NavigateCommand);
            this.NavigateToSubjectPageCommand = new RelayCommand(Execute_NavigateToSubjectPageCommand, CanExecute_NavigateCommand);
            this.OpenMenuCommand = new RelayCommand(
                                        execute => this.Checker = !this.Checker, CanExecute_NavigateCommand);
            this.SwitchLanguageCommand = new RelayCommand(Execute_SwitchLanguageCommand);
            this.CurrentLanguage = "en-US";
            this.Checker = false;
            this.navService = navService;
        }
        #endregion

        
    }
}
