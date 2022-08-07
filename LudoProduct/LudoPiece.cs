using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class LudoPiece : Button
    {
        public int PieceIndex { get; set; }
        public LudoPosition2D Pos { get; }
        public LudoPiece(LudoPosition2D position, int pieceindex)
        {
            Pos = position;
            PieceIndex = pieceindex;
            //inPitFlag = false;
            this.BackColor = Color.Transparent;
            this.Size = new Size(60, 60);

        }

        public LudoPosition2D GetPosButNotPointTo()
        {
            int x = Pos.x;
            int y = Pos.y;
            return new LudoPosition2D(x, y);
        }

        public LudoPiece GetCopy()
        {
            int x = Pos.x;
            int y = Pos.y;
            LudoPiece copy = new LudoPiece(new LudoPosition2D(x, y), PieceIndex);
            return copy;
        }

        



    }





}
