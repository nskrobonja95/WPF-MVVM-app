using MenuNavigation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MenuNavigation.Services
{
    public class StudentService
    {
        #region Polja
        JsonSerializer jsonSerializer = new JsonSerializer();
        private string _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studenti.json");

        #endregion

        #region Servisi
        public ObservableCollection<Student> GetStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            StreamReader streamReader = new StreamReader(_datoteka);
            JsonReader jsonReader = new JsonTextReader(streamReader);

            if (File.Exists(_datoteka))
            {
                try
                {
                    //students = (JArray<Student>)jsonSerializer.Deserialize(jsonReader);
                    JArray jsonStudents = JArray.Parse(File.ReadAllText(_datoteka));
                    students = jsonStudents.ToObject<ObservableCollection<Student>>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                    Console.WriteLine(
                        "\nHelpLink ---\n{0}", ex.HelpLink);
                    Console.WriteLine("\nSource ---\n{0}", ex.Source);
                    Console.WriteLine(
                        "\nStackTrace ---\n{0}", ex.StackTrace);
                    Console.WriteLine(
                        "\nTargetSite ---\n{0}", ex.TargetSite);
                }
                finally
                {
                    jsonReader.Close();
                    streamReader.Close();
                }

            } 

            return students;
        }


        public void SaveStudents(ObservableCollection<Student> students)
        {
            StreamWriter streamWriter = new StreamWriter(_datoteka);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            try
            {
                jsonSerializer.Serialize(jsonWriter, students);

            }
            catch
            {
                // 
            }
            finally
            {
                jsonWriter.Close();
                streamWriter.Close();
            }
        }

        public void AddStudent(Student s)
        {
            //dodaj studenta
            s.Id = Guid.NewGuid();
            ObservableCollection<Student> students = GetStudents();
            students.Add(s);
            SaveStudents(students);

        }

        public void EditStudent(Student s)
        {
            ObservableCollection<Student> students = GetStudents();
            foreach(Student stud in students)
            {
                if (s.Id.Equals(stud.Id))
                {
                    stud.Name = s.Name;
                    stud.Lastname = s.Lastname;
                    stud.Index = s.Index;
                    SaveStudents(students);
                    break;
                }                
            }
        }
        #endregion

        #region Test podaci
        public void UpisiTestStudente(ObservableCollection<Student> students)
        {
            StreamWriter streamWriter = new StreamWriter(_datoteka);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            try
            {
                jsonSerializer.Serialize(jsonWriter, students);
                
            }
            catch
            {
                // 
            }
            finally
            {
                jsonWriter.Close();
                streamWriter.Close();
            }
        }

        #endregion
    }
}
