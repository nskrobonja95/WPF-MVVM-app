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
    public class ClassesService
    {
        JsonSerializer jsonSerializer = new JsonSerializer();
        private string _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "classes.json");

        public ObservableCollection<Subject> GetSubjects()
        {
            ObservableCollection<Subject> subjects = new ObservableCollection<Subject>();
            StreamReader streamReader = new StreamReader(_datoteka);
            JsonReader jsonReader = new JsonTextReader(streamReader);

            if (File.Exists(_datoteka))
            {
                try
                {
                    JArray jsonTeachers = JArray.Parse(File.ReadAllText(_datoteka));
                    subjects = jsonTeachers.ToObject<ObservableCollection<Subject>>();
                    //subjects = (ObservableCollection<Subject>)jsonSerializer.Deserialize(jsonReader);
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
                    streamReader.Close();
                    jsonReader.Close();
                }

            }

            return subjects;
        }

        public Teacher GetSubjectTeacher(string id, ObservableCollection<Teacher> teachers)
        {
            if (teachers == null || id == null) return null;
            Guid gid = new Guid(id);
            foreach(Teacher t in teachers)
            {
                foreach(Subject s in t.Classes)
                {
                    if (s.Id.Equals(gid))
                    {                        
                        return t;
                    }
                }
            }
            return null;
        }

        public void UpisiTestPredmete(ObservableCollection<Subject> subjects)
        {
            StreamWriter streamWriter = new StreamWriter(_datoteka);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            try
            {
                jsonSerializer.Serialize(jsonWriter, subjects);
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
    }
}
