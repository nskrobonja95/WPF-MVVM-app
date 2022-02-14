using MenuNavigation.Commands;
using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MenuNavigation.ViewModels
{
    public class AddStudentViewModel : ViewModel
    {
        #region Polja
        private Injector inject;

        private Student stud;

        private NavigationService navService;

        public Injector Inject
        {
            get { return inject; }
            set
            {
                inject = value;
            }
        }

        public Student Stud
        {
            get { return stud; }
            set 
            { 
                stud = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Komande
        private RelayCommand addStudentCommand;

        public RelayCommand AddStudentCommand
        {
            get { return addStudentCommand; }
            set
            {
                addStudentCommand = value;
            }
        }

        #endregion

        #region Akcije
        public void Executed_AddStudentCommand(object obj)
        {
            inject.StudentService.AddStudent(Stud);
            this.navService.Navigate(
            new Uri("Views/Pocetna.xaml", UriKind.Relative));
            //NavigationCommands.BrowseBack.Execute;
        }

        public bool CanExecute_AddStudentCommand(object obj)
        {
            return true;
        }
        #endregion

        #region Konstruktori
        public AddStudentViewModel(NavigationService service)
        {
            this.navService = service;
            this.Stud = new Student();
            Inject = new Injector();
            AddStudentCommand = new RelayCommand(Executed_AddStudentCommand, 
                CanExecute_AddStudentCommand);
        }
        #endregion

    }
}
