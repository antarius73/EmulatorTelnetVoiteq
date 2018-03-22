using Microsoft.JScript;
using Microsoft.JScript.Vsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    

    public class Transition
    {
        private string condition;
        private string conditionTranslated;
        private Screen destinationScreen;
        private Project parentProject;

        public string Condition { get => condition; set => condition = value; }
        public Screen DestinationScreen { get => destinationScreen; set => destinationScreen = value; }
       
        public Transition(Project project)
        {
            parentProject = project;
        }

        public bool evalCondition()
        {           
            replaceConditionMarkup();
            var engine = VsaEngine.CreateEngine();
            object res = Eval.JScriptEvaluate(conditionTranslated, engine);
            return (bool)res;
        }

        private void replaceConditionMarkup()
        {
            conditionTranslated = Condition;
            foreach (var variableKeyValue in parentProject.VariableDic)
            {
                conditionTranslated = conditionTranslated.Replace("[" + variableKeyValue.Key + "]", variableKeyValue.Value.CurrentValue);
            }
        }
    }
}
