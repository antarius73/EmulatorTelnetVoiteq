using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{


    public class SpecialCharSequence : Field
    {  



        public static SpecialCharSequence Return = new SpecialCharSequence("\r\n");


        public SpecialCharSequence(string text) : base(text)
        {
        }

        public SpecialCharSequence(string text, Position startingPos) : base(text, startingPos)
        {
        }
    }
}
