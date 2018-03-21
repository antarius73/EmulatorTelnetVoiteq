using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public class Screen
    {
        private string name;
        private List<Field> fieldList = new List<Field>();
        private bool withClearAll = false;
        private Position startingPosition;
        private List<Transition> transitionList = new List<Transition>(); 
        //private FieldInput activeField;

        public string Name { get => name; set => name = value; }
        public List<Field> FieldList { get => fieldList;}
        public bool WithClearAll { get => withClearAll; set => withClearAll = value; }
        public Position StartingPosition { get => startingPosition; set => startingPosition = value; }
        public List<Transition> TransitionList { get => transitionList; }

        public Screen()
        {

        }

        public string toTelnet()
        {
            StringBuilder builder = new StringBuilder();
            // clear the screen and put cursor top left
            if (WithClearAll)
            {
                builder.Append(EscSequence.clearAll.toTelnet());
                builder.Append(EscSequence.cursorTopLeft.toTelnet());
            }
            // add all field dialogue
            foreach (var field in FieldList)
            {
                builder.Append(field.toTelnet());
            }

            // place cursor
            builder.Append(String.Format(EscSequence.cursorMove.DefaultText, StartingPosition.Row, StartingPosition.Col));

            return builder.ToString();
        }
    }
}
