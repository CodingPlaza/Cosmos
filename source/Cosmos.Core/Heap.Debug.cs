﻿using System;

namespace Cosmos.Core
{
    partial class Heap
    {
        public static bool EnableDebug = true;
        private static void Debug(string message)
        {
            if (!EnableDebug)
            {
                return;
            }
            Console.Write("Heap: ");
            Console.WriteLine(message);
        }

        private static void DebugHex(string message, uint value, byte bits)
        {
            if (!EnableDebug)
            {
                return;
            }
            Console.Write("Heap: ");
            Console.Write(message);
            WriteNumberHex(value, bits);
            Console.WriteLine();
        }

        private static void WriteNumberHex(uint aValue, byte aBitCount)
        {
            uint xValue = aValue;
            byte xCurrentBits = aBitCount;
            Console.Write("0x");
            while (xCurrentBits >= 4)
            {
                xCurrentBits -= 4;
                byte xCurrentDigit = (byte)((xValue >> xCurrentBits) & 0xF);
                string xDigitString = null;
                switch (xCurrentDigit)
                {
                    case 0:
                        xDigitString = "0";
                        goto default;
                    case 1:
                        xDigitString = "1";
                        goto default;
                    case 2:
                        xDigitString = "2";
                        goto default;
                    case 3:
                        xDigitString = "3";
                        goto default;
                    case 4:
                        xDigitString = "4";
                        goto default;
                    case 5:
                        xDigitString = "5";
                        goto default;
                    case 6:
                        xDigitString = "6";
                        goto default;
                    case 7:
                        xDigitString = "7";
                        goto default;
                    case 8:
                        xDigitString = "8";
                        goto default;
                    case 9:
                        xDigitString = "9";
                        goto default;
                    case 10:
                        xDigitString = "A";
                        goto default;
                    case 11:
                        xDigitString = "B";
                        goto default;
                    case 12:
                        xDigitString = "C";
                        goto default;
                    case 13:
                        xDigitString = "D";
                        goto default;
                    case 14:
                        xDigitString = "E";
                        goto default;
                    case 15:
                        xDigitString = "F";
                        goto default;
                    default:
                        Console.Write(xDigitString);
                        break;
                }
            }
        }

        private static void DebugAndHalt(string message)
        {
            Debug(message);
            while (true)
                ;
        }
    }
}