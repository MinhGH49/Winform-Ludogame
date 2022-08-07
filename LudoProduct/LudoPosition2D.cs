using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class LudoPosition2D
    {
        public int x { get; set; }
        public int y { get; set; }


        public LudoPosition2D(int col = 0, int row = 0)
        {
            this.x = col;
            this.y = row;
        }

        public void SetPosition(LudoPosition2D target)
        {
            this.x = target.x;
            this.y = target.y;
        }

        public LudoPosition2D GetPosition()
        {
            LudoPosition2D result = new LudoPosition2D(x, y);
            return result;

        }

        public bool IsSameAs(LudoPiece piece)
        {
            bool a = piece.Pos.x == this.x;
            bool b = piece.Pos.y == this.y;
            return a && b;
        }

        public void PrintPosition()
        {
            Console.WriteLine(String.Format("x = {0}, y = {1}", this.x, this.y));
        }
    }
}
