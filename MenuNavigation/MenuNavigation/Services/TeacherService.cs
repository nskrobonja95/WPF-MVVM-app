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
    public class TeacherService
    {
        #region Polja
        JsonSerializer jsonSerializer = new JsonSerializer();
        private string _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "teacher.json");

        #endregion

        #region Servisi
        public ObservableCollection<Teacher> GetTeachers()
        {
            ObservableCollection<Teacher> teachers = new ObservableCollection<Teacher>();
            StreamReader streamReader = new StreamReader(_datoteka);
            JsonReader jsonReader = new JsonTextReader(streamReader);

            if (File.Exists(_datoteka))
            {
                try
                {
                    JArray jsonTeachers = JArray.Parse(File.ReadAllText(_datoteka));
                    teachers = jsonTeachers.ToObject<ObservableCollection<Teacher>>();
                    //teachers = (ObservableCollection<Teacher>)jsonSerializer.Deserialize(jsonReader);
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

            return teachers;
        }
        #endregion

        #region Test podaci
        public void UpisiTestNastavnike(ObservableCollection<Teacher> teachers)
        {
            StreamWriter streamWriter = new StreamWriter(_datoteka);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);

            try
            {
                
                jsonSerializer.Serialize(jsonWriter, teachers);
            }
            catch
            {
                // 
            }
            finally
            {

                streamWriter.Close();                
            }
        }
        #endregion

    }
}
