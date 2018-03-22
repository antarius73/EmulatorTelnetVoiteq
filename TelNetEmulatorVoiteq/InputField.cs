using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class InputField : InfoField
    {
        private string textMask;
        public string TextMask { get => textMask; set => textMask = value; }

        public InputField(string text, string mask) : base(mask)
        {
            TextMask = mask;
        }

        public InputField(string text, string mask, Position startingPos) : base(mask, startingPos)
        {
            TextMask = mask;
        }

        

        public void changeValue(string value)
        {
            if (String.IsNullOrEmpty(variable.CurrentValue))
            {
                Text = textMask;
            }
            else
            {
                Text = variable.CurrentValue;
            }
            
        }


    }
}
