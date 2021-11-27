using System;
using System.Collections.Generic;
using System.Text;

namespace Fájlrendszer_Observer
{
    public interface IDirectoryView
    {
        void Update(Document folder);
    }
}
