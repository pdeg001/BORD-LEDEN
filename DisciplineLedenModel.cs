using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scorebord_leden
{
    class DisciplineLedenModel
    {
        public int id { get; set; }
        public int disciplineId { get; set; }
        public string bondsNummer { get; set; }
        public string name { get; set; }
    }
}
