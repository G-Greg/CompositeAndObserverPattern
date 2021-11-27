using System;
using System.Collections.Generic;

namespace Fájlrendszer_Observer
{
    /// <summary>
    /// A File leszármaztatott osztály tárolja a fájl állapotait,
    /// értesíti a beregisztrált Observer-eket, amikor az állapota megváltozott.
    /// </summary>
    class File : Document
    {
        private string name;
        private int meret;
        private DateTime creationDate;

        public void SetData(string name, int meret, DateTime creationDate, Folder folder)
        {
            this.name = name;
            this.meret = meret;
            this.creationDate = creationDate;
            folder.addItemToDirectory(this);

            UpdateAllViews(folder);
        }


        //Document osztály metódusai felüldefiniálása
        public override string getName() => name;
        
        public override int getSize() => meret;
        
        public override DateTime getCreationDate() => creationDate;

        public override List<Document> getDirectory() => null;
    }
}
