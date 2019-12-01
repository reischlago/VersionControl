using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_control_feladat.entities
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", LasName, FirstName);
            }
        }

    }
}
