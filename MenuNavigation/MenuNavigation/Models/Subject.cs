using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.Models
{
    public class Subject
    {
        //[JsonProperty]
        private Guid id;

        //[JsonProperty]
        private string name;

        //[JsonProperty]
        private ObservableCollection<Student> students;

        [JsonProperty]
        public Guid Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        [JsonProperty]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        [JsonProperty]
        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
            }
        }
    }
}
