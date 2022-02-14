using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    class TeachersPageViewModel
    {
        #region Polja
        private Injector inject;

        private ObservableCollection<Teacher> teachers;

        public Injector Inject
        {
            get { return inject; }
            set
            {
                inject = value;
            }
        }

        public ObservableCollection<Teacher> Teachers
        {
            get { return teachers; }
            set
            {
                teachers = value;
            }
        }
        #endregion

        #region Konstruktori
        public TeachersPageViewModel()
        {
            Inject = new Injector();
            Teachers = Inject.TeacherService.GetTeachers();
        }

        #endregion
    }
}
