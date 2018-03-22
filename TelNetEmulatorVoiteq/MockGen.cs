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

            Project p1 = new Project() { Name = "projet un" };

            p1.VariableDic.Add("user", new ProjectVariable(String.Empty));
            p1.VariableDic.Add("psw", new ProjectVariable(String.Empty));

            Screen login = MockGen.GetLoginScreen(p1); 
            Screen Wellcom = MockGen.GetWellcomScreen(); 


         

            
            login.ActiveVariable = p1.VariableDic["user"];

            Transition logToWellcom = new Transition(p1);
            logToWellcom.DestinationScreen = Wellcom;
            logToWellcom.Condition = "\"[user]\"==\"greg\"";

            login.TransitionList.Add(logToWellcom);

            

            p1.ScreenLst.Add(login);

            

            p1.ScreenLst.Add(Wellcom);
            p1.ActiveScreen = p1.ScreenLst[0];


           


            projects.Add(p1);

            projects.Add(new Project() { Name = "projet deux" });
            projects.Add(new Project() { Name = "projet trois" });

            

            return projects;
        }


        public static Screen GetLoginScreen(Project p)
        {
            Screen loggin = new Screen() { Name="login"};

            loggin.WithClearAll = true;

            Position pos = new Position();
            
            Field textField = new Field("Login    : ", new Position(1,1));
            loggin.FieldList.Add(textField);

            pos = textField.EndingPosition;
            loggin.StartingPosition = pos;

            InputField inputField = new InputField(String.Empty,"________", pos);
            inputField.Variable = p.VariableDic["user"];
            loggin.FieldList.Add(inputField);
            
            textField = new Field("Password : ", new Position(2, 1));
            loggin.FieldList.Add(textField);

            pos = textField.EndingPosition;

            textField = new Field("________", pos);
            loggin.FieldList.Add(textField);


            

            return loggin;
        }

        public static Screen GetWellcomScreen()
        {
            Screen wellcome = new Screen() { Name = "wellcome" };

            wellcome.WithClearAll = true;

            Position pos = new Position();

            Field textField = new Field("Wellcome !", new Position(1, 1));
            wellcome.FieldList.Add(textField);

            return wellcome;
        }
    }
}
