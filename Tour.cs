using System;

namespace KnightsTour
{
    class Tour
    {
        private const int Row = 8;
        private const int Col = 8;
        private const int GridSymbol = 0;
        private static int MoveSymbol = 1;
        private int rowStart, colStart;
        private static int[,] moves = new int[Row, Col];
        private static readonly int[] PossibleMovesX = new int[] { -1, 1, -2, 2, 1, -1, 2, -2 };
        private static readonly int[] PossibleMovesY = new int[] { 2, 2, 1, 1, -2, -2, -1, -1 };
        private static int hMove;
        private static int vMove;
        public int Steps { get { return MoveSymbol; } set { MoveSymbol = value; } }
        public int[,] Moves { get { return moves; } set { moves = value; } }

        public Tour()
        {
        }
        public Tour(int colStart, int rowStart, int method)
        {
            MoveSymbol = 1;
            this.colStart = colStart;
            this.rowStart = rowStart;
            moves[rowStart, colStart] = MoveSymbol;
            Play(method);
        }

        void Play(int type)
        {
            if (type == 1)
                while (GetMove()) ;
            
            if (type == 2)
                    while (GetMoveIntel());

            if (!GetMove() || !GetMoveIntel())
            {
                Steps = MoveSymbol;
                Moves = moves;
            }
        }

        bool GetMove()
        {
            Random r = new Random();
            int counter = 0;
            int[] refuse = { 9, 10, 11, 12, 13, 14, 15, 16 };

            while (counter < 8)
            {
                int rSelect = r.Next(0, 8);
                hMove = rowStart + PossibleMovesX[rSelect];
                vMove = colStart + PossibleMovesY[rSelect];

                if (IsValidMove(hMove, vMove))
                {
                    moves[hMove, vMove] = ++MoveSymbol;
                    rowStart = hMove;
                    colStart = vMove;
                    return true;
                }
                else
                {
                    bool moveMade = false;
                    for (int i = 0; i < 8; i++)
                        if (rSelect == refuse[i])
                            moveMade = true;
                    if (!moveMade)
                    {
                        refuse[counter] = rSelect;
                        counter++;
                    }
                }
            }

            return false;
        }

        bool GetMoveIntel()
        {
            Random r = new Random();
            int counter = 0;
            int[] refuse = { -1, -2, -3, -4, -5, -6, -7, -8 };

            while (counter < 8)
            {
                int rSelect = r.Next(0, 8);
                hMove = rowStart + PossibleMovesX[rSelect];
                vMove = colStart + PossibleMovesY[rSelect];

                if (IsValidMove(hMove, vMove) && SeeTheFuture(hMove, vMove) >= 1)
                {
                    moves[hMove, vMove] = ++MoveSymbol;
                    rowStart = hMove;
                    colStart = vMove;
                    return true;
                }
                else
                {
                    bool moveAlreadyMade = false;
                    for (int i = 0; i < 8; i++)
                        if (rSelect == refuse[i])
                            moveAlreadyMade = true;

                    if (!moveAlreadyMade)
                    {
                        refuse[counter] = rSelect;
                        counter++;
                    }
                }
            }

            return false;
        }

        int SeeTheFuture(int hor, int ver)
        {
            int counter = 0;
            int i = 0;
            while (i < 8)
            {
                int horMove = hor + PossibleMovesX[i];
                int verMove = ver + PossibleMovesY[i];
                i++;

                if (IsValidMove(horMove, verMove))
                {
                    counter++;
                    for (int j = 0; j < 8; j++)
                    {
                        int hor1 = horMove + PossibleMovesX[j];
                        int ver1 = verMove + PossibleMovesY[j];
                        if (IsValidMove(hor1, ver1))
                        {
                            counter++;
                            for (int w = 0; w < 8; w++)
                            {
                                int hor2 = hor1 + PossibleMovesX[w];
                                int ver2 = ver1 + PossibleMovesY[w];
                                if (IsValidMove(hor2, ver2))
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            return counter;
        }
        bool IsValidMove(int r, int c)
        {
            return ((r < Row && r >= 0) && (c < Col && c >= 0)) &&
                    (moves[r, c] == GridSymbol);
        }
        

    }
}
