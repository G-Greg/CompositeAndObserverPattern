using System;
using System.Collections.Generic;
using System.Text;

namespace Fájlrendszer_Composite
{
    class Folder : IDirectory
    {
        private string name;
        private DateTime creationDate;

        //listában az IDirectoryk
        private List<IDirectory> directories = new List<IDirectory>();
       
        public Folder(string name, DateTime creationDate)
        {
            this.name = name;
            this.creationDate = creationDate;
        }
       
        #region alapműveletek
        public DateTime getCreationDate() => creationDate;

        public string getName() => name;


        //Folder aktuális mérete frissen kiszámítva
        public int getSize()
        {
            int meret = 0;

            //rekurzív méret számolás
            foreach (var item in directories)
            {
                meret += item.getSize();
            }
            return meret;
        }
        #endregion

        //fájl vagy könyvtár felvétele
        public void addItemToDirectory(IDirectory item)
        {
            directories.Add(item);
        }
        //fájl vagy könyvtár eltávolítása
        public void deleteItemFromDirectory(IDirectory item)
        {
            directories.Remove(item);
        }

        //könyvtár lekérdezése
        public List<IDirectory> GetDirectories()
        {
            return directories;
        }

        //Folder adatai kiírása
        public void getData()
        {
            Console.WriteLine($"Directory  {getName()}  {getSize()} KB  {getCreationDate().ToShortDateString()}");
            foreach (var item in GetDirectories())
            {
                item.getData();
            }

        }
    }
}
