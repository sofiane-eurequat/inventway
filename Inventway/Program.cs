using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using FileHelpers;

namespace Inventway
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static  DBInventory[] inventaireRacine;
        public static InventoryData inventaireEnCours;

        [MTAThread]
        static void Main()
        {

            Application.Run(new Menu());

        }
    }
}