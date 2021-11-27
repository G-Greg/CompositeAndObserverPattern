using System;
using System.Collections.Generic;
using System.Text;

namespace Fájlrendszer_Observer
{
    /// <summary>
    /// Tárolja a beregisztrált Observer-eket
    /// </summary>
    public abstract class Document
    {
        //Különböző nézetek egybegyűjtése
        private List<IDirectoryView> directoryViews = new List<IDirectoryView>();

        //Nézet feliratkoztatása 
        public void AttachView(IDirectoryView view) 
        {
            directoryViews.Add(view);
        }

        //Nézet leiratkoztatása
        public void DetachView(IDirectoryView view)
        {
            directoryViews.Remove(view);
        }

        //Összes nézetnek szól a frissít tényéről
        protected void UpdateAllViews(Document directories)
        {
            foreach (var view in directories.directoryViews)
            {
                view.Update(directories);
            }
        }


        //Műveletek a leszármazott osztályoknak
        public abstract int getSize();
        public abstract string getName();
        public abstract DateTime getCreationDate();
        public abstract List<Document> getDirectory();

    }
}
