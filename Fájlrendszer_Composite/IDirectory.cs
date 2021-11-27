using System;
using System.Collections.Generic;
using System.Text;

namespace Fájlrendszer_Composite
{
    interface IDirectory
    {
        string getName();
        int getSize();
        DateTime getCreationDate();

        void getData();
    }
}
