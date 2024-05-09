using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_15._16
{
    public class Patent
    {
        public string Title { get; set;} //Title of the published application
        public string YearOfPublication { get; set;} //The date the application was officially published
        public string ApplicationNumber { get; set;} //A unique number assigned to published applications
        public long[] InventorIds { get; set;}

        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }
}
