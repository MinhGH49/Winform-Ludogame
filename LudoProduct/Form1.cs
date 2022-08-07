namespace LudoProduct
{
    public partial class Ludo : Form
    {
        //private LudoGameEngine engine = new LudoGameEngine();

        private Piece[] pieces;

        private Display display;

        private LudoDriver driver;

        //private LudoDice dice = new LudoDice();

        private Label[] playerNameLabelList = new Label[4];
        //khoi tao object display,
        //add vao form display.gameboard, display.dice, display.notibox

        public Ludo()
        {
            InitializeComponent();
            InitPlayerNameLableList();
            this.pieces = new Piece[16];
            for (int i=0;i<16;i++)
            {
                pieces[i] = new Piece(new Position2D(0,0),i);
            }
            this.driver = new LudoDriver(pieces);

            this.display = new Display(pieces,playerNameLabelList,this.NotiLabel,gameboardpanel);
            this.display.InitPieceDisplay(pieces);
            this.display.UpdatePieces();
            this.dicePanel.Controls.Add(display.dice);
            //this.dicePanel.Controls.Add(dice);

            //TableLayoutPanel.controls.add();

            
            //gameBoard.UpdatePieces();
            InitPieceClickHandler();


            driver.MadeMoveEvent += display.ReceiveMadeMoveEventFromDriver;
            driver.WinnerFoundEvent += display.ReceiveWinnerFoundFromDriver;
            //driver.TurnChangedEvent += display.ReceiveTurnChangedFromDriver;
            driver.MoveMadeNotiEvent += display.ReceiveNotiFromDriver;
            //dice.DiceRolledEvent += driver.SetUpNewTurn;
            display.DiceRolled += driver.RollDiceHandlerFromDrver;
            //display.DiceRolled += driver.SetUpNewTurn;
        }


        private void InitPlayerNameLableList()
        {
            playerNameLabelList[0] = this.player0name;
            playerNameLabelList[1] = this.player1name;
            playerNameLabelList[2] = this.player3name;
            playerNameLabelList[3] = this.player2name;



        }

        private void InitPieceClickHandler()
        {
            foreach(Piece piece in pieces)
            {
                piece.Click += Piece_Click;

            }
        }


        private void Piece_Click(object sender, EventArgs e)
        {
            Piece piece = (Piece)sender;
            if (driver.IsTurn(piece.Pindex) == false) return;
            driver.TryToMovePiece(piece);
        

        }



        #region Debug
        private void TestPiece_click(object sender, EventArgs e)
        {
            LudoPiece piece = (LudoPiece)sender;
            Player0.Text = piece.PieceIndex.ToString();
        }
        #endregion


    }
}