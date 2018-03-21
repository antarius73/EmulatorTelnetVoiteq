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
        private List<Screen> screenLst = new List<Screen>();
        private Screen activeScreen;

        public string Name { get => name; set => name = value; }
        public List<Screen> ScreenLst { get => screenLst; }
        public Screen ActiveScreen { get => activeScreen; set => activeScreen = value; }

        public static List<Project> getAllProjects()
        {
            return MockGen.getProjects();
        }
    }
}
