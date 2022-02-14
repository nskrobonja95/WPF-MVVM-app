using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    class ClassesPageViewModel
    {
        #region Polja
        private Injector inject;

        private ObservableCollection<Subject> subjects;

        public Injector Inject
        {
            get { return inject; }
            set
            {
                inject = value;
            }
        }

        public ObservableCollection<Subject> Subjects
        {
            get { return subjects; }
            set
            {
                subjects = value;
            }
        }

        #endregion

        #region Konstruktori
        public ClassesPageViewModel()
        {
            Inject = new Injector();
            Subjects = Inject.SubjectService.GetSubjects();
        }

        #endregion
    }
}
