using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class Display
    {
        private const int offsest = 60;

        //private PictureBox[] playerBoxes = new PictureBox[4];

        private Panel board;

        

        private Label[] playerNameLable;

        private Piece[] pieces;

        private Label NotiBar;

        public LudoDice dice;


        private Queue<int> playerQueue = new Queue<int>();
        //private LudoDice dice;
        public Display( Piece[] pieces,  Label[] nameLableList, Label notibar, Panel boardPanel)
        {
            this.board = boardPanel;
            this.dice = new LudoDice();
            this.pieces = pieces;
            this.NotiBar = notibar;
            this.playerNameLable = nameLableList;
            AddAllPieceToBoardPanel();
            InitPlayerNameText();

            playerQueue.Enqueue(0);
            playerQueue.Enqueue(1);
            playerQueue.Enqueue(2);
            playerQueue.Enqueue(3);
            //UpdatePieces();
            this.dice.Click += RollDice_OnClick;

        }

        public event EventHandler<DiceRolledArgs> DiceRolled;

        private void RollDice_OnClick(object sender, EventArgs e)
        {
            int diceResult = dice.diceNumb;
            int playerInTurn = playerQueue.Peek();
            for (int i=0;i<4;i++)
            {
                if (i!=playerInTurn)
                {
                    playerNameLable[i].Text = "  Player " + i.ToString();
                }
            }
            playerNameLable[playerInTurn].Text = "  Player " + playerInTurn.ToString() + "(IN TURN)";
            playerQueue.Enqueue(playerQueue.Dequeue());
            DiceRolled?.Invoke(this, new DiceRolledArgs(diceResult,playerInTurn));
        }

        #region Init Display

        private void AddAllPieceToBoardPanel()
        {
            for (int i=0;i<16;i++)
            {
                this.board.Controls.Add(pieces[i]);
            }
        }

        private void InitPlayerNameText()
        {
            for (int i=0;i<4;i++)
            {
                playerNameLable[i].Text = "  Player " + (i + 1).ToString();
                playerNameLable[i].TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void InitPieceDisplay(Piece[] pieceList)
        {
            for (int i=0;i<16;i++)
            {
                int playerIndex = i / 4;
                pieceList[i].Size = new System.Drawing.Size(60, 60);
                pieceList[i].Text = pieceList[i].Pindex.ToString();
                switch (playerIndex)
                {
                    case 0:
                        {
                            pieceList[i].BackgroundImage = Properties.Resources._2;
                            
                            break;
                        }
                        case 1:
                        {
                            pieceList[i].BackgroundImage = Properties.Resources._3;

                            break;
                        }
                    case 2:
                        {
                            pieceList[i].BackgroundImage = Properties.Resources._4;
                            break;
                        }
                    case 3:
                        {
                            pieceList[i].BackgroundImage = Properties.Resources._1;
                            break;
                        }
                }
       
            }



        }

        #endregion


        #region Public function to update display
        public void UpdatePieces()
        {
            for (int i = 0; i < 16; i++)
            {
                Piece piece = pieces[i];
                int xloca = piece.Pos2D.col * offsest;
                int yloca = piece.Pos2D.row * offsest;
                piece.Location = new Point(xloca, yloca);
            }
        }




        public void UpdatePieceDisplay(Piece piece)
        {
            int xloca = piece.Pos2D.col * offsest;
            int yloca = piece.Pos2D.row * offsest;
            piece.Location = new Point(xloca, yloca);
        }

        #endregion


        #region Event handler to update display when ever driver fire an event
        public void ReceiveMadeMoveEventFromDriver(object sender, MadeMoveEventArgs e)
        {
            if (e.MovedIndex != -1)
            {
                Piece movedPiece = pieces[e.MovedIndex];
                UpdatePieceDisplay(movedPiece);

            }
            if (e.KickedIndex != -1)
            {
                Piece kickedPiece = pieces[e.KickedIndex];
                UpdatePieceDisplay(kickedPiece);
            }

        }

        public void ReceiveWinnerFoundFromDriver(object sender, WinnerFoundEventArgs e)
        {
            this.NotiBar.Text = "\n*********************Winner is player #" + e.WinnerNumb.ToString()+"  ***************";
            this.playerNameLable[e.WinnerNumb].Text  +="(WINNER)";
        }

        public void ReceiveTurnChangedFromDriver(object sender, TurnChangedArgs e)
        {
            foreach (Label playerName in playerNameLable)
            {
                playerName.ResetText();
            }
            int playerIndex = e.Turn;
            playerNameLable[playerIndex].Text = "(IN TURN)";
        }

        public void ReceiveNotiFromDriver(object sender, MoveMadeNotiArgs e)
        {
            this.NotiBar.Text = e.Noti;
            this.NotiBar.Visible = true;

        }
        #endregion


    }


    
    
}
