using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class ProjectVariable
    {
        private string defaultValue;
        private string currentValue;
        

        public string DefaultValue { get => defaultValue; set => defaultValue = value; }
        public string CurrentValue { get => currentValue; set => currentValue = value; }

        public ProjectVariable(string defaultValue)
        {
            CurrentValue = this.defaultValue = defaultValue;
        }
    }
}
