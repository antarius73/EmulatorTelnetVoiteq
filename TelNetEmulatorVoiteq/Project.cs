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
        private Dictionary<string, ProjectVariable> variableDic = new Dictionary<string, ProjectVariable>();
        

        public string Name { get => name; set => name = value; }
        public List<Screen> ScreenLst { get => screenLst; }
        public Screen ActiveScreen { get => activeScreen; set => activeScreen = value; }
        public Dictionary<string, ProjectVariable> VariableDic { get => variableDic; }

       
        public string incomingMessage(string value) {

            activeScreen.incomingInput(value);
            return activeScreen.toTelnet();
        }


        public static List<Project> getAllProjects()
        {
            return MockGen.getProjects();
        }
    }
}
