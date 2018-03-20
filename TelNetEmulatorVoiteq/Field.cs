using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class Field
    {
        private Position startingPosition;
        private Position endingPosition;
        private string defaultText;


        public Position StartingPosition { get => startingPosition; set => startingPosition = value; }
        public Position EndingPosition { get => endingPosition; set => endingPosition = value; }
        public string DefaultText { get => defaultText; set => defaultText = value; }
    }
}
