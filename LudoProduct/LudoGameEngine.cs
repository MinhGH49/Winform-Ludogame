using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class LudoGameEngine
    {
        /// <summary>
        /// Xử lí va chạm của piece khi thực hiện bước đi
        /// 
        /// </summary>

        private sbyte[,] AbsPosTo2DPos = new sbyte[76, 3]
       {//  x       y     Abs.Pos
        {   0   ,   6   ,   0   },
        {   1   ,   6   ,   1   },
        {   2   ,   6   ,   2   },
        {   3   ,   6   ,   3   },
        {   4   ,   6   ,   4   },
        {   5   ,   6   ,   5   },
        {   6   ,   5   ,   6   },
        {   6   ,   4   ,   7   },
        {   6   ,   3   ,   8   },
        {   6   ,   2   ,   9   },
        {   6   ,   1   ,   10  },
        {   6   ,   0   ,   11  },
        {   7   ,   0   ,   12  },
        {   8   ,   0   ,   13  },
        {   8   ,   1   ,   14  },
        {   8   ,   2   ,   15  },
        {   8   ,   3   ,   16  },
        {   8   ,   4   ,   17  },
        {   8   ,   5   ,   18  },
        {   9   ,   6   ,   19  },
        {   10  ,   6   ,   20  },
        {   11  ,   6   ,   21  },
        {   12  ,   6   ,   22  },
        {   13  ,   6   ,   23  },
        {   14  ,   6   ,   24  },
        {   14  ,   7   ,   25  },
        {   14  ,   8   ,   26  },
        {   13  ,   8   ,   27  },
        {   12  ,   8   ,   28  },
        {   11  ,   8   ,   29  },
        {   10  ,   8   ,   30  },
        {   9   ,   8   ,   31  },
        {   8   ,   9   ,   32  },
        {   8   ,   10  ,   33  },
        {   8   ,   11  ,   34  },
        {   8   ,   12  ,   35  },
        {   8   ,   13  ,   36  },
        {   8   ,   14  ,   37  },
        {   7   ,   14  ,   38  },
        {   6   ,   14  ,   39  },
        {   6   ,   13  ,   40  },
        {   6   ,   12  ,   41  },
        {   6   ,   11  ,   42  },
        {   6   ,   10  ,   43  },
        {   6   ,   9   ,   44  },
        {   5   ,   8   ,   45  },
        {   4   ,   8   ,   46  },
        {   3   ,   8   ,   47  },
        {   2   ,   8   ,   48  },
        {   1   ,   8   ,   49  },
        {   0   ,   8   ,   50  },
        {   0   ,   7   ,   51  },
        {   1   ,   7   ,   52  },//bat dau pit 0
        {   2   ,   7   ,   53  },
        {   3   ,   7   ,   54  },
        {   4   ,   7   ,   55  },
        {   5   ,   7   ,   56  },
        {   6   ,   7   ,   57  },//ket thuc pit0
        {   7   ,   1   ,   58  },//bat dau pit1
        {   7   ,   2   ,   59  },
        {   7   ,   3   ,   60  },
        {   7   ,   4   ,   61  },
        {   7   ,   5   ,   62  },
        {   7   ,   6   ,   63  },//ket thuc pit1
        {   13  ,   7   ,   64  },//bat dau pit2
        {   12  ,   7   ,   65  },
        {   11  ,   7   ,   66  },
        {   10  ,   7   ,   67  },
        {   9   ,   7   ,   68  },
        {   8   ,   7   ,   69  },//ket thuc pit2
        {   7   ,   13  ,   70  },//bat dau pit3
        {   7   ,   12  ,   71  },
        {   7   ,   11  ,   72  },
        {   7   ,   10  ,   73  },
        {   7   ,   9   ,   74  },
        {   7   ,   8   ,   75  }, //ket thuc pit3
       };

        private sbyte[] Player0RelaToAbsPos = new sbyte[57]
        {
            1   ,
            2   ,
            3   ,
            4   ,
            5   ,
            6   ,
            7   ,
            8   ,
            9   ,
            10  ,
            11  ,
            12  ,
            13  ,
            14  ,
            15  ,
            16  ,
            17  ,
            18  ,
            19  ,
            20  ,
            21  ,
            22  ,
            23  ,
            24  ,
            25  ,
            26  ,
            27  ,
            28  ,
            29  ,
            30  ,
            31  ,
            32  ,
            33  ,
            34  ,
            35  ,
            36  ,
            37  ,
            38  ,
            39  ,
            40  ,
            41  ,
            42  ,
            43  ,
            44  ,
            45  ,
            46  ,
            47  ,
            48  ,
            49  ,
            50  ,
            51  ,
            52  ,
            53  ,
            54  ,
            55  ,
            56  ,
            57  ,
        };

        private sbyte[] Player1RelaToAbsPos = new sbyte[57]
        {
            14  ,
            15  ,
            16  ,
            17  ,
            18  ,
            19  ,
            20  ,
            21  ,
            22  ,
            23  ,
            24  ,
            25  ,
            26  ,
            27  ,
            28  ,
            29  ,
            30  ,
            31  ,
            32  ,
            33  ,
            34  ,
            35  ,
            36  ,
            37  ,
            38  ,
            39  ,
            40  ,
            41  ,
            42  ,
            43  ,
            44  ,
            45  ,
            46  ,
            47  ,
            48  ,
            49  ,
            50  ,
            51  ,
            0   ,
            1   ,
            2   ,
            3   ,
            4   ,
            5   ,
            6   ,
            7   ,
            8   ,
            9   ,
            10  ,
            11  ,
            12  ,
            58  ,
            59  ,
            60  ,
            61  ,
            62  ,
            63  ,

        };

        private sbyte[] Player2RelaToAbsPos = new sbyte[57]
        {
            27  ,
            28  ,
            29  ,
            30  ,
            31  ,
            32  ,
            33  ,
            34  ,
            35  ,
            36  ,
            37  ,
            38  ,
            39  ,
            40  ,
            41  ,
            42  ,
            43  ,
            44  ,
            45  ,
            46  ,
            47  ,
            48  ,
            49  ,
            50  ,
            51  ,
            0   ,
            1   ,
            2   ,
            3   ,
            4   ,
            5   ,
            6   ,
            7   ,
            8   ,
            9   ,
            10  ,
            11  ,
            12  ,
            13  ,
            14  ,
            15  ,
            16  ,
            17  ,
            18  ,
            19  ,
            20  ,
            21  ,
            22  ,
            23  ,
            24  ,
            25  ,
            64  ,
            65  ,
            66  ,
            67  ,
            68  ,
            69  ,

        };

        private sbyte[] Player3RelaToAbsPos = new sbyte[57]
        {
            40  ,
            41  ,
            42  ,
            43  ,
            44  ,
            45  ,
            46  ,
            47  ,
            48  ,
            49  ,
            50  ,
            51  ,
            0   ,
            1   ,
            2   ,
            3   ,
            4   ,
            5   ,
            6   ,
            7   ,
            8   ,
            9   ,
            10  ,
            11  ,
            12  ,
            13  ,
            14  ,
            15  ,
            16  ,
            17  ,
            18  ,
            19  ,
            20  ,
            21  ,
            22  ,
            23  ,
            24  ,
            25  ,
            26  ,
            27  ,
            28  ,
            29  ,
            30  ,
            31  ,
            32  ,
            33  ,
            34  ,
            35  ,
            36  ,
            37  ,
            38  ,
            70  ,
            71  ,
            72  ,
            73  ,
            74  ,
            75  ,

        };

        private int[] PiecePlacedOnAbsPos = new int[76]
        {
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,
            -1  ,

        };

        private sbyte[,] CagePos = new sbyte[16, 2]
        {      //x      y
            {   2   ,   2   },
            {   3   ,   2   },
            {   3   ,   3   },
            {   2   ,   3   },
            {   11  ,   2   },
            {   12  ,   2   },
            {   12  ,   3   },
            {   11  ,   3   },
            {   11  ,   11  },
            {   12  ,   11  },
            {   12  ,   12  },
            {   11  ,   12  },
            {   2   ,   11  },
            {   3   ,   11  },
            {   3   ,   12  },
            {   2   ,   12  },

        };


        private List<sbyte[]> PlayerRelaToAbsPos = new List<sbyte[]>();

        //constructor thêm vào list PlayerRelaToAbsPos
        public LudoGameEngine()
        {
            PlayerRelaToAbsPos.Add(Player0RelaToAbsPos);
            PlayerRelaToAbsPos.Add(Player1RelaToAbsPos);
            PlayerRelaToAbsPos.Add(Player2RelaToAbsPos);
            PlayerRelaToAbsPos.Add(Player3RelaToAbsPos);

            //PlayerRelaToAbsPos[0] = Player0RelaToAbsPos;
            //PlayerRelaToAbsPos[1] = Player1RelaToAbsPos;
            //PlayerRelaToAbsPos[2] = Player2RelaToAbsPos;
            //PlayerRelaToAbsPos[3] = Player3RelaToAbsPos;
        }


        #region Các hàm public lấy giá trị trong bảng tham chiếu set cho piece (trả về new Position2D)
        //hàm lấy pos 2D bằng relaPos của Piece
        public Position2D GetPosition2D_RelaPos(int relaPos, int pindex)
        {

            int abspos = GetAbsPos_RelaPos(relaPos, pindex);
            int col = AbsPosTo2DPos[abspos, 0];
            int row = AbsPosTo2DPos[abspos, 1];
            return new Position2D(col, row);
        }
        public Position2D GetCage2DPos(int pindex)
        {
            int x = CagePos[pindex, 0];
            int y = CagePos[pindex, 1];
            return new Position2D(x, y);
        }


        #endregion

        #region Các hàm private phục vụ cho kiểm tra tranh chấp
        //hàm lấy vị trí tuyệt đối từ vị trí tương đối của piece
        private int GetAbsPos_RelaPos(int relaPos, int pindex)
        {
            int playerNumb = pindex / 4;
            int abspos = PlayerRelaToAbsPos[playerNumb][relaPos];
            return abspos;
        }
        //hàm kiểm tra 2 piece là đồng minh thông qua pindex của chúng
        private bool IsPiecesFriend(int pindex1, int pindex2)
        {
            return pindex1 / 4 == pindex2 / 4;
        }

        //hàm kiểm tra nếu trong bảng tham chiếu vị trí tuyệt đối (PiecePlaceOnAbsPos) tại ví trí kết thúc pit tuyệt đối của piece có chứa pindex nào = pindex của piece không
        //kết quả sẽ sai nếu kiểm tra 1 piece có trong pit end nếu trước đó đã có 1 piece đồng minh tiến vô pit end
        private bool IsPieceAtPitEnd(int pindex)
        {
            int playerNumb = pindex / 4;
            int absPos = PlayerRelaToAbsPos[playerNumb][56];
            return PiecePlacedOnAbsPos[absPos] == pindex; //kiem tra tai abs pos place co pindex nao = pindex truyen vao thi return true
        }



        #endregion

        #region Các Hàm public cập nhật pindex lên bảng tham chiếu vị trí tuyệt đổi (PiecePlaceOnAbsPos)
        //hàm gán giá trị pindex của piece lên absolute map
        //chỉ update bảng tham chiếu nếu tại vị trí đó không có pindex nào khác hoặc vị trí đó là pit end của pindex
        public void PlacePieceOnAbsMap_RelaPos(int pindex, int relaPos)
        {
            int abspos = GetAbsPos_RelaPos(relaPos, pindex);
            if (PiecePlacedOnAbsPos[abspos] == -1 || relaPos == 56)
                PiecePlacedOnAbsPos[abspos] = pindex;
            else return;
        }

        //hàm gỡ pindex ra khỏi bảng tham chiếu
        public void DeplacePieceOnAbsMap_RelaPos(int pindex)
        {
            for (int i = 0; i < 76; i++)
            {
                if (PiecePlacedOnAbsPos[i] == pindex)
                {
                    PiecePlacedOnAbsPos[i] = -1;
                    break;
                }
            }
        }
        #endregion

        #region Các hàm in bảng tham chiếu để debug
        public void Print_PiecePlaceOnAbsPos()
        {
            for (int i = 0; i < 76; i++)
            {
                Console.WriteLine("Abs. Pos. #" + i.ToString() + " Pindex: " + PiecePlacedOnAbsPos[i].ToString());
            }
        }

        #endregion


        //hàm kiểm tra va chạm
        public int CheckCollisionOf_RelaPos(int pindex, int relaPos)
        {
            //tra ve index cua quan dich neu co the kick, tra ve -2 neu ko co colli, tra ve -1 neu co colli va ko the kick
            int enemyAbspos = GetAbsPos_RelaPos(relaPos, pindex);
            int enemyPindex = PiecePlacedOnAbsPos[enemyAbspos];
            int enemyPlayerNumb = enemyPindex / 4;
            if (enemyPindex == -1) return -2; //ko co colli
            else
            {
                if (IsPiecesFriend(pindex, enemyPindex))
                {
                    if (relaPos != 56) return -1;//nếu enemy là quân mình và vị trí tương đổi đang tiến tới không là pit end thì không được chồng quân
                    else return -2; //enemy la quan minh va quan minh o pit end thi duoc chong len nhau
                }
                else
                {
                    if (enemyAbspos == PlayerRelaToAbsPos[enemyPlayerNumb][0]) return -1;//va cham voi quan dich tai o bat dau cua no
                    else return enemyPindex;
                }
            }

        }

        //hàm di chuyển piece trả về kết quả thành công theo true/false
        public int TryToMovePiece(Piece piece, int move)
        {
            int pindex = piece.Pindex;
            //kiem tra piece trong chuong
            if (piece.PosRela == -1)
            {
                if (move == 6)
                {
                    piece.PosRela = 0;
                    piece.Pos2D = GetPosition2D_RelaPos(0, pindex);
                    PlacePieceOnAbsMap_RelaPos(pindex, 0);

                    return -2;
                }
                else
                {
                    return -1;
                }
            }
            //piece khong nam trong chuong (piece.PosRela >= 0)
            int tempRelaPos = piece.PosRela + move;
            if (tempRelaPos > 56) return -1;
            //kiem tra va cham
            int collisionFlag = CheckCollisionOf_RelaPos(pindex, tempRelaPos);
            switch (collisionFlag)
            {
                case -2:
                    {
                        //vi tri tien den ko co va cham
                        DeplacePieceOnAbsMap_RelaPos(pindex);
                        piece.PosRela = tempRelaPos;
                        piece.Pos2D = GetPosition2D_RelaPos(tempRelaPos, pindex);
                        PlacePieceOnAbsMap_RelaPos(pindex, tempRelaPos);
                        return -2;
                    }
                case -1:
                    {
                        //du nguyen vi tri
                        return -1;
                    }
                default:
                    //co va cham nhung kick quan duoc
                    DeplacePieceOnAbsMap_RelaPos(pindex);
                    piece.PosRela = tempRelaPos;
                    piece.Pos2D = GetPosition2D_RelaPos(tempRelaPos, pindex);
                    PlacePieceOnAbsMap_RelaPos(pindex, tempRelaPos);

                    return collisionFlag;
            }

        }




    }

    internal class Position2D
    {
        public int col { get; }
        public int row { get; }

        public Position2D(int x, int y)
        {
            col = x; row = y;

        }



    }

    internal class Piece:Button
    {
        public int Pindex { get; set; }
        public Position2D Pos2D { get; set; }
        public int PosRela { get; set; }

        public Piece(Position2D pos2d, int pindex)
        {
            Pos2D = pos2d;
            Pindex = pindex;
            PosRela = -1;
            this.Size = new Size(60, 60);
        }


    }
}

