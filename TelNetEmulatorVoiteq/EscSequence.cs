using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{


    public class EscSequence : Field
    {  



        public static EscSequence Return = new EscSequence("\r\n");
        public static EscSequence clearAll = new EscSequence("\x1b[2J");
        public static EscSequence cursorTopLeft = new EscSequence("\x1b[H");
        public static EscSequence cursorMove = new EscSequence("\x1b[{0};{1}H");

        public EscSequence(string text) : base(text)
        {
            
        }

        public EscSequence(string text, Position startingPos) : base(text, startingPos)
        {
        }
    }
}
