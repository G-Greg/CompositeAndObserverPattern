using System;
using System.Threading;

namespace Fájlrendszer_Observer
{
    /// <summary>
    /// A dokumentum a méretének a megjelenését reprezentálja
    /// </summary>
    class DirectorySizeView : IDirectoryView
    {
        private Document folder;

        public void Update(Document directory)
        {
            folder = directory;
            ShowData();
        }

        public void ShowData()
        {
            int cursorTop = Console.CursorTop+1;
            string szoveg1 = $"{folder.getSize()} KB ";
            for (int i = 0; i < szoveg1.Length; i++)
            {
                Console.SetCursorPosition(0, cursorTop);
                Console.WriteLine(szoveg1.Substring(0, i));
                Thread.Sleep(100);
            }

            int cursorLeft = Console.CursorLeft + 24;
            for (int i = 0; i < folder.getDirectory().Count; i++)
            {
                string szoveg = $"{folder.getDirectory()[i].getSize()} KB ";
                for (int j = 0; j < szoveg.Length; j++)
                {
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine(szoveg.Substring(0, j));
                    Thread.Sleep(100);
                }
                cursorLeft += 24;
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
