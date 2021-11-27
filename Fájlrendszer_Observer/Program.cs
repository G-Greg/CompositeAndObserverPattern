using System;
using System.Threading;

namespace Fájlrendszer_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dokumentum létrehozása
            Folder folder = new Folder();
            Folder folder2 = new Folder();
            File file1 = new File();
            File file2 = new File();
            File file3 = new File();


            //Néztek létrehozása
            var directoryContentView = new DirectoryContentView();
            var directorySizeView = new DirectorySizeView();

            //Nézetek feliratkoztatása
            folder.AttachView(directoryContentView);
            folder.AttachView(directorySizeView);
            folder2.AttachView(directoryContentView);
            folder2.AttachView(directorySizeView);


            //Adatmódosítások
            Console.WriteLine("Mappa létrehozása");
            folder.SetData("GAMES", new DateTime(2021, 11, 9), folder);
            Thread.Sleep(2000);

            Console.WriteLine("Mappa hozzáadása");
            folder2.SetData("SteamG", new DateTime(2021, 5, 15), folder);
            Thread.Sleep(2000);

            Console.WriteLine("Fájl hozzáadása a SteamG mappába");
            file3.SetData("Fallout Shelter", 9478, new DateTime(2021, 2, 19), folder2);
            Thread.Sleep(2000);

            Console.WriteLine("Fájl hozzáadása a GAMES mappába");
            file1.SetData("Battlefield 1.exe", 24576, new DateTime(2021, 4, 23), folder);
            Thread.Sleep(2000);
            
            //SizeView leválasztása, így fog Update-elni változáskor
            folder.DetachView(directorySizeView);

            Console.WriteLine("Fájl hozzáadása a GAMES mappába -> hibás mérettel");
            file2.SetData("Apex Legends", 13478, new DateTime(2021, 7, 30), folder);
            Console.WriteLine("");
        }
    }
}
