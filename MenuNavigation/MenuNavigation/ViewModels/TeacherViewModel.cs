using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    public class TeacherViewModel : ViewModel
    {

        #region Polja
        private Injector inject;

        private string id;

        private string name;

        private string lastname;

        private ObservableCollection<SubjectViewModel> classes;

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

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged();
            }
        }

        public string Fullname
        {
            get => string.Format("{0} {1}", Name, Lastname);
        }

        public ObservableCollection<SubjectViewModel> Classes
        {
            get { return classes; }
            set
            {
                classes = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Konstruktor
        public TeacherViewModel()
        {
            inject = new Injector();
        }
        #endregion
    }
}
