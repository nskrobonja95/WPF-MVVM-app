using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    public class SubjectViewModel : ViewModel
    {
        #region Polja
        private Injector inject;

        private string id;

        private string name;

        private TeacherViewModel educator;

        private ObservableCollection<StudentViewModel> students;

        public Injector Inject
        {
            get { return inject; }
            set
            {
                inject = value;
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public TeacherViewModel Educator
        {
            get { return educator; }
            set
            {
                educator = value;
                OnPropertyChanged();
            }
        }

        public string TeacherFullName
        {
            get => string.Format("{0} {1}", Educator.Name, Educator.Lastname);
        }

        public ObservableCollection<StudentViewModel> Students
        {
            get { return students; }
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Konstruktori
        public SubjectViewModel()
        {
            this.inject = new Injector();       
        }

        #endregion
    }
}
