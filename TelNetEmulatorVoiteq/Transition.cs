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
        private string inputValue;
        private string condition;

        public string InputValue { get => inputValue; set => inputValue = value; }
        public string Condition { get => condition; set => condition = value; }

        public bool evaluateCondition()
        {
            var engine = VsaEngine.CreateEngine();
           object res =  Eval.JScriptEvaluate("toto == toto", engine);

            return true;
        }
    }
}
