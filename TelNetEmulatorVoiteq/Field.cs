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



        public Field(string text)
        {
            DefaultText = text;
            endingPosition = StartingPosition = new Position() { Col=0, Row=0};
            endingPosition.Col += text.Length;
        }

        public Field(string text, Position startingPos)
        {
            DefaultText = text;
            endingPosition = StartingPosition = startingPos;
            endingPosition.Col += text.Length;
        }

        public string toTelnet()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(String.Format(EscSequence.cursorMove.defaultText, StartingPosition.Row,StartingPosition.Col));
            builder.Append(defaultText);

            return builder.ToString();
        }

    }
}
