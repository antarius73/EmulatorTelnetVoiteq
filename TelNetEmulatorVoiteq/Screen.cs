using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class Screen
    {
        private string name;
        private List<Field> fieldList = new List<Field>();

        public string Name { get => name; set => name = value; }
        public List<Field> FieldList { get => fieldList;}

        public Screen()
        {

        }
    }
}
