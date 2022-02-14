using MenuNavigation.Models;
using MenuNavigation.Services;
using MenuNavigation.VMConverters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.ViewModels
{
    public class PocetnaViewModel : ViewModel
    {
        #region Polja
        private Injector injector;

        private ObservableCollection<StudentViewModel> students;

        private ObservableCollection<SubjectViewModel> subjects;

        private ObservableCollection<TeacherViewModel> teachers;

        private StudentViewModel studViewModel;

        public Injector Injector
        {
            get { return injector; }
            set
            {
                injector = value;
            }
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

        public ObservableCollection<SubjectViewModel> Subjects
        {
            get { return subjects; }
            set
            {
                subjects = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TeacherViewModel> Teachers
        {
            get { return teachers; }
            set
            {
                teachers = value;
                OnPropertyChanged();
            }
        }

        public StudentViewModel StudViewModel
        {
            get { return studViewModel; }
            set
            {
                studViewModel = value;
            }
        }

        #endregion


        #region Konstruktori
        public PocetnaViewModel()
        {
            Injector injector = new Injector();
            Injector = injector;
            injector.SubjectConverter.Tc = injector.TeacherConverter;
            injector.SubjectConverter.Sc = injector.StudentConverter;
            injector.TeacherConverter.Sc = injector.SubjectConverter;
            ObservableCollection<Student> studenti = injector.StudentService.GetStudents();
            Students = injector.StudentConverter.ConvertCollectionToViewModel(studenti);
            Teachers = injector.TeacherConverter.ConvertCollectionToViewModel(injector.TeacherService.GetTeachers());
            Subjects = injector.SubjectConverter.ConvertCollectionToViewModel(injector.SubjectService.GetSubjects());
            foreach (SubjectViewModel s in Subjects)
            {
                s.Educator = injector.TeacherConverter.ConvertModelToViewModel(injector.SubjectService.GetSubjectTeacher(s.Id.ToString(), injector.TeacherService.GetTeachers()));
            }
        }
        #endregion

    }
}
