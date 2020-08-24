using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikebot
{
    [Serializable]
    public class Task
    {
        public Profile Profile { get; set; }
        public string Size { get; set; }
        public string Url { get; set; }
        public bool Proxy { get; set; }
    }
}
