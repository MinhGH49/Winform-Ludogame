using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class LudoDriver
    {
        //Piece event khi goi move piece phai kiem tra game da bat dau chua
        //Event
        //goi driver.Isturn neu tra ve true thi:
        //goi driver.TryTOmovePiece(sender)
        //goi driver.AmIWon()
        //neu tra ve false thi phai coi gameboard.noti("chua toi luot di")


        //publisher 1:
        //tao event de thong bao da thuc hien nuoc di (di duoc hay ko deu phai thong bao)
        //board se nhan event de display thong bao, update ban co,
        //
        //publiser 2:
        //tao event de thong bao tim duoc nguoi chien thang
        //board nhan event nay de display nguoi thang
        //
        //tao event handler cho nut xuc xac khi duoc nhan
        //Event handler sau khi duoc nhan se quay xuc xac, goi ham driver.SetupNewTurn(so xuc xac quay duoc)
        //de chuan bi 1 luot choi moi


        //van de: lam sao de tao event, fire event do den board.
        //event fire trong luc thuc hien 1 ham

        //Event made move

        #region Event publisher

        public event EventHandler<MadeMoveEventArgs> MadeMoveEvent;

        

        public event EventHandler<WinnerFoundEventArgs> WinnerFoundEvent;

        

        //public event EventHandler<TurnChangedArgs> TurnChangedEvent;

       

        public event EventHandler<MoveMadeNotiArgs> MoveMadeNotiEvent;

       

        public void RollDiceHandlerFromDrver(object sender, DiceRolledArgs e)
        {
            this.Move = e.DiceResult;
            this.playerTurn = e.PlayerTurn;
            UnSetFreeze();
        }


        
        #endregion



        private LudoGameEngine engine = new LudoGameEngine();

        private Piece[] pieces;

        private int[] FinishPitList = { 0, 0, 0, 0 };

        //neu de private thi co gui di  dc ko 
        private string MoveNoti = "";

        //Queue<int> GameTurns = new Queue<int>();

        private int playerTurn;
        private bool Freeze;
        public int Move { get; set; }

        //private bool GameOnGoing;

        public LudoDriver(Piece[] pieces)
        {
            this.playerTurn = 0;

            Freeze = true;
            Move = 0;
            this.pieces = pieces;

            InitPiecesPosition();
        }

        private void InitPiecesPosition()
        {
            for (int i = 0; i < 16; i++)
            {
                pieces[i].Pindex = i;
                pieces[i].PosRela = -1;
                pieces[i].Pos2D = engine.GetCage2DPos(i);
                pieces[i].Text = i.ToString();
            }
        }

        



        #region Make correct move
        public void TryToMovePiece( Piece piece)
        {
            //string moveNoti = " ";
            int movedPindex = -1;
            int kickedPindex = -1;

            int movePieceFlag = engine.TryToMovePiece(piece, Move);
            
            if (movePieceFlag >= 0)
            {
                engine.DeplacePieceOnAbsMap_RelaPos(movePieceFlag);
                pieces[movePieceFlag].Pos2D = engine.GetCage2DPos(movePieceFlag);
                pieces[movePieceFlag].PosRela = -1;
                movedPindex = piece.Pindex;
                kickedPindex = movePieceFlag;
                string MoveNoti = string.Format("Valid move, collision solved, kicked piece# {0}, moved piece# {1} ", kickedPindex.ToString(), movedPindex.ToString());
                MoveMadeNotiEvent?.Invoke(this, new MoveMadeNotiArgs(MoveNoti));
                Freeze = true;

            }
            else if (movePieceFlag==-2)
            {
                movedPindex = piece.Pindex;
                string MoveNoti = string.Format("Valid move, no collision, moved piece# {0}", movedPindex.ToString());
                MoveMadeNotiEvent?.Invoke(this, new MoveMadeNotiArgs(MoveNoti));
                Freeze = true;

            }
            else
            {
                string MoveNoti = string.Format("Invalid move, collision was not solved");
                MoveMadeNotiEvent?.Invoke(this, new MoveMadeNotiArgs(MoveNoti));

            }

            if (CheckThisTurnPlayerWin(piece.Pindex))
            {
                WinnerFoundEvent?.Invoke(this, new WinnerFoundEventArgs(piece.Pindex / 4));

            }
            MadeMoveEvent?.Invoke(this, new MadeMoveEventArgs(movedPindex, kickedPindex));
            
        }

        private bool CheckThisTurnPlayerWin(int pindex)
        {
            int player = pindex / 4;
            int finishPitCount = 0;
            for (int i=0;i<4;i++)
            {
                if (pieces[player*4+i].PosRela==56) finishPitCount++;

            }
            if (finishPitCount == 4)
            {
                Freeze = true;
                return true;
            }
            else return false;
        }

        #endregion



        #region Ham private 

        

        private void SetFreeze()
        {
            this.Freeze = true;
        }

        private void UnSetFreeze()
        {
            this.Freeze = false;
        }


        /// <summary>
        /// Tạo bug ở đây để di chuyển 1 quân nhiều lần
        /// </summary>
        /// <param name="pieceIndex"></param>
        /// <returns></returns>
        public bool IsTurn(int pieceIndex)
        {
            if (Freeze) return false;
            if (this.playerTurn == pieceIndex / 4) return true;
            return false;
        }

        #endregion


        
    }
}
