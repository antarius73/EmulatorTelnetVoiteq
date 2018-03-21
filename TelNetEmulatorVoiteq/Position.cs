using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelNetEmulatorVoiteq
{
    public struct Position
    {
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row;
        public int Col;
    }
}
