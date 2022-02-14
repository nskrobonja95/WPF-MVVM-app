using MenuNavigation.Models;
using MenuNavigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.VMConverters
{
    public class SubjectConverter
    {

        #region Polja
        private Injector injector;

        private TeacherConverter tc;

        private StudentConverter sc;

        public Injector Injector
        {
            get { return injector; }
            set
            {
                injector = value;
            }
        }

        public TeacherConverter Tc
        {
            get { return tc; }
            set
            {
                tc = value;
            }
        }

        public StudentConverter Sc
        {
            get { return sc; }
            set
            {
                sc = value;
            }
        }
        #endregion

        #region Konstruktori
        public SubjectConverter()
        {
        }

        #endregion

        #region Metode
        public SubjectViewModel ConvertModelToViewModel(Subject s)
        {
            SubjectViewModel stViewModel = new SubjectViewModel();

            stViewModel.Id = s.Id.ToString();
            stViewModel.Name = s.Name;
            stViewModel.Students = sc.ConvertCollectionToViewModel(s.Students);

            return stViewModel;
        }
        

        public ObservableCollection<SubjectViewModel> ConvertCollectionToViewModel(ObservableCollection<Subject> subjects)
        {
            ObservableCollection<SubjectViewModel> vmSubjects = new ObservableCollection<SubjectViewModel>();
            SubjectViewModel subViewModel;
            foreach (Subject s in subjects)
            {
                subViewModel = ConvertModelToViewModel(s);
                vmSubjects.Add(subViewModel);
            }
            return vmSubjects;
        }
        #endregion
    }
}
