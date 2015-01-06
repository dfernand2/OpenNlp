﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Trees.TRegex.Tsurgeon
{
    public class TsurgeonParserTokenManager : TsurgeonParserConstants
    {

        private int curLexState = 2;
        private int defaultLexState = 2;
        private int jjnewStateCnt;
        private uint jjround;
        private int jjmatchedPos;
        private int jjmatchedKind;

        protected SimpleCharStream input_stream;

        private readonly uint[] jjrounds = new uint[58];
        private readonly int[] jjstateSet = new int[2*58];


        protected char curChar;

        /** Debug output. */
        //public  java.io.PrintStream debugStream = System.out;
        /** Set debug output. */
        //public  void setDebugStream(java.io.PrintStream ds) { debugStream = ds; }
        private int jjStopAtPos(int pos, int kind)
        {
            jjmatchedKind = kind;
            jjmatchedPos = pos;
            return pos + 1;
        }

        private int jjMoveStringLiteralDfa0_2()
        {
            switch ((int) curChar)
            {
                case 91:
                    return jjStopAtPos(0, 5);
                case 97:
                    return jjMoveStringLiteralDfa1_2(0xe0000L);
                case 99:
                    return jjMoveStringLiteralDfa1_2(0x110000L);
                case 100:
                    return jjMoveStringLiteralDfa1_2(0x200L);
                case 101:
                    return jjMoveStringLiteralDfa1_2(0x1100L);
                case 105:
                    return jjMoveStringLiteralDfa1_2(0x2040L);
                case 109:
                    return jjMoveStringLiteralDfa1_2(0x4000L);
                case 110:
                    return jjMoveStringLiteralDfa1_2(0x80L);
                case 112:
                    return jjMoveStringLiteralDfa1_2(0x400L);
                case 114:
                    return jjMoveStringLiteralDfa1_2(0x8800L);
                default:
                    return 1;
            }
        }

        private int jjMoveStringLiteralDfa1_2(long active0)
        {
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 1;
            }
            switch ((int) curChar)
            {
                case 100:
                    return jjMoveStringLiteralDfa2_2(active0, 0xe0000L);
                case 101:
                    return jjMoveStringLiteralDfa2_2(active0, 0x8a00L);
                case 102:
                    if ((active0 & 0x40L) != 0L)
                        return jjStopAtPos(1, 6);
                    break;
                case 110:
                    return jjMoveStringLiteralDfa2_2(active0, 0x2000L);
                case 111:
                    return jjMoveStringLiteralDfa2_2(active0, 0x104080L);
                case 114:
                    return jjMoveStringLiteralDfa2_2(active0, 0x10400L);
                case 120:
                    return jjMoveStringLiteralDfa2_2(active0, 0x1100L);
                default:
                    return 2;
            }
            return 2;
        }

        private int jjMoveStringLiteralDfa2_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 2;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 2;
            }
            switch ((int) curChar)
            {
                case 99:
                    return jjMoveStringLiteralDfa3_2(active0, 0x1000L);
                case 101:
                    return jjMoveStringLiteralDfa3_2(active0, 0x10000L);
                case 105:
                    return jjMoveStringLiteralDfa3_2(active0, 0x100100L);
                case 106:
                    return jjMoveStringLiteralDfa3_2(active0, 0xe0000L);
                case 108:
                    return jjMoveStringLiteralDfa3_2(active0, 0xa00L);
                case 112:
                    return jjMoveStringLiteralDfa3_2(active0, 0x8000L);
                case 115:
                    return jjMoveStringLiteralDfa3_2(active0, 0x2000L);
                case 116:
                    if ((active0 & 0x80L) != 0L)
                        return jjStopAtPos(2, 7);
                    break;
                case 117:
                    return jjMoveStringLiteralDfa3_2(active0, 0x400L);
                case 118:
                    return jjMoveStringLiteralDfa3_2(active0, 0x4000L);
                default:
                    return 3;
            }
            return 3;
        }

        private int jjMoveStringLiteralDfa3_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 3;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 3;
            }
            switch ((int) curChar)
            {
                case 97:
                    return jjMoveStringLiteralDfa4_2(active0, 0x10800L);
                case 101:
                    if ((active0 & 0x4000L) != 0L)
                        return jjStopAtPos(3, 14);
                    return jjMoveStringLiteralDfa4_2(active0, 0x2200L);
                case 105:
                    return jjMoveStringLiteralDfa4_2(active0, 0x1000L);
                case 108:
                    return jjMoveStringLiteralDfa4_2(active0, 0x8000L);
                case 110:
                    return jjMoveStringLiteralDfa4_2(active0, 0x100400L);
                case 111:
                    return jjMoveStringLiteralDfa4_2(active0, 0xe0000L);
                case 115:
                    return jjMoveStringLiteralDfa4_2(active0, 0x100L);
                default:
                    return 4;
            }
        }

        private int jjMoveStringLiteralDfa4_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 4;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 4;
            }
            switch ((int) curChar)
            {
                case 97:
                    return jjMoveStringLiteralDfa5_2(active0, 0x8000L);
                case 98:
                    return jjMoveStringLiteralDfa5_2(active0, 0x800L);
                case 100:
                    return jjMoveStringLiteralDfa5_2(active0, 0x100000L);
                case 101:
                    if ((active0 & 0x400L) != 0L)
                        return jjStopAtPos(4, 10);
                    break;
                case 105:
                    return jjMoveStringLiteralDfa5_2(active0, 0xe0000L);
                case 114:
                    return jjMoveStringLiteralDfa5_2(active0, 0x2000L);
                case 115:
                    return jjMoveStringLiteralDfa5_2(active0, 0x1000L);
                case 116:
                    return jjMoveStringLiteralDfa5_2(active0, 0x10300L);
                default:
                    return 5;
            }
            return 5;
        }

        private int jjMoveStringLiteralDfa5_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 5;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 5;
            }
            switch ((int) curChar)
            {
                case 99:
                    return jjMoveStringLiteralDfa6_2(active0, 0x8000L);
                case 101:
                    if ((active0 & 0x200L) != 0L)
                        return jjStopAtPos(5, 9);
                    else if ((active0 & 0x1000L) != 0L)
                        return jjStopAtPos(5, 12);
                    return jjMoveStringLiteralDfa6_2(active0, 0x110800L);
                case 110:
                    if ((active0 & 0x20000L) != 0L)
                    {
                        jjmatchedKind = 17;
                        jjmatchedPos = 5;
                    }
                    return jjMoveStringLiteralDfa6_2(active0, 0xc0000L);
                case 115:
                    if ((active0 & 0x100L) != 0L)
                        return jjStopAtPos(5, 8);
                    break;
                case 116:
                    if ((active0 & 0x2000L) != 0L)
                        return jjStopAtPos(5, 13);
                    break;
                default:
                    return 6;
            }
            return 6;
        }

        private int jjMoveStringLiteralDfa6_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 6;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 6;
            }
            switch ((int) curChar)
            {
                case 70:
                    if ((active0 & 0x80000L) != 0L)
                        return jjStopAtPos(6, 19);
                    break;
                case 72:
                    if ((active0 & 0x40000L) != 0L)
                        return jjStopAtPos(6, 18);
                    break;
                case 83:
                    return jjMoveStringLiteralDfa7_2(active0, 0x10000L);
                case 101:
                    if ((active0 & 0x8000L) != 0L)
                        return jjStopAtPos(6, 15);
                    break;
                case 108:
                    if ((active0 & 0x800L) != 0L)
                        return jjStopAtPos(6, 11);
                    break;
                case 120:
                    if ((active0 & 0x100000L) != 0L)
                        return jjStopAtPos(6, 20);
                    break;
                default:
                    return 7;
            }
            return 7;
        }

        private int jjMoveStringLiteralDfa7_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 7;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 7;
            }
            switch ((int) curChar)
            {
                case 117:
                    return jjMoveStringLiteralDfa8_2(active0, 0x10000L);
                default:
                    return 8;
            }
        }

        private int jjMoveStringLiteralDfa8_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 8;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 8;
            }
            switch ((int) curChar)
            {
                case 98:
                    return jjMoveStringLiteralDfa9_2(active0, 0x10000L);
                default:
                    return 9;
            }
        }

        private int jjMoveStringLiteralDfa9_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 9;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 9;
            }
            switch ((int) curChar)
            {
                case 116:
                    return jjMoveStringLiteralDfa10_2(active0, 0x10000L);
                default:
                    return 10;
            }
        }

        private int jjMoveStringLiteralDfa10_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 10;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 10;
            }
            switch ((int) curChar)
            {
                case 114:
                    return jjMoveStringLiteralDfa11_2(active0, 0x10000L);
                default:
                    return 11;
            }
        }

        private int jjMoveStringLiteralDfa11_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 11;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 11;
            }
            switch ((int) curChar)
            {
                case 101:
                    return jjMoveStringLiteralDfa12_2(active0, 0x10000L);
                default:
                    return 12;
            }
        }

        private int jjMoveStringLiteralDfa12_2(long old0, long active0)
        {
            if (((active0 &= old0)) == 0L)
                return 12;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return 12;
            }
            switch ((int) curChar)
            {
                case 101:
                    if ((active0 & 0x10000L) != 0L)
                        return jjStopAtPos(12, 16);
                    break;
                default:
                    return 13;
            }
            return 13;
        }

        private int jjStopStringLiteralDfa_0(int pos, long active0)
        {
            switch (pos)
            {
                default:
                    return -1;
            }
        }

        private int jjStartNfa_0(int pos, long active0)
        {
            return jjMoveNfa_0(jjStopStringLiteralDfa_0(pos, active0), pos + 1);
        }

        private int jjMoveStringLiteralDfa0_0()
        {
            switch ((int) curChar)
            {
                case 9:
                    return jjStartNfaWithStates_0(0, 3, 13);
                case 41:
                    return jjStopAtPos(0, 32);
                case 91:
                    return jjStopAtPos(0, 5);
                case 93:
                    return jjStopAtPos(0, 22);
                default:
                    return jjMoveNfa_0(0, 0);
            }
        }

        private int jjStartNfaWithStates_0(int pos, int kind, int state)
        {
            jjmatchedKind = kind;
            jjmatchedPos = pos;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return pos + 1;
            }
            return jjMoveNfa_0(state, pos + 1);
        }

        private static readonly long[] jjbitVec0 =
        {
            unchecked ((long) 0xfffffffffffffffeL), unchecked ((long) 0xffffffffffffffffL),
            unchecked ((long) 0xffffffffffffffffL), unchecked ((long) 0xffffffffffffffffL)
        };

        private static readonly long[] jjbitVec2 =
        {
            0x0L, 0x0L, unchecked ((long) 0xffffffffffffffffL), unchecked ((long) 0xffffffffffffffffL)
        };

        private int jjMoveNfa_0(int startState, int curPos)
        {
            int startsAt = 0;
            jjnewStateCnt = 58;
            int i = 1;
            jjstateSet[0] = startState;
            int kind = 0x7fffffff;
            for (;;)
            {
                if (++jjround == 0x7fffffff)
                    ReInitRounds();
                if (curChar < 64)
                {
                    var l = 1L << curChar;
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                                if ((unchecked((long) 0xfbfffcfeffffdbffL) & l) != 0L)
                                {
                                    if (kind > 30)
                                        kind = 30;
                                    {
                                        jjCheckNAdd(13);
                                    }
                                }
                                else if (curChar == 40)
                                {
                                    if (kind > 31)
                                        kind = 31;
                                    {
                                        jjCheckNAdd(15);
                                    }
                                }
                                if ((0x240000000000L & l) != 0L)
                                {
                                    if (kind > 25)
                                        kind = 25;
                                    {
                                        jjCheckNAdd(1);
                                    }
                                }
                                else if (curChar == 47)
                                {
                                    jjCheckNAddStates(0, 5);
                                }
                                else if (curChar == 35)
                                {
                                    jjAddStates(6, 7);
                                }
                                else if (curChar == 36)
                                {
                                    jjAddStates(8, 9);
                                }
                                else if (curChar == 62)
                                {
                                    jjCheckNAddTwoStates(3, 4);
                                }
                                if (curChar == 35)
                                {
                                    jjCheckNAdd(12);
                                }
                                break;
                            case 1:
                                if ((0x23ff240000000000L & l) == 0L)
                                    break;
                                if (kind > 25)
                                    kind = 25;
                            {
                                jjCheckNAdd(1);
                            }
                                break;
                            case 2:
                                if (curChar == 62)
                                {
                                    jjCheckNAddTwoStates(3, 4);
                                }
                                break;
                            case 3:
                                if (curChar == 45)
                                {
                                    jjCheckNAdd(4);
                                }
                                break;
                            case 4:
                                if ((0x3ff000000000000L & l) == 0L)
                                    break;
                                if (kind > 26)
                                    kind = 26;
                            {
                                jjCheckNAdd(4);
                            }
                                break;
                            case 6:
                                if ((unchecked((long) 0xffffffffffffdbffL) & l) != 0L)
                                {
                                    jjAddStates(10, 12);
                                }
                                break;
                            case 11:
                                if (curChar == 35)
                                {
                                    jjCheckNAdd(12);
                                }
                                break;
                            case 12:
                                if ((0x3ff000000000000L & l) == 0L)
                                    break;
                                if (kind > 29)
                                    kind = 29;
                            {
                                jjCheckNAdd(12);
                            }
                                break;
                            case 13:
                                if ((unchecked((long) 0xfbfffcfeffffdbffL) & l) == 0L)
                                    break;
                                if (kind > 30)
                                    kind = 30;
                            {
                                jjCheckNAdd(13);
                            }
                                break;
                            case 14:
                                if (curChar != 40)
                                    break;
                                if (kind > 31)
                                    kind = 31;
                            {
                                jjCheckNAdd(15);
                            }
                                break;
                            case 15:
                                if ((unchecked((long) 0xf3fffcfa00000000L) & l) == 0L)
                                    break;
                                if (kind > 31)
                                    kind = 31;
                            {
                                jjCheckNAdd(15);
                            }
                                break;
                            case 16:
                                if (curChar == 36)
                                {
                                    jjAddStates(8, 9);
                                }
                                break;
                            case 17:
                                if (curChar == 45 && kind > 26)
                                    kind = 26;
                                break;
                            case 18:
                                if (curChar == 43 && kind > 26)
                                    kind = 26;
                                break;
                            case 19:
                                if (curChar == 35)
                                {
                                    jjAddStates(6, 7);
                                }
                                break;
                            case 36:
                                if (curChar == 47)
                                {
                                    jjCheckNAddStates(0, 5);
                                }
                                break;
                            case 37:
                                if (curChar == 47)
                                {
                                    jjCheckNAddStates(13, 15);
                                }
                                break;
                            case 39:
                                if ((unchecked((long) 0xffffffffffffdbffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(13, 15);
                                }
                                break;
                            case 40:
                                if (curChar == 47)
                                {
                                    jjCheckNAddStates(16, 18);
                                }
                                break;
                            case 41:
                                if (curChar == 61)
                                {
                                    jjCheckNAdd(42);
                                }
                                break;
                            case 42:
                                if ((0x3ff000000000000L & l) == 0L)
                                    break;
                                if (kind > 24)
                                    kind = 24;
                            {
                                jjCheckNAddStates(19, 22);
                            }
                                break;
                            case 43:
                                if (curChar == 37)
                                {
                                    jjCheckNAdd(44);
                                }
                                break;
                            case 44:
                                if ((0x3ff000000000000L & l) == 0L)
                                    break;
                                if (kind > 24)
                                    kind = 24;
                            {
                                jjCheckNAddStates(23, 26);
                            }
                                break;
                            case 45:
                            case 49:
                                if (curChar == 47)
                                {
                                    jjCheckNAddStates(27, 29);
                                }
                                break;
                            case 46:
                                if ((unchecked((long) 0xffffffffffffdbffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(27, 29);
                                }
                                break;
                            case 47:
                                if (curChar != 47)
                                    break;
                                if (kind > 24)
                                    kind = 24;
                            {
                                jjCheckNAddStates(16, 18);
                            }
                                break;
                            case 52:
                                if ((unchecked((long) 0xffffffffffffdbffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(30, 32);
                                }
                                break;
                            case 53:
                                if (curChar == 47 && kind > 27)
                                    kind = 27;
                                break;
                            case 55:
                                if (curChar == 47)
                                {
                                    jjCheckNAddStates(30, 32);
                                }
                                break;
                            default:
                                break;
                        }
                    } while (i != startsAt);
                }
                else if (curChar < 128)
                {
                    //var l = 1L << (curChar & 077);
                    var l = 1L << (curChar%64);
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                                if ((unchecked((long) 0xffffffffd7ffffffL) & l) != 0L)
                                {
                                    if (kind > 30)
                                        kind = 30;
                                    {
                                        jjCheckNAdd(13);
                                    }
                                }
                                if ((0x7fffffe07fffffeL & l) != 0L)
                                {
                                    if (kind > 25)
                                        kind = 25;
                                    {
                                        jjCheckNAdd(1);
                                    }
                                }
                                else if (curChar == 124)
                                {
                                    jjCheckNAddStates(10, 12);
                                }
                                break;
                            case 1:
                                if ((0x17fffffe87ffffffL & l) == 0L)
                                    break;
                                if (kind > 25)
                                    kind = 25;
                            {
                                jjCheckNAdd(1);
                            }
                                break;
                            case 5:
                            case 9:
                                if (curChar == 124)
                                {
                                    jjCheckNAddStates(10, 12);
                                }
                                break;
                            case 6:
                                if ((unchecked((long) 0xefffffffefffffffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(10, 12);
                                }
                                break;
                            case 7:
                                if (curChar == 124 && kind > 28)
                                    kind = 28;
                                break;
                            case 8:
                                if (curChar == 92)
                                {
                                    jjAddStates(33, 34);
                                }
                                break;
                            case 10:
                                if (curChar == 92)
                                {
                                    jjCheckNAddStates(10, 12);
                                }
                                break;
                            case 13:
                                if ((unchecked((long) 0xffffffffd7ffffffL) & l) == 0L)
                                    break;
                                if (kind > 30)
                                    kind = 30;
                            {
                                jjCheckNAdd(13);
                            }
                                break;
                            case 15:
                                if ((0x7fffffffffffffffL & l) == 0L)
                                    break;
                                if (kind > 31)
                                    kind = 31;
                                jjstateSet[jjnewStateCnt++] = 15;
                                break;
                            case 20:
                                if (curChar == 116 && kind > 23)
                                    kind = 23;
                                break;
                            case 21:
                            case 29:
                                if (curChar == 115)
                                {
                                    jjCheckNAdd(20);
                                }
                                break;
                            case 22:
                                if (curChar == 111)
                                    jjstateSet[jjnewStateCnt++] = 21;
                                break;
                            case 23:
                                if (curChar == 109)
                                    jjstateSet[jjnewStateCnt++] = 22;
                                break;
                            case 24:
                                if (curChar == 116)
                                    jjstateSet[jjnewStateCnt++] = 23;
                                break;
                            case 25:
                                if (curChar == 104)
                                    jjstateSet[jjnewStateCnt++] = 24;
                                break;
                            case 26:
                                if (curChar == 103)
                                    jjstateSet[jjnewStateCnt++] = 25;
                                break;
                            case 27:
                                if (curChar == 105)
                                    jjstateSet[jjnewStateCnt++] = 26;
                                break;
                            case 28:
                                if (curChar == 114)
                                    jjstateSet[jjnewStateCnt++] = 27;
                                break;
                            case 30:
                                if (curChar == 111)
                                    jjstateSet[jjnewStateCnt++] = 29;
                                break;
                            case 31:
                                if (curChar == 109)
                                    jjstateSet[jjnewStateCnt++] = 30;
                                break;
                            case 32:
                                if (curChar == 116)
                                    jjstateSet[jjnewStateCnt++] = 31;
                                break;
                            case 33:
                                if (curChar == 102)
                                    jjstateSet[jjnewStateCnt++] = 32;
                                break;
                            case 34:
                                if (curChar == 101)
                                    jjstateSet[jjnewStateCnt++] = 33;
                                break;
                            case 35:
                                if (curChar == 108)
                                    jjstateSet[jjnewStateCnt++] = 34;
                                break;
                            case 38:
                                if (curChar == 92)
                                    jjstateSet[jjnewStateCnt++] = 37;
                                break;
                            case 39:
                            {
                                jjAddStates(13, 15);
                            }
                                break;
                            case 42:
                                if ((0x7fffffe87fffffeL & l) == 0L)
                                    break;
                                if (kind > 24)
                                    kind = 24;
                            {
                                jjCheckNAddStates(19, 22);
                            }
                                break;
                            case 44:
                                if ((0x7fffffe87fffffeL & l) == 0L)
                                    break;
                                if (kind > 24)
                                    kind = 24;
                            {
                                jjCheckNAddStates(23, 26);
                            }
                                break;
                            case 46:
                                if ((unchecked((long) 0xffffffffcfffffffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(27, 29);
                                }
                                break;
                            case 48:
                                if (curChar == 92)
                                {
                                    jjAddStates(35, 37);
                                }
                                break;
                            case 50:
                                if (curChar == 93)
                                {
                                    jjCheckNAddStates(27, 29);
                                }
                                break;
                            case 51:
                                if (curChar == 92)
                                {
                                    jjCheckNAddStates(27, 29);
                                }
                                break;
                            case 52:
                                if ((unchecked((long) 0xffffffffcfffffffL) & l) != 0L)
                                {
                                    jjCheckNAddStates(30, 32);
                                }
                                break;
                            case 54:
                                if (curChar == 92)
                                {
                                    jjAddStates(38, 40);
                                }
                                break;
                            case 56:
                                if (curChar == 93)
                                {
                                    jjCheckNAddStates(30, 32);
                                }
                                break;
                            case 57:
                                if (curChar == 92)
                                {
                                    jjCheckNAddStates(30, 32);
                                }
                                break;
                            default:
                                break;
                        }
                    } while (i != startsAt);
                }
                else
                {
                    int hiByte = (curChar >> 8);
                    int i1 = hiByte >> 6;
                    //long l1 = 1L << (hiByte & 077);
                    long l1 = 1L << (hiByte%64);
                    int i2 = (curChar & 0xff) >> 6;
                    //long l2 = 1L << (curChar & 077);
                    long l2 = 1L << (curChar%64);
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                            case 13:
                                if (!jjCanMove_0(hiByte, i1, i2, l1, l2))
                                    break;
                                if (kind > 30)
                                    kind = 30;
                            {
                                jjCheckNAdd(13);
                            }
                                break;
                            case 6:
                                if (jjCanMove_0(hiByte, i1, i2, l1, l2))
                                {
                                    jjAddStates(10, 12);
                                }
                                break;
                            case 39:
                                if (jjCanMove_0(hiByte, i1, i2, l1, l2))
                                {
                                    jjAddStates(13, 15);
                                }
                                break;
                            case 46:
                                if (jjCanMove_0(hiByte, i1, i2, l1, l2))
                                {
                                    jjAddStates(27, 29);
                                }
                                break;
                            case 52:
                                if (jjCanMove_0(hiByte, i1, i2, l1, l2))
                                {
                                    jjAddStates(30, 32);
                                }
                                break;
                            default:
                                if (i1 == 0 || l1 == 0 || i2 == 0 || l2 == 0) break;
                                else break;
                        }
                    } while (i != startsAt);
                }
                if (kind != 0x7fffffff)
                {
                    jjmatchedKind = kind;
                    jjmatchedPos = curPos;
                    kind = 0x7fffffff;
                }
                ++curPos;
                if ((i = jjnewStateCnt) == (startsAt = 58 - (jjnewStateCnt = startsAt)))
                    return curPos;
                try
                {
                    curChar = input_stream.readChar();
                }
                catch ( /*java.io.*/IOException e)
                {
                    return curPos;
                }
            }
        }

        private int jjStopStringLiteralDfa_1(int pos, long active0)
        {
            switch (pos)
            {
                default:
                    return -1;
            }
        }

        private int jjStartNfa_1(int pos, long active0)
        {
            return jjMoveNfa_1(jjStopStringLiteralDfa_1(pos, active0), pos + 1);
        }

        private int jjMoveStringLiteralDfa0_1()
        {
            switch ((int) curChar)
            {
                case 9:
                    return jjStartNfaWithStates_1(0, 3, 0);
                case 91:
                    return jjStopAtPos(0, 5);
                default:
                    return jjMoveNfa_1(0, 0);
            }
        }

        private int jjStartNfaWithStates_1(int pos, int kind, int state)
        {
            jjmatchedKind = kind;
            jjmatchedPos = pos;
            try
            {
                curChar = input_stream.readChar();
            }
            catch ( /*java.io.*/IOException e)
            {
                return pos + 1;
            }
            return jjMoveNfa_1(state, pos + 1);
        }

        private int jjMoveNfa_1(int startState, int curPos)
        {
            int startsAt = 0;
            jjnewStateCnt = 1;
            int i = 1;
            jjstateSet[0] = startState;
            int kind = 0x7fffffff;
            for (;;)
            {
                if (++jjround == 0x7fffffff)
                    ReInitRounds();
                if (curChar < 64)
                {
                    var l = 1L << curChar;
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                                if ((unchecked((long) 0xfbfffcfeffffdbffL) & l) == 0L)
                                    break;
                                kind = 21;
                                jjstateSet[jjnewStateCnt++] = 0;
                                break;
                            default:
                                break;
                        }
                    } while (i != startsAt);
                }
                else if (curChar < 128)
                {
                    //var l = 1L << (curChar & 077);
                    var l = 1L << (curChar%64);
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                                if ((unchecked ((long) 0xffffffffd7ffffffL) & l) == 0L)
                                    break;
                                kind = 21;
                                jjstateSet[jjnewStateCnt++] = 0;
                                break;
                            default:
                                break;
                        }
                    } while (i != startsAt);
                }
                else
                {
                    int hiByte = (curChar >> 8);
                    int i1 = hiByte >> 6;
                    //long l1 = 1L << (hiByte & 077);
                    long l1 = 1L << (hiByte%64);
                    int i2 = (curChar & 0xff) >> 6;
                    //long l2 = 1L << (curChar & 077);
                    long l2 = 1L << (curChar%64);
                    do
                    {
                        switch (jjstateSet[--i])
                        {
                            case 0:
                                if (!jjCanMove_0(hiByte, i1, i2, l1, l2))
                                    break;
                                if (kind > 21)
                                    kind = 21;
                                jjstateSet[jjnewStateCnt++] = 0;
                                break;
                            default:
                                if (i1 == 0 || l1 == 0 || i2 == 0 || l2 == 0) break;
                                else break;
                        }
                    } while (i != startsAt);
                }
                if (kind != 0x7fffffff)
                {
                    jjmatchedKind = kind;
                    jjmatchedPos = curPos;
                    kind = 0x7fffffff;
                }
                ++curPos;
                if ((i = jjnewStateCnt) == (startsAt = 1 - (jjnewStateCnt = startsAt)))
                    return curPos;
                try
                {
                    curChar = input_stream.readChar();
                }
                catch ( /*java.io.*/IOException e)
                {
                    return curPos;
                }
            }
        }

        private static readonly int[] jjnextStates =
        {
            38, 39, 40, 52, 53, 54, 28, 35, 17, 18, 6, 7, 8, 38, 39, 40,
            41, 43, 45, 41, 42, 43, 45, 41, 43, 44, 45, 46, 47, 48, 52, 53,
            54, 9, 10, 49, 50, 51, 55, 56, 57,
        };

        private static bool jjCanMove_0(int hiByte, int i1, int i2, long l1, long l2)
        {
            switch (hiByte)
            {
                case 0:
                    return ((jjbitVec2[i2] & l2) != 0L);
                default:
                    if ((jjbitVec0[i1] & l1) != 0L)
                        return true;
                    return false;
            }
        }

/** Token literal values. */

        /*public static readonly string[] jjstrLiteralImages =
        {
            "", null, null, null, null, "\x133", "\x151\x146", "\x156\x157\x164",
            "\x145\x170\x151\x163\x164\x163", "\x144\x145\x154\x145\x164\x145", "\x160\x162\x165\x156\x145",
            "\x162\x145\x154\x141\x142\x145\x154", "\x145\x170\x143\x151\x163\x145", "\x151\x156\x163\x145\x162\x164", "\x155\x157\x166\x145",
            "\x162\x145\x160\x154\x141\x143\x145", "\x143\x162\x145\x141\x164\x145\x123\x165\x142\x164\x162\x145\x145",
            "\x141\x144\x152\x157\x151\x156", "\x141\x144\x152\x157\x151\x156\x110", "\x141\x144\x152\x157\x151\x156\x106",
            "\x143\x157\x151\x156\x144\x145\x170", null, "\x135", null, null, null, null, null, null, null, null, null, "\x51",
        };*/

        public static readonly string[] jjstrLiteralImages =
        {
            "", null, null, null, null, "[", "if", "not",
            "exists", "delete", "prune",
            "relabel", "excise", "insert", "move",
            "replace", "createSubtree",
            "adjoin", "adjoinH", "adjoinF",
            "coindex", null, "]", null, null, null, null, null, null, null, null, null, ")",
        };

        protected Token jjFillToken()
        {
            Token t;
            string curTokenImage;
            int beginLine;
            int endLine;
            int beginColumn;
            int endColumn;
            string im = jjstrLiteralImages[jjmatchedKind];
            curTokenImage = (im == null) ? input_stream.GetImage() : im;
            beginLine = input_stream.getBeginLine();
            beginColumn = input_stream.getBeginColumn();
            endLine = input_stream.getEndLine();
            endColumn = input_stream.getEndColumn();
            t = Token.newToken(jjmatchedKind, curTokenImage);

            t.beginLine = beginLine;
            t.endLine = endLine;
            t.beginColumn = beginColumn;
            t.endColumn = endColumn;

            return t;
        }

/** Get the next Token. */

        public Token getNextToken()
        {
            Token matchedToken;
            int curPos = 0;

            //EOFLoop :
            for (;;)
            {
                beginning_eof_loop:
                {
                    try
                    {
                        curChar = input_stream.BeginToken();
                    }
                    catch ( /*java.io.*/Exception e)
                    {
                        if (e is IOException || e is ObjectDisposedException)
                        {
                            jjmatchedKind = 0;
                            jjmatchedPos = -1;
                            matchedToken = jjFillToken();
                            return matchedToken;
                        }
                        throw e;
                    }

                    switch (curLexState)
                    {
                        case 0:
                            try
                            {
                                input_stream.backup(0);
                                while (curChar <= 32 && (0x100002400L & (1L << curChar)) != 0L)
                                    curChar = input_stream.BeginToken();
                            }
                            catch ( /*java.io.*/IOException e1)
                            {
                                //continue EOFLoop;
                                goto beginning_eof_loop;
                            }
                            jjmatchedKind = 0x7fffffff;
                            jjmatchedPos = 0;
                            curPos = jjMoveStringLiteralDfa0_0();
                            break;
                        case 1:
                            try
                            {
                                input_stream.backup(0);
                                while (curChar <= 32 && (0x100002400L & (1L << curChar)) != 0L)
                                    curChar = input_stream.BeginToken();
                            }
                            catch ( /*java.io.*/IOException e1)
                            {
                                //continue EOFLoop;
                                goto beginning_eof_loop;
                            }
                            jjmatchedKind = 0x7fffffff;
                            jjmatchedPos = 0;
                            curPos = jjMoveStringLiteralDfa0_1();
                            break;
                        case 2:
                            try
                            {
                                input_stream.backup(0);
                                while (curChar <= 32 && (0x100002600L & (1L << curChar)) != 0L)
                                    curChar = input_stream.BeginToken();
                            }
                            catch ( /*java.io.*/IOException e1)
                            {
                                //continue EOFLoop;
                                goto beginning_eof_loop;
                            }
                            jjmatchedKind = 0x7fffffff;
                            jjmatchedPos = 0;
                            curPos = jjMoveStringLiteralDfa0_2();
                            break;
                    }
                    if (jjmatchedKind != 0x7fffffff)
                    {
                        if (jjmatchedPos + 1 < curPos)
                            input_stream.backup(curPos - jjmatchedPos - 1);
                        //if ((jjtoToken[jjmatchedKind >> 6] & (1L << (jjmatchedKind & 077))) != 0L)
                        if ((jjtoToken[jjmatchedKind >> 6] & (1L << (jjmatchedKind%64))) != 0L)
                        {
                            matchedToken = jjFillToken();
                            if (jjnewLexState[jjmatchedKind] != -1)
                                curLexState = jjnewLexState[jjmatchedKind];
                            return matchedToken;
                        }
                        else
                        {
                            if (jjnewLexState[jjmatchedKind] != -1)
                                curLexState = jjnewLexState[jjmatchedKind];
                            //continue EOFLoop;
                            goto beginning_eof_loop;
                        }
                    }
                    int error_line = input_stream.getEndLine();
                    int error_column = input_stream.getEndColumn();
                    string error_after = null;
                    bool EOFSeen = false;
                    try
                    {
                        input_stream.readChar();
                        input_stream.backup(1);
                    }
                    catch ( /*java.io.*/IOException e1)
                    {
                        EOFSeen = true;
                        error_after = curPos <= 1 ? "" : input_stream.GetImage();
                        if (curChar == '\n' || curChar == '\r')
                        {
                            error_line++;
                            error_column = 0;
                        }
                        else
                            error_column++;
                    }
                    if (!EOFSeen)
                    {
                        input_stream.backup(1);
                        error_after = curPos <= 1 ? "" : input_stream.GetImage();
                    }
                    throw new TokenMgrException(EOFSeen, curLexState, error_line, error_column, error_after, curChar,
                        TokenMgrException.LEXICAL_ERROR);
                }
            }
        }

        private void jjCheckNAdd(int state)
        {
            if (jjrounds[state] != jjround)
            {
                jjstateSet[jjnewStateCnt++] = state;
                jjrounds[state] = jjround;
            }
        }

        private void jjAddStates(int start, int end)
        {
            do
            {
                jjstateSet[jjnewStateCnt++] = jjnextStates[start];
            } while (start++ != end);
        }

        private void jjCheckNAddTwoStates(int state1, int state2)
        {
            jjCheckNAdd(state1);
            jjCheckNAdd(state2);
        }

        private void jjCheckNAddStates(int start, int end)
        {
            do
            {
                jjCheckNAdd(jjnextStates[start]);
            } while (start++ != end);
        }

        /** Constructor. */

        public TsurgeonParserTokenManager(SimpleCharStream stream)
        {

            if (SimpleCharStream.staticFlag)
                throw new Exception("ERROR: Cannot use a static CharStream class with a non-static lexical analyzer.");

            input_stream = stream;
        }

        /** Constructor. */

        public TsurgeonParserTokenManager(SimpleCharStream stream, int lexState)
        {
            ReInit(stream);
            SwitchTo(lexState);
        }

        /** Reinitialise parser. */

        public void ReInit(SimpleCharStream stream)
        {
            jjmatchedPos = jjnewStateCnt = 0;
            curLexState = defaultLexState;
            input_stream = stream;
            ReInitRounds();
        }

        private void ReInitRounds()
        {
            int i;
            jjround = 0x80000001;
            for (i = 58; i-- > 0;)
                jjrounds[i] = 0x80000000;
        }

        /** Reinitialise parser. */

        public void ReInit(SimpleCharStream stream, int lexState)
        {
            ReInit(stream);
            SwitchTo(lexState);
        }

        /** Switch to specified lex state. */

        public void SwitchTo(int lexState)
        {
            if (lexState >= 3 || lexState < 0)
                throw new TokenMgrException(
                    "Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.",
                    TokenMgrException.INVALID_LEXICAL_STATE);
            else
                curLexState = lexState;
        }

/** Lexer state names. */

        public static readonly string[] lexStateNames =
        {
            "OPERATION",
            "CONDITIONAL",
            "DEFAULT",
        };

/** Lex State array. */

        public static readonly int[] jjnewLexState =
        {
            -1, -1, -1, -1, -1, 2, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1,
        };

        private static readonly long[] jjtoToken =
        {
            0x1ffffffe1L,
        };

        private static readonly long[] jjtoSkip =
        {
            0x1eL,
        };

    }

}