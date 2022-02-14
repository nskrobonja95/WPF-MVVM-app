using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuNavigation.Models
{
    public class Teacher
    {
        //[JsonProperty]
        private Guid id;

        //[JsonProperty]
        private string name;

        //[JsonProperty]
        private string lastname;

        //[JsonProperty]
        private ObservableCollection<Subject> classes;

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
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
            }
        }

        [JsonProperty]
        public ObservableCollection<Subject> Classes
        {
            get { return classes; }
            set
            {
                classes = value;
            }
        }
    }
}
