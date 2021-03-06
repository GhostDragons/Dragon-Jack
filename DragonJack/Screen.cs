﻿namespace DragonJack
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;

    public class Screen
    {
        public static void SetWindow()
        {
            // Catch unhandled exception: System.ArgumentOutOfRangeException: 
            // The value must be less than the console's current maximum window size of 113 in that dimensio
            // Note that this value depends on screen resolution and the console font.
            Console.CursorVisible = false;
            Console.Title = "DRAGONJACK";

            try
            {
                Console.WindowHeight = GlobalConsts.winHeight;
                Console.WindowWidth = GlobalConsts.winWidth;
                Console.BufferHeight = GlobalConsts.winHeight;
                Console.BufferWidth = GlobalConsts.winWidth;
                Console.SetWindowSize(GlobalConsts.winWidth, GlobalConsts.winHeight);
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("\nPlease decrease the console font size.");
                Console.ReadKey(true);
                return;
            }
        }

        public static void IntroScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            string[] titleDragon = new string[9];
            string[,] letterDragon = new string[9, 10];
            letterDragon[0, 0] = "████████▄ ";
            letterDragon[1, 0] = "███   ▀███";
            letterDragon[2, 0] = "███    ███";
            letterDragon[3, 0] = "███    ███";
            letterDragon[4, 0] = "███    ███";
            letterDragon[5, 0] = "███    ███";
            letterDragon[6, 0] = "███   ▄███";
            letterDragon[7, 0] = "████████▀ ";
            letterDragon[8, 0] = "          ";
            letterDragon[0, 1] = "    ▄████████";
            letterDragon[1, 1] = "   ███    ███";
            letterDragon[2, 1] = "   ███    ███";
            letterDragon[3, 1] = "  ▄███▄▄▄▄██▀";
            letterDragon[4, 1] = " ▀▀███▀▀▀▀▀  ";
            letterDragon[5, 1] = " ▀███████████";
            letterDragon[6, 1] = "   ███    ███";
            letterDragon[7, 1] = "   ███    ███";
            letterDragon[8, 1] = "   ███    ███";
            letterDragon[0, 2] = "    ▄████████";
            letterDragon[1, 2] = "   ███    ███";
            letterDragon[2, 2] = "   ███    ███";
            letterDragon[3, 2] = "   ███    ███";
            letterDragon[4, 2] = " ▀███████████";
            letterDragon[5, 2] = "   ███    ███";
            letterDragon[6, 2] = "   ███    ███";
            letterDragon[7, 2] = "   ███    █▀ ";
            letterDragon[8, 2] = "             ";
            letterDragon[0, 3] = "    ▄██████▄ ";
            letterDragon[1, 3] = "   ███    ███";
            letterDragon[2, 3] = "   ███    █▀ ";
            letterDragon[3, 3] = "  ▄███       ";
            letterDragon[4, 3] = " ▀▀███ ████▄ ";
            letterDragon[5, 3] = "   ███    ███";
            letterDragon[6, 3] = "   ███    ███";
            letterDragon[7, 3] = "   ████████▀ ";
            letterDragon[8, 3] = "             ";
            letterDragon[0, 4] = "  ▄██████▄ ";
            letterDragon[1, 4] = " ███    ███";
            letterDragon[2, 4] = " ███    ███";
            letterDragon[3, 4] = " ███    ███";
            letterDragon[4, 4] = " ███    ███";
            letterDragon[5, 4] = " ███    ███";
            letterDragon[6, 4] = " ███    ███";
            letterDragon[7, 4] = "  ▀██████▀ ";
            letterDragon[8, 4] = "           ";
            letterDragon[0, 5] = " ███▄▄▄▄  ";
            letterDragon[1, 5] = " ███▀▀▀██▄";
            letterDragon[2, 5] = " ███   ███";
            letterDragon[3, 5] = " ███   ███";
            letterDragon[4, 5] = " ███   ███";
            letterDragon[5, 5] = " ███   ███";
            letterDragon[6, 5] = " ███   ███";
            letterDragon[7, 5] = "  ▀█   █▀ ";
            letterDragon[8, 5] = "          ";
            letterDragon[0, 6] = "      ▄█";
            letterDragon[1, 6] = "     ███";
            letterDragon[2, 6] = "     ███";
            letterDragon[3, 6] = "     ███";
            letterDragon[4, 6] = "     ███";
            letterDragon[5, 6] = "     ███";
            letterDragon[6, 6] = "     ███";
            letterDragon[7, 6] = " █▄ ▄███";
            letterDragon[8, 6] = " ▀▀▀▀▀▀ ";
            letterDragon[0, 7] = "    ▄████████";
            letterDragon[1, 7] = "   ███    ███";
            letterDragon[2, 7] = "   ███    ███";
            letterDragon[3, 7] = "   ███    ███";
            letterDragon[4, 7] = " ▀███████████";
            letterDragon[5, 7] = "   ███    ███";
            letterDragon[6, 7] = "   ███    ███";
            letterDragon[7, 7] = "   ███    █▀ ";
            letterDragon[8, 7] = "             ";
            letterDragon[0, 8] = "  ▄████████";
            letterDragon[1, 8] = " ███    ███";
            letterDragon[2, 8] = " ███    █▀ ";
            letterDragon[3, 8] = " ███       ";
            letterDragon[4, 8] = " ███       ";
            letterDragon[5, 8] = " ███    █▄ ";
            letterDragon[6, 8] = " ███    ███";
            letterDragon[7, 8] = " ████████▀ ";
            letterDragon[8, 8] = "           ";
            letterDragon[0, 9] = "    ▄█   ▄█▄";
            letterDragon[1, 9] = "   ███ ▄███▀";
            letterDragon[2, 9] = "   ███▐██▀  ";
            letterDragon[3, 9] = "  ▄█████▀   ";
            letterDragon[4, 9] = " ▀▀█████▄   ";
            letterDragon[5, 9] = "   ███▐██▄  ";
            letterDragon[6, 9] = "   ███ ▀███▄";
            letterDragon[7, 9] = "   ███   ▀█▀";
            letterDragon[8, 9] = "   ▀        ";

            int titleLength = Enumerable.Range(0, letterDragon.GetLength(1)).Sum(i => letterDragon[0, i].Length);
            int titlePos = (GlobalConsts.winWidth - titleLength) / 2;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 1 || i == 6 || i == 7)
                {
                    Thread.Sleep(700);
                }
                else
                {
                    Thread.Sleep(150);
                }
                for (int j = 0; j < 9; j++)
                {
                    Console.SetCursorPosition(titlePos, (GlobalConsts.winHeight - titleDragon.Length) / 2 + j);
                    Console.WriteLine(letterDragon[j, i]);
                }
                titlePos += letterDragon[0, i].Length;
                Sounds.PlaySound("swordSwoosh");
            }
            titlePos = (GlobalConsts.winWidth - titleLength) / 2;
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(400);

            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(titlePos, (GlobalConsts.winHeight - titleDragon.Length) / 2 + j);
                    Console.WriteLine(letterDragon[j, i]);
                    titlePos += letterDragon[0, i].Length;
                }
                titlePos = (GlobalConsts.winWidth - titleLength) / 2;
            }
            Sounds.PlaySound("swordClash");

            Console.SetCursorPosition((GlobalConsts.winWidth - "Press ENTER to continue".Length) / 2, (GlobalConsts.winHeight + letterDragon.GetLength(0) + 5) / 2);
            Thread.Sleep(500);
            Console.WriteLine("Press ENTER to continue");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Escape))
            {
                key = Console.ReadKey(true);
                
            }
            if (key.Key == ConsoleKey.Enter)
            {
                return;
            }
            else
            {
                Environment.Exit(0);
            }

        }

        public static void SetTable()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Printer.PrintDeck(GlobalConsts.winWidth - GlobalConsts.winWidth / GlobalConsts.cardWidth, (GlobalConsts.winHeight - 5) / 2);
            
        }

        public static string OutroScreen(float score, float lowestScore)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            string[] dragon1 = new string[39];
            dragon1[0] =  @"   █                              ";
            dragon1[1] =  @"   ██                             ";
            dragon1[2] =  @"   ▀██▄       ▀▀██▄               ";
            dragon1[3] =  @"    ▀███▄        ▀███▄            ";
            dragon1[4] =  @"      ▀████▄       ▀███▄          ";
            dragon1[5] =  @"        ▀██████▄     ▀███▄        ";
            dragon1[6] =  @"            ▀██████████████       ";
            dragon1[7] =  @"▄████▄    ▄█████████████▀███      ";
            dragon1[8] =  @"█▀  ▀██████████████████ ▐ ███     ";
            dragon1[9] =  @"▀     ██████████████████▄█████▄   ";
            dragon1[10] = @"    █████████████████████████████▄";
            dragon1[11] = @" ▄█████████████████████████████▄██";
            dragon1[12] = @"█████████████▀  ▀█████▄ █  █ ▀███▀";
            dragon1[13] = @"████████████▀    ▀██ ▀██▄     █ █ ";
            dragon1[14] = @"███████████       ▀██▄ ▀██▄       ";
            dragon1[15] = @"███████████        ▀██▄  ▀██▄     ";
            dragon1[16] = @"████████████        ▀███▄         ";
            dragon1[17] = @"█████████████         ▀███▄       ";
            dragon1[18] = @"███████████████                   ";
            dragon1[19] = @" █████████████████                ";
            dragon1[20] = @"  ███████████████████             ";
            dragon1[21] = @"   ████████████████████           ";
            dragon1[22] = @"    █████████████████████         ";
            dragon1[23] = @"     ██████████████████████       ";
            dragon1[24] = @"      ██████████████████████      ";
            dragon1[25] = @"       ██████████████████████     ";
            dragon1[26] = @"        ██████████████████████    ";
            dragon1[27] = @"        ██████████████████████    ";
            dragon1[28] = @"        ██████████████████████    ";
            dragon1[29] = @"        ██████████████████████    ";
            dragon1[30] = @"       ███████████████████████    ";
            dragon1[31] = @"      ███████████████████████     ";
            dragon1[32] = @"     ███████████████████████      ";
            dragon1[33] = @"    ███████████████████████       ";
            dragon1[34] = @"   ███████████████████████        ";
            dragon1[35] = @"  ███████████████████████         ";
            dragon1[36] = @" ███████████████████████          ";
            dragon1[37] = @"███████████████████████           ";
            dragon1[38] = @"██████████████████████            ";

            string[] dragon2 = new string[39];
            for (int i = 0; i < dragon1.Length; i++)
            {
                char[] chars = dragon1[i].ToCharArray();
                Array.Reverse(chars);
                dragon2[i] = new string(chars);
                Console.SetCursorPosition(0, i);
                Console.Write(dragon1[i]);
                Console.SetCursorPosition(GlobalConsts.winWidth - dragon2[0].Length, i);
                Console.Write(dragon2[i]);
            }

            string name = "";
            if (score > lowestScore)
            {
                Console.SetCursorPosition((GlobalConsts.winWidth - "Input your initials (max 6 characters):".Length) / 2, 4);
                Console.Write("Input your initials (max 6 characters): ");
                while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length > 6)
                {
                    Console.SetCursorPosition((GlobalConsts.winWidth + "Input your initials (max 6 characters): ".Length) / 2, 4);
                    Console.Write("".PadRight(name.Length + name.Length, ' '));
                    Console.SetCursorPosition((GlobalConsts.winWidth + "Input your initials (max 6 characters): ".Length) / 2, 4);
                    name = Console.ReadLine();
                }
                Console.SetCursorPosition((GlobalConsts.winWidth - "Input your initials (max 6 characters): ".Length) / 2, 4);
                Console.Write("".PadRight("Input your initials (max 6 characters): ".Length + name.Length, ' '));
            }

            return name;
        }

    }
}
