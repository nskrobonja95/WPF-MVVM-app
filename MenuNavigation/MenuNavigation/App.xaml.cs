using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MenuNavigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            TestData();
        }

        public void ChangeLanguage(string currLang)
        {
            if (currLang.Equals("en-US"))
            {
                TranslationSource.Instance.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            }
            else
            {
                TranslationSource.Instance.CurrentCulture = new System.Globalization.CultureInfo("sr-LATN");                
            }
        }

        public void TestData()
        {
            Injector injector = new Injector();
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            Student s = new Student();
            s.Id = Guid.NewGuid();
            s.Index = "RA 212/2018";
            s.Name = "Marko";
            s.Lastname = "Markovic";
            students.Add(s);

            Student s1 = new Student();
            s1.Id = Guid.NewGuid();
            s1.Index = "RA 21/2018";
            s1.Name = "Jovan";
            s1.Lastname = "Jovanovic";
            students.Add(s1);
            Student s2 = new Student();
            s2.Id = Guid.NewGuid();
            s2.Index = "RA 12/2018";
            s2.Name = "Mirko";
            s2.Lastname = "Mirkovic";
            students.Add(s2);
            Student s3 = new Student();
            s3.Id = Guid.NewGuid();
            s3.Index = "RA 12/2018";
            s3.Name = "Djura";
            s3.Lastname = "Djuric";
            students.Add(s3);
            Student s4 = new Student();
            s4.Id = Guid.NewGuid();
            s4.Index = "RA 12/2018";
            s4.Name = "Petar";
            s4.Lastname = "Petrovic";
            students.Add(s4);
            Student s5 = new Student();
            s5.Id = Guid.NewGuid();
            s5.Index = "RA 12/2018";
            s5.Name = "Mika";
            s5.Lastname = "Mikic";
            students.Add(s5);
            Student s6 = new Student();
            s6.Id = Guid.NewGuid();
            s6.Index = "RA 12/2018";
            s6.Name = "Lazar";
            s6.Lastname = "Lazaric";
            students.Add(s6);
            Student s7 = new Student();
            s7.Id = Guid.NewGuid();
            s7.Index = "RA 12/2018";
            s7.Name = "Vukasin";
            s7.Lastname = "Vukasinovic";
            students.Add(s7);

            injector.StudentService.SaveStudents(students);

            ObservableCollection<Subject> subjects = new ObservableCollection<Subject>(); ;
            Subject subj1 = new Subject();
            subj1.Id = Guid.NewGuid();
            subj1.Name = "HCI";
            ObservableCollection<Student> hciStudents = new ObservableCollection<Student>();
            hciStudents.Add(s1);
            hciStudents.Add(s2);
            hciStudents.Add(s3);
            subj1.Students = hciStudents;
            subjects.Add(subj1);

            Subject subj2 = new Subject();
            subj2.Id = Guid.NewGuid();
            subj2.Name = "SIMS";
            ObservableCollection<Student> simsStudents = new ObservableCollection<Student>();
            simsStudents.Add(s4);
            simsStudents.Add(s5);
            simsStudents.Add(s6);
            subj2.Students = simsStudents;
            subjects.Add(subj2);

            Subject subj3 = new Subject();
            subj3.Id = Guid.NewGuid();
            subj3.Name = "Web";
            ObservableCollection<Student> webStudents = new ObservableCollection<Student>();
            webStudents.Add(s1);
            webStudents.Add(s4);
            subj3.Students = webStudents;
            subjects.Add(subj3);

            Subject subj4 = new Subject();
            subj4.Id = Guid.NewGuid();
            subj4.Name = "Fizika";
            subj4.Students = students;
            subjects.Add(subj4);

            ObservableCollection<Teacher> teachers = new ObservableCollection<Teacher>();
            Teacher t = new Teacher();
            t.Id = Guid.NewGuid();
            t.Name = "Goran";
            t.Lastname = "Goranovic";
            ObservableCollection<Subject> tClasses = new ObservableCollection<Subject>();
            tClasses.Add(subj1);
            tClasses.Add(subj2);
            t.Classes = tClasses;
            teachers.Add(t);

            Teacher t1 = new Teacher();
            t1.Id = Guid.NewGuid();
            t1.Name = "Pera";
            t1.Lastname = "Peric";
            ObservableCollection<Subject> t1Classes = new ObservableCollection<Subject>();
            t1Classes.Add(subj3);
            t1Classes.Add(subj4);
            t1.Classes = t1Classes;
            teachers.Add(t1);

            injector.SubjectService.UpisiTestPredmete(subjects);
            injector.TeacherService.UpisiTestNastavnike(teachers);
        }
    }

    
}
