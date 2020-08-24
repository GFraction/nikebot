using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace nikebot
{
    public static class DataContext
    {
        public static List<Profile> profiles;
        public static XmlSerializer profileFormatter = new XmlSerializer(typeof(List<Profile>));
        public static XmlSerializer taskFormatter = new XmlSerializer(typeof(List<Task>));
        public static List<Task> tasks;
    }
}
