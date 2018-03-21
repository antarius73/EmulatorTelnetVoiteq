﻿using System;
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
            p1.ScreenLst.Add(MockGen.GetLoginScreen());

            // faire la gestion des transition ici dans l'objet projet, caster les screen dans des var puis faire les liaison avec les condition ici

            p1.ScreenLst.Add(MockGen.GetWellcomScreen());
            p1.ActiveScreen = p1.ScreenLst[0];
            projects.Add(p1);

            projects.Add(new Project() { Name = "projet deux" });
            projects.Add(new Project() { Name = "projet trois" });

            

            return projects;
        }


        public static Screen GetLoginScreen()
        {
            Screen loggin = new Screen() { Name="login"};

            loggin.WithClearAll = true;

            Position pos = new Position();
            
            Field textField = new Field("Login    : ", new Position(1,1));
            loggin.FieldList.Add(textField);

            pos = textField.EndingPosition;
            loggin.StartingPosition = pos;

            textField = new Field("________", pos);
            loggin.FieldList.Add(textField);
            
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
