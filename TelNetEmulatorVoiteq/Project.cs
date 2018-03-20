using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class Project
    {
        private string name;

        public string Name { get => name; set => name = value; }


        public static List<Project> getAllProjects()
        {
            return MockGen.getProjects();
        }
    }
}
