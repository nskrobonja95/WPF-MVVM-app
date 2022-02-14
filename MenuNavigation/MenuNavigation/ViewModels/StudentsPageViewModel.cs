using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    class StudentsPageViewModel : ViewModel
    {
        #region Polja
        private Injector inject;

        private ObservableCollection<Student> students;

        public Injector Inject
        {
            get { return inject; }
            set
            {
                inject = value;
            }
        }

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;                
            }
        }

        #endregion

        #region Konstruktori
        public StudentsPageViewModel()
        {
            Inject = new Injector();
            Students = Inject.StudentService.GetStudents();
        }

        #endregion

    }
}
