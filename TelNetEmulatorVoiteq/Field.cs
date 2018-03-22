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
        private string text;


        public Position StartingPosition { get => startingPosition; set => startingPosition = value; }
        public Position EndingPosition { get => endingPosition; set => endingPosition = value; }
        public string Text { get => text; set => text = value; }



        public Field(string text)
        {
            Text = text;
            endingPosition = StartingPosition = new Position() { Col=0, Row=0};
            endingPosition.Col += text.Length;
        }

        public Field(string text, Position startingPos)
        {
            Text = text;
            endingPosition = StartingPosition = startingPos;
            endingPosition.Col += text.Length;
        }

        public string toTelnet()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(String.Format(EscSequence.cursorMove.text, StartingPosition.Row,StartingPosition.Col));
            builder.Append(text);

            return builder.ToString();
        }

    }
}
