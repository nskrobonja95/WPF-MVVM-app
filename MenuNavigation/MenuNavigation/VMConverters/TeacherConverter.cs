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
    public class TeacherConverter
    {
        #region Polja
        private SubjectConverter sc;

        public SubjectConverter Sc
        {
            get { return sc; }
            set
            {
                sc = value;
            }
        }
        #endregion

        #region Konstruktori
        public TeacherConverter()
        {
            
        }
        #endregion

        #region Metode
        public TeacherViewModel ConvertModelToViewModel(Teacher t)
        {
            TeacherViewModel tViewModel = new TeacherViewModel();

            tViewModel.Id = t.Id.ToString();
            tViewModel.Name = t.Name;
            tViewModel.Lastname = t.Lastname;
            tViewModel.Classes = sc.ConvertCollectionToViewModel(t.Classes);

            return tViewModel;
        }

        public ObservableCollection<TeacherViewModel> ConvertCollectionToViewModel(ObservableCollection<Teacher> teachers)
        {
            ObservableCollection<TeacherViewModel> vmTeachers = new ObservableCollection<TeacherViewModel>();
            TeacherViewModel tViewModel;
            foreach (Teacher t in teachers)
            {
                tViewModel = ConvertModelToViewModel(t);
                vmTeachers.Add(tViewModel);
            }
            return vmTeachers;
        }
        #endregion
    }
}
