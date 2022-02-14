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
    public class StudentConverter
    {
        public StudentViewModel ConvertModelToViewModel(Student s)
        {
            StudentViewModel stViewModel = new StudentViewModel();

            stViewModel.Id = s.Id.ToString();
            stViewModel.Name = s.Name;
            stViewModel.Lastname = s.Lastname;
            stViewModel.Index = s.Index;
            stViewModel._Student = s;

            return stViewModel;
        }

        public ObservableCollection<StudentViewModel> ConvertCollectionToViewModel(ObservableCollection<Student> students)
        {
            ObservableCollection<StudentViewModel> vmStudents = new ObservableCollection<StudentViewModel>();
            StudentViewModel stViewModel;
            foreach (Student s in students)
            {
                stViewModel = ConvertModelToViewModel(s);
                vmStudents.Add(stViewModel);
            }
            return vmStudents;
        }
    }
}
