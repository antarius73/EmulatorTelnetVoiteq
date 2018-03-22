using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class InfoField : Field
    {
        protected ProjectVariable variable;

        public ProjectVariable Variable { get => variable; set => variable = value; }


        public InfoField(string text) : base(text)
        {
        }

        public InfoField(string text, Position startingPos) : base(text, startingPos)
        {
        }

        public override string toTelnet()
        {
            if (variable != null && variable.CurrentValue != variable.DefaultValue)
            {
                Text = variable.CurrentValue;
            }

            return base.toTelnet();
        }
    }
}
