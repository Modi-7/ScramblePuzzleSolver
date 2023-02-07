using System;
using System.Collections.Generic;
using System.Linq;

namespace ScramblePuzzleSolver
{
    class Program
    {
        static void ShiftArray(string[] array) //shifts array values by 1 position to the right (rotates piece)( ..2->3...3->0...)
        {
            string t = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
                array[i] = array[i - 1];
            array[0] = t;
        }

        static void Main(string[] args)
        {
            //describing pieces
            string[] PieceA = { "Obottom", "Ybottom", "Gtop", "Ytop" };
            string[] PieceB = { "Wtop", "Obottom", "Gtop", "Ytop" };
            string[] PieceC = { "Ytop", "Wbottom", "Obottom", "Gtop" };

            string[] PieceD = { "Gbottom", "Wbottom", "Obottom", "Ybottom" };
            string[] PieceE = { "Gtop", "Gbottom", "Obottom", "Wtop" };
            string[] PieceF = { "Obottom", "Wbottom", "Ytop", "Gtop" };

            string[] PieceG = { "Otop", "Gtop", "Ybottom", "Wtop" }; 
            string[] PieceH = { "Otop", "Wtop", "Ybottom", "Gbottom" };
            string[] PieceI = { "Otop", "Ytop", "Wtop", "Wbottom" };

            // 0 1 2   A B C 
            // 3 4 5   D E F
            // 6 7 8   G H I

            //piece sides in numbers
            //   0
            //3     1
            //   2

            Boolean pieceBfound = false;
            Boolean pieceCfound = false;
            Boolean pieceDfound = false;
            Boolean pieceEfound = false;
            Boolean pieceFfound = false;
            Boolean pieceGfound = false;
            Boolean pieceHfound = false;
            Boolean pieceIfound = false;

            int changeFirstPiece = 0;
            int alrdyPlaced0 = 10;
            int alrdyPlaced1 = 10;
            int alrdyPlaced2 = 10;
            int alrdyPlaced3 = 10;
            int alrdyPlaced4 = 10;
            int alrdyPlaced5 = 10;
            int alrdyPlaced6 = 10;
            int alrdyPlaced7 = 10;
            int alrdyPlaced8 = 10;

            string gridA;
            string gridB;
            string gridC;
            string gridD;
            string gridE;
            string gridE2;
            string gridF;
            string gridF2;
            string gridG;
            string gridH;
            string gridH2;
            string gridI;
            string gridI2;

            int arrB = 0;
            int arrC = 0;
            int arrD = 0;
            int arrE = 0;
            int arrF = 0;
            int arrG = 0;
            int arrH = 0;

            var wrongBpositoin = new int[9] { 20, 20, 20, 20, 20, 20 , 20, 20, 20 };
            var wrongCpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
            var wrongDpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
            var wrongEpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
            var wrongFpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
            var wrongGpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
            var wrongHpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };

            string[][] arr = { PieceA, PieceB, PieceC, PieceD, PieceE, PieceF, PieceG, PieceH, PieceI };

            for (int a = 0; a < 9; a++) 
            {
                
                for (int b = 0; b < 9; b++)
                {
                    findB:
                    for (int c = 0; c < 9; c++)
                    {
                        findC:
                        for (int d = 0; d < 9; d++)
                        {
                            findD:
                            for (int e = 0; e < 9; e++)
                            {
                                findE:
                                for (int f = 0; f < 9; f++)
                                {
                                    findF:
                                    for (int g = 0; g < 9; g++)
                                    {
                                        findG:
                                        for (int h = 0; h < 9; h++)
                                        {
                                            findH:
                                            for (int i = 0; i < 9; i++) 
                                            {
                                                findA:
                                                if ( b>= 9)  // if B tried every piece > hard reset and state of A piece(rotates or new)
                                                {
                                                    
                                                    arrB = 0;
                                                    arrC = 0;
                                                    arrD = 0;
                                                    arrE = 0;
                                                    arrF = 0;
                                                    arrG = 0;
                                                    arrH = 0;

                                                    wrongBpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongCpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongDpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongEpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongFpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongGpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };
                                                    wrongHpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };

                                                    b = 0;
                                                    c = 0;
                                                    d = 0;
                                                    e = 0;
                                                    f = 0;
                                                    g = 0;
                                                    h = 0;
                                                    i = 0;

                                                    if (changeFirstPiece < 4) //rotates A piece
                                                    {
                                                        ShiftArray(arr[a]);
                                                        changeFirstPiece++;
                                                        continue;
                                                    }

                                                    if (changeFirstPiece == 4) //if A piece was rotated 4 times > change A piece
                                                    {
                                                        a++;
                                                        Console.WriteLine("New A piece");
                                                        changeFirstPiece = 0; //reset rotations
                                                    }

                                                }

                                                if (b == 9) { a++; wrongBpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrB = 0; goto findA; } // if there are no pieces left for B > reset B and go to A
                                                if (pieceBfound == false)
                                                {
                                                    if (wrongBpositoin.Contains(b)) { b++; continue; } //if piece was already tried skip to next piece

                                                    if (arr[a] != arr[b]) // cant use same piece on A and B
                                                    {
                                                        for (int x = 0; x < 4; x++) // loops for rotating
                                                        {
                                                            gridA = arr[a][1]; //gets pattern on pos. 1 (a=position on grid)
                                                            gridB = arr[b][3]; //gets pattern on pos. 3 (b=position on grid)

                                                            char startA = gridA[0]; // color A
                                                            char startB = gridB[0]; // color B

                                                            if (startA == startB) //color of A and B match
                                                            {
                                                                if ((gridA.Contains("bottom") && gridB.Contains("top")) || (gridA.Contains("top") && gridB.Contains("bottom"))) // pattern match
                                                                {
                                                                    Console.WriteLine("B fits " + b);

                                                                    alrdyPlaced0 = a; // occupy place A
                                                                    alrdyPlaced1 = b; // occupy place B

                                                                    wrongBpositoin.SetValue(value: b, index: arrB);//remembers pieces already tried on B position
                                                                    
                                                                    arrB++; // gets value at new position, so it doesnt replace already tried value
                                                                    pieceBfound = true; // switch off searching for piece B                                                                                        
                                                                    b = 0;
                                                                    break;
                                                                }
                                                            }

                                                            ShiftArray(arr[b]); //rotates piece
                                                        }

                                                    }

                                                    b++;
                                                    goto findA;

                                                }

                                                // if C cannot be found > search for B again and reset C
                                                if (c == 9) { b++; pieceBfound = false; wrongCpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrC = 0; goto findB; }
                                                if (pieceCfound == false)
                                                {
                                                    if (wrongCpositoin.Contains(c)) { c++; goto findC; }
                                                    if (alrdyPlaced1 != c && alrdyPlaced0 != c) //cannot use the pieces that already have been used
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridB = arr[alrdyPlaced1][1]; //position on grid - pattern on pos. 1
                                                            gridC = arr[c][3];            //position on grid - pattern on pos. 3

                                                            char startB = gridB[0];
                                                            char startC = gridC[0];

                                                            if (startB == startC)
                                                            {
                                                                if ((gridB.Contains("bottom") && gridC.Contains("top")) || (gridB.Contains("top") && gridC.Contains("bottom")))
                                                                {
                                                                    Console.WriteLine("C fits " + c);
                                                                    alrdyPlaced2 = c;
                                                                    pieceCfound = true;
                                                                    wrongCpositoin.SetValue(value: c, index: arrC);//remembers pieces already tried on this position
                                                                    if (arrC < 8) { arrC++; }
                                                                    c = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[c]);
                                                        }

                                                    }

                                                    c++;
                                                    goto findA;
                                                }

                                                if (d == 9) { c++; pieceCfound = false; wrongDpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrD = 0; goto findC; }
                                                if (pieceDfound == false)
                                                {
                                                    if (wrongDpositoin.Contains(d)) { d++; goto findD; }
                                                    if (alrdyPlaced1 != d && alrdyPlaced0 != d && alrdyPlaced2 != d)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridA = arr[alrdyPlaced0][2];
                                                            gridD = arr[d][0];

                                                            char startA = gridA[0];
                                                            char startD = gridD[0];

                                                            if (startA == startD)
                                                            {
                                                                if ((gridA.Contains("bottom") && gridD.Contains("top")) || (gridA.Contains("top") && gridD.Contains("bottom")))
                                                                {
                                                                    Console.WriteLine("D fits " + d);
                                                                    alrdyPlaced3 = d;
                                                                    pieceDfound = true;
                                                                    wrongDpositoin.SetValue(value: d, index: arrD);
                                                                    if (arrD < 8) { arrD++; }
                                                                    d = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[d]);
                                                        }

                                                    }

                                                    d++;
                                                    goto findA;
                                                }

                                                if (e == 9) {d++; pieceDfound = false; wrongEpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrE = 0; goto findD; }
                                                if (pieceEfound == false)
                                                {
                                                    if (wrongEpositoin.Contains(e)) { e++; goto findE; }
                                                    if (alrdyPlaced1 != e && alrdyPlaced0 != e && alrdyPlaced2 != e && alrdyPlaced3 != e)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridB = arr[alrdyPlaced1][2];
                                                            gridD = arr[alrdyPlaced3][1];
                                                            gridE = arr[e][0];
                                                            gridE2 = arr[e][3];

                                                            char startB = gridB[0];
                                                            char startE = gridE[0];
                                                            char startD = gridD[0];
                                                            char startE2 = gridE2[0];

                                                            if ((startB == startE) && (startD == startE2))
                                                            {
                                                                if (((gridB.Contains("bottom") && gridE.Contains("top")) || (gridB.Contains("top") && gridE.Contains("bottom"))) && (((gridE2.Contains("bottom") && gridD.Contains("top")) || (gridE2.Contains("top") && gridD.Contains("bottom")))))
                                                                {
                                                                    Console.WriteLine("E fits " + e);
                                                                    alrdyPlaced4 = e;
                                                                    pieceEfound = true;
                                                                    wrongEpositoin.SetValue(value: e, index: arrE);
                                                                    if (arrE < 8) { arrE++; }
                                                                    e = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[e]);
                                                        }

                                                    }

                                                    e++;
                                                    goto findA;
                                                }

                                                if (f == 9) { e++; pieceEfound = false; wrongFpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrF = 0; goto findE; }
                                                if (pieceFfound == false)
                                                {
                                                    if (wrongFpositoin.Contains(f)) { f++; goto findF; }
                                                    if (alrdyPlaced1 != f &&  alrdyPlaced0 != f && alrdyPlaced2 != f && alrdyPlaced3 != f && alrdyPlaced4 != f)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridC = arr[alrdyPlaced2][2];
                                                            gridE = arr[alrdyPlaced4][1];
                                                            gridF = arr[f][0]; //TOP
                                                            gridF2 = arr[f][3]; //LEFT

                                                            char startE = gridE[0];
                                                            char startF = gridF[0];
                                                            char startC = gridC[0];
                                                            char startF2 = gridF2[0];

                                                            if ((startC == startF) && (startE == startF2))
                                                            {
                                                                if (((gridE.Contains("bottom") && gridF2.Contains("top")) || (gridE.Contains("top") && gridF2.Contains("bottom"))) && (((gridC.Contains("bottom") && gridF.Contains("top")) || (gridC.Contains("top") && gridF.Contains("bottom")))))
                                                                {
                                                                    Console.WriteLine("F fits " + f);
                                                                    alrdyPlaced5 = f;
                                                                    pieceFfound = true;
                                                                    wrongFpositoin.SetValue(value: f, index: arrF);
                                                                    if (arrF < 8) { arrF++; }
                                                                    f = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[f]);
                                                        }

                                                    }

                                                    f++;
                                                    goto findA;
                                                }

                                                
                                                if (g == 9) { f++; pieceFfound = false; wrongGpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 }; arrG = 0; goto findF; } 
                                                if (pieceGfound == false)
                                                {
                                                    if (wrongGpositoin.Contains(g)) { g++; goto findG; }
                                                    if (alrdyPlaced1 != g && alrdyPlaced0 != g && alrdyPlaced2 != g && alrdyPlaced3 != g && alrdyPlaced4 != g && alrdyPlaced5 != g)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridD = arr[alrdyPlaced3][2];
                                                            gridG = arr[g][0];

                                                            char startD = gridD[0];
                                                            char startG = gridG[0];

                                                            if (startD == startG)
                                                            {
                                                                if ((gridD.Contains("bottom") && gridG.Contains("top")) || (gridD.Contains("top") && gridG.Contains("bottom")))
                                                                {
                                                                    Console.WriteLine("G fits " + g);
                                                                    alrdyPlaced6 = g;
                                                                    pieceGfound = true;
                                                                    wrongGpositoin.SetValue(value: g, index: arrG);
                                                                    if (arrG < 8) { arrG++; }
                                                                    g = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[g]);
                                                        }

                                                    }

                                                    g++;
                                                    goto findA;

                                                }

                                                if (h == 9) { g++; pieceGfound = false; wrongHpositoin = new int[9] { 20, 20, 20, 20, 20, 20, 20, 20, 20 };  goto findG; }
                                                if (pieceHfound == false)
                                                {
                                                    if (wrongHpositoin.Contains(h)) { h++; goto findH; }
                                                    if (alrdyPlaced1 != h && alrdyPlaced0 != h && alrdyPlaced2 != h && alrdyPlaced3 != h && alrdyPlaced4 != h && alrdyPlaced5 != h && alrdyPlaced6 != h)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridE = arr[alrdyPlaced4][2];
                                                            gridG = arr[alrdyPlaced6][1];
                                                            gridH = arr[h][0]; //TOP
                                                            gridH2 = arr[h][3]; //LEFT

                                                            char startE = gridE[0];
                                                            char startH = gridH[0];
                                                            char startG = gridG[0];
                                                            char startH2 = gridH2[0];

                                                            if ((startH == startE) && (startH2 == startG))
                                                            {
                                                                if (((gridG.Contains("bottom") && gridH2.Contains("top")) || (gridG.Contains("top") && gridH2.Contains("bottom"))) && (((gridE.Contains("bottom") && gridH.Contains("top")) || (gridE.Contains("top") && gridH.Contains("bottom")))))
                                                                {
                                                                    Console.WriteLine("H fits " + h);
                                                                    alrdyPlaced7 = h;
                                                                    pieceHfound = true;
                                                                    wrongHpositoin.SetValue(value: h, index: arrH);
                                                                    if (arrH < 8) { arrH++; }
                                                                    h = 0;
                                                                    break;
                                                                }
                                                            }
                                                            ShiftArray(arr[h]);
                                                        }

                                                    }

                                                    h++;
                                                    goto findA;

                                                }

                                                if (i == 9) { h++; pieceHfound = false;  goto findH; }
                                                if (pieceIfound == false)
                                                {

                                                    if (alrdyPlaced1 != i && alrdyPlaced0 != i && alrdyPlaced2 != i && alrdyPlaced3 != i && alrdyPlaced4 != i && alrdyPlaced5 != i && alrdyPlaced6 != i &&  alrdyPlaced7 != i)
                                                    {
                                                        for (int x = 0; x < 4; x++)
                                                        {
                                                            gridF = arr[alrdyPlaced5][2];
                                                            gridH = arr[alrdyPlaced7][1];
                                                            gridI = arr[i][0]; //TOP
                                                            gridI2 = arr[i][3]; //LEFT

                                                            char startF = gridF[0];
                                                            char startI = gridI[0];
                                                            char startH = gridH[0];
                                                            char startI2 = gridI2[0];

                                                            if ((startI == startF) && (startI2 == startH))
                                                            {
                                                                if (((gridH.Contains("bottom") && gridI2.Contains("top")) || (gridH.Contains("top") && gridI2.Contains("bottom"))) && (((gridF.Contains("bottom") && gridI.Contains("top")) || (gridF.Contains("top") && gridI.Contains("botom")))))
                                                                {
                                                                    Console.WriteLine("I fits " + i);
                                                                    alrdyPlaced8 = i;
                                                                    pieceIfound = true;
                                                                    
                                                                    Console.WriteLine("\nOriginal:\n0      1      2 \n3      4      5 \n6      7      8\n");
                                                                    Console.WriteLine("\nSolution found:");
                                                                    Console.WriteLine(alrdyPlaced0 + " " + arr[alrdyPlaced0][0].PadRight(12) + " " + alrdyPlaced1+" "+ arr[alrdyPlaced1][0].PadRight(12) + " "+alrdyPlaced2 + " " + arr[alrdyPlaced2][0] );
                                                                    Console.WriteLine(alrdyPlaced3 + " " + arr[alrdyPlaced3][0].PadRight(12) + " " + alrdyPlaced4 + " " + arr[alrdyPlaced4][0].PadRight(12) + " " + alrdyPlaced5 + " " + arr[alrdyPlaced5][0]);
                                                                    Console.WriteLine(alrdyPlaced6 + " " + arr[alrdyPlaced6][0].PadRight(12) + " " + alrdyPlaced7 + " " + arr[alrdyPlaced7][0].PadRight(12) + " " + alrdyPlaced8 + " " + arr[alrdyPlaced8][0]);
                                                                    Console.WriteLine("");
                                                                    Console.WriteLine("Patterns next to number must be at the top of the piece");
                                                                    Console.WriteLine("Obottom = Orange cat bottom, Gtop = Grey cat top and so on");
                                                                    Console.WriteLine("\nPress Any key to end");
                                                                    Console.ReadKey();
                                                                    //break;
                                                                    Environment.Exit(0);
                                                                }
                                                            }
                                                            ShiftArray(arr[i]);
                                                        }

                                                    }
                                                    i++;
                                                    goto findA;

                                                }
                                            }
                                        }
                                    }
                                }
                            }                           
                        }       
                    }
                }
            }

        }
    }
    
}
