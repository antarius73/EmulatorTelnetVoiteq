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


        public static Screen GetLogginScreen()
        {
            Screen loggin = new Screen() { Name="login"};

            Position pos = new Position();

            Field textField = new Field("Login : ", pos);

            loggin.FieldList.Add(textField);

            pos = textField.EndingPosition;

            textField = new Field("________", pos);
            loggin.FieldList.Add(textField);
            pos = textField.EndingPosition;

            SpecialCharSequence speReturn = SpecialCharSequence.Return;



            textField = new Field("\nPassword : ", pos);

            loggin.FieldList.Add(textField);

            return loggin;
        }
    }
}
