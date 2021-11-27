using System;
using System.Collections.Generic;
using System.Text;

namespace Fájlrendszer_Composite
{
    class File : IDirectory
    {
        private string name;
        private int meret;
        private DateTime creationDate;

        public File(string name, int meret, DateTime creationDate)
        {
            this.name = name;
            this.meret = meret;
            this.creationDate = creationDate;
        }

        #region alaműveletek
        public DateTime getCreationDate() => creationDate;

        public string getName() => name;

        public int getSize() => meret;
        #endregion

        //File adatai kiírása
        public void getData()
        {
            Console.WriteLine($"Folder  {getName()}  {getSize()} KB  {getCreationDate().ToShortDateString()}");
        }

    }
}
