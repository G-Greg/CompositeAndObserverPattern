using System;
using System.Collections.Generic;

namespace Fájlrendszer_Observer
{
    /// <summary>
    /// A Folder leszármaztatott osztály tárolja a könyvtár tartalmait és állapotait,
    /// értesíti a beregisztrált Observer-eket, amikor az állapota megváltozott.
    /// </summary>
    public class Folder : Document
    {
        private string name;
        private DateTime creationDate;
        private List<Document> directories = new List<Document>();

        public void SetData(string name, DateTime creationDate, Folder folder)
        {
            this.name = name;
            this.creationDate = creationDate;
            if (this != folder)
                folder.directories.Add(this);
            UpdateAllViews(folder);
        }

        //Document osztály metódusai felüldefiniálása
        public override string getName() => name;

        public override DateTime getCreationDate() => creationDate;

        public override List<Document> getDirectory() => directories;

        public override int getSize()
        {
            int meret = 0;

            //rekurzív méret számolás
            foreach (var item in directories)
            {
                meret += item.getSize();
            }
            return meret;
        }
        
        //Fájl vagy könyvtár felvétele
        public void addItemToDirectory(Document item)
        {
            directories.Add(item);
        }
        //Fájl vagy könyvtár eltávolítása
        public void deleteItemFromDirectory(Document item)
        {
            directories.Remove(item);
        }
    }
}
