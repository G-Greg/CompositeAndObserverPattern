using System;
using System.Collections.Generic;


namespace Fájlrendszer_Observer
{
    /// <summary>
    /// A dokumentum a tartalmának a megjelenését reprezentálja
    /// </summary>
    class DirectoryContentView : IDirectoryView
    {
        private Document folder;

        public void Update(Document directory)
        {
            folder = directory;
            ShowData();
        }

        public void ShowData()
        {
            Console.Write($"{folder.getName()}, {folder.getCreationDate().ToShortDateString()}\t");
            foreach (var item in folder.getDirectory())
            {
                Console.Write($"{item.getName()}, {item.getCreationDate().ToShortDateString()}\t");
            }
        }
    }
}
