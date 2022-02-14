using MenuNavigation.Commands;
using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MenuNavigation.ViewModels
{
    public class StudentViewModel : ViewModel
    {
        #region Polja
        private Injector injector;

        private Student student;

        private string id;

        private string name;

        private string lastname;

        private string index;

        private bool isEnabledName;

        private bool isEnabledLastname;

        private bool isEnabledIndex;

        public Injector Injector
        {
            get { return injector; }
            set
            {
                injector = value;
            }
        }

        public Student _Student
        {
            get { return student; }
            set
            {
                student = value;
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

        public String Index
        {
            get { return index; }
            set
            {
                index = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabledName
        {
            get { return isEnabledName; }
            set
            {
                isEnabledName = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabledLastname
        {
            get { return isEnabledLastname; }
            set
            {
                isEnabledLastname = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabledIndex
        {
            get { return isEnabledIndex; }
            set
            {
                isEnabledIndex = value;
                OnPropertyChanged();
            }
        }

        public bool AnimTrigger
        {
            get;
            set;
        }

        #endregion


        #region Komande

        private RelayCommand editCommand;

        private RelayCommand editingNameCommand;

        private RelayCommand editingLastnameCommand;

        private RelayCommand editingIndexCommand;

        private RelayCommand cancelEditCommand;

        public RelayCommand EditCommand
        {
            get { return editCommand; }
            set
            {
                editCommand = value;
            }
        }

        public RelayCommand EditingNameCommand
        {
            get { return editingNameCommand; }
            set
            {
                editingNameCommand = value;
            }
        }

        public RelayCommand EditingLastnameCommand
        {
            get { return editingLastnameCommand; }
            set
            {
                editingLastnameCommand = value;
            }
        }

        public RelayCommand EditingIndexCommand
        {
            get { return editingIndexCommand; }
            set
            {
                editingIndexCommand = value;
            }
        }

        public RelayCommand CancelEditCommand
        {
            get { return cancelEditCommand; }
            set
            {
                cancelEditCommand = value;
            }
        }

        #endregion


        #region Uri
        private Uri imageUriBtnName;

        private Uri imageUriBtnLastname;

        private Uri imageUriBtnIndex;

        public Uri ImageBtnUri
        {
            get { return imageUriBtnName; }
            set
            {
                imageUriBtnName = value;
                OnPropertyChanged();
            }
        }

        public Uri ImageUriBtnLastname
        {
            get { return imageUriBtnLastname; }
            set
            {
                imageUriBtnLastname = value;
                OnPropertyChanged();
            }
        }

        public Uri ImageUriBtnIndex
        {
            get { return imageUriBtnIndex; }
            set
            {
                imageUriBtnIndex = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Akcije
        public void Executed_EditCommand(object obj)
        {
            SetStudent();
            Injector.StudentService.EditStudent(_Student);
            Execute_CancelEditCommand(null);
        }

        public bool CanExecute_EditCommand(object obj)
        {
            return IsEnabledName || IsEnabledLastname || IsEnabledIndex;
        }

        public void Execute_EditingNameCommand(object obj)
        {
            IsEnabledName = !IsEnabledName;
            if (IsEnabledName)
            {
                ImageBtnUri = new Uri("/Images/edit-delete.png", UriKind.Relative);
            } else
            {
                this.Name = _Student.Name;
                ImageBtnUri = new Uri("/Images/edit_icon2.png", UriKind.Relative);
            }
        }

        public void Execute_EditingLastnameCommand(object obj)
        {
            IsEnabledLastname = !IsEnabledLastname;
            if (IsEnabledLastname)
            {
                ImageUriBtnLastname = new Uri("/Images/edit-delete.png", UriKind.Relative);
            }
            else
            {
                this.Lastname = _Student.Lastname;
                ImageUriBtnLastname = new Uri("/Images/edit_icon2.png", UriKind.Relative);
            }
        }

        public void Execute_EditingIndexCommand(object obj)
        {
            IsEnabledIndex = !IsEnabledIndex;
            if (IsEnabledIndex)
            {
                ImageUriBtnIndex = new Uri("/Images/edit-delete.png", UriKind.Relative);
            }
            else
            {
                this.Index = _Student.Index;
                ImageUriBtnIndex = new Uri("/Images/edit_icon2.png", UriKind.Relative);
            }
        }

        public void Execute_CancelEditCommand(object obj)
        {
            this.Name = _Student.Name;
            this.Lastname = _Student.Lastname;
            this.Index = _Student.Index;
            if(IsEnabledName)
                Execute_EditingNameCommand(null);
            if(IsEnabledLastname)
                Execute_EditingLastnameCommand(null);
            if(IsEnabledIndex)
                Execute_EditingIndexCommand(null);
        }

        public bool CanExecute_True(object obj)
        {
            return true;
        }

        #endregion


        #region Pomocne metode
        public void SetStudent()
        {
            _Student.Id = new Guid(this.Id);
            _Student.Name = this.Name;
            _Student.Lastname = this.Lastname;
            _Student.Index = this.Index;
        }

        #endregion


        #region Konstruktori
        public StudentViewModel()
        {
            Injector = new Injector();

            _Student = new Student();
            //SetStudent();
            this.IsEnabledName = false;
            this.IsEnabledLastname = false;
            this.IsEnabledIndex = false;
            this.AnimTrigger = false;
            EditCommand = new RelayCommand(Executed_EditCommand, CanExecute_EditCommand);
            EditingNameCommand = new RelayCommand(Execute_EditingNameCommand, CanExecute_True);
            EditingLastnameCommand = new RelayCommand(Execute_EditingLastnameCommand, CanExecute_True);
            EditingIndexCommand = new RelayCommand(Execute_EditingIndexCommand, CanExecute_True);
            CancelEditCommand = new RelayCommand(Execute_CancelEditCommand, CanExecute_EditCommand);
            ImageBtnUri = new Uri("/Images/edit_icon2.png", UriKind.Relative);
            ImageUriBtnLastname = new Uri("/Images/edit_icon2.png", UriKind.Relative);
            ImageUriBtnIndex = new Uri("/Images/edit_icon2.png", UriKind.Relative);
        }

        public StudentViewModel(Guid id)
        {
            Injector = new Injector();
            ObservableCollection<Student> students = injector.StudentService.GetStudents();
            foreach(Student s in students) {
                if (s.Id.Equals(id))
                {
                    this.id = s.Id.ToString();
                    this.Name = s.Name;
                    this.Lastname = s.Lastname;
                    this.Index = s.Index;
                }
            }
            this.IsEnabledName = false;
            this.IsEnabledLastname = false;
            this.IsEnabledIndex = false;
            EditCommand = new RelayCommand(Executed_EditCommand, CanExecute_EditCommand);
        }

        #endregion

    }
}
