using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;
using MenuNavigation.ViewModels;
using MenuNavigation.VMConverters;

namespace MenuNavigation.Views
{
    /// <summary>
    /// Interaction logic for Pocetna.xaml
    /// </summary>
    public partial class Pocetna : Page
    {
        private PocetnaViewModel viewModel;
        public Pocetna()
        {
            viewModel = new PocetnaViewModel();
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void ViewStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentViewModel vmStudent = (StudentViewModel) StudentsListView.SelectedItem;
            ViewStudent viewStudent = new ViewStudent(vmStudent);
            //this.NavigationService.Navigate(
            //    new Uri("Views/ViewStudent.xaml?id=" + vmStudent.Id, UriKind.Relative),
            //    viewModel.StudViewModel);
            this.NavigationService.Navigate(viewStudent);
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            AddStudentViewModel vm = new AddStudentViewModel(this.NavigationService);
            AddStudent addStudentPage = new AddStudent(vm);
            this.NavigationService.Navigate(addStudentPage);
        }

        private void ViewSubjectBtn_Click(object sender, RoutedEventArgs e)
        {
            SubjectViewModel vm = (SubjectViewModel)SubjectsListView.SelectedItem;            
            SubjectView subjectViewPage = new SubjectView(vm);
            this.NavigationService.Navigate(subjectViewPage);
        }

        private void ViewTeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherViewModel vm = (TeacherViewModel)TeachersListView.SelectedItem;
            TeacherView teacherViewPage = new TeacherView(vm);
            this.NavigationService.Navigate(teacherViewPage);
        }
    }
}
