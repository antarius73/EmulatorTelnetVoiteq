using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public static class MockGen
    {

        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>();

            projects.Add(new Project() { Name = "projet un" });
            projects.Add(new Project() { Name = "projet deux" });
            projects.Add(new Project() { Name = "projet trois" });
            return projects;
        }
    }
}
