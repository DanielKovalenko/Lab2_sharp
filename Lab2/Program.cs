using System;
using System.Collections.Generic;
using System.Linq;
using Lab2.View;
using System.Windows.Forms;

namespace Lab2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static MainForm f1;
        public static RoomForm f2;
        public static int a, b = 0;
        public static int Instr = 0;
        public static int Worker = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
