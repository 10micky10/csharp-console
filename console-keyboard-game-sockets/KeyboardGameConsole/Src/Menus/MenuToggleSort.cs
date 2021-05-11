﻿using System;

namespace KeyboardGameConsole.Src.Menus
{
    internal class MenuToggleSort
    {
        private MenuToggleSort()
        {
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1.- Normal Key.");
            Console.WriteLine("2.- Special Key.");
            Console.WriteLine("3.- Function Key.");
            Console.WriteLine("\n(Ctrl + Q) To return");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Select a option...");
        }
    }
}
