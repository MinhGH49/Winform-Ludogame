using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class MadeMoveEventArgs : EventArgs
    {
        public int MovedIndex { get; }
        public int KickedIndex { get; }


        public MadeMoveEventArgs(int move, int kick)
        {
            this.MovedIndex = move;
            this.KickedIndex = kick;
        }


    }

    internal class WinnerFoundEventArgs : EventArgs
    {
        public int WinnerNumb { get; }
        
        public WinnerFoundEventArgs(int winnerIndex)
        {
            this.WinnerNumb = winnerIndex;
        }

    }

    internal class TurnChangedArgs: EventArgs
    {
        public int Turn { get; }
        public TurnChangedArgs(int turn)
        {
            this.Turn = Turn;
        }
    }

    internal class MoveMadeNotiArgs : EventArgs
    {
        public string Noti { get; }
        public MoveMadeNotiArgs(string noti)
        {
            this.Noti = noti;
        }
    }

    internal class DiceRolledArgs:EventArgs
    {
        public int DiceResult { get; }

        public int PlayerTurn { get; }
        
        public DiceRolledArgs(int dice, int playerIndex)

        {
            this.DiceResult = dice;
            this.PlayerTurn = playerIndex;
        }
    }
}
