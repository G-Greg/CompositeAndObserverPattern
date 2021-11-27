using System;

namespace Fájlrendszer_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //mappák létrehozása
            Folder folder0 = new Folder("C:", new DateTime(2000, 7, 24));

            Folder folder = new Folder("SCHOOL", new DateTime(2021, 1, 4));
            Folder folder2 = new Folder("SZTT", new DateTime(2021, 5, 7));
            Folder folder3 = new Folder("ADATKEZ", new DateTime(2021, 9, 4));
            Folder folder4 = new Folder("GAMES", new DateTime(2021, 11, 9));

            //fájlok létrehozása
            File file1 = new File("vizsga.png", 246, new DateTime(2021, 7, 24));
            File file2 = new File("gajdos_jegyzet.pdf", 246, new DateTime(2021, 7, 24));
            File file3 = new File("sql_jegyzet.txt", 35, new DateTime(2021, 8, 4));
            File file4 = new File("sztt_jegyzet.txt", 76, new DateTime(2021, 11, 1));
            File file5 = new File("Rainbow Six Siege.exe", 14376, new DateTime(2021, 5, 22));
            File file6 = new File("Battlefield 1.exe", 23476, new DateTime(2021, 7, 23));
            File file7 = new File("Fallout Shelter.exe", 52341, new DateTime(2021, 1, 4));
            File file8 = new File("PUBG.exe", 12344, new DateTime(2021, 5, 25));

            //rendezés
            folder0.addItemToDirectory(folder);
            folder0.addItemToDirectory(folder4);

            folder.addItemToDirectory(folder2);
            folder.addItemToDirectory(folder3);
            folder.addItemToDirectory(file1);

            folder2.addItemToDirectory(file4);
            
            folder3.addItemToDirectory(file2);
            folder3.addItemToDirectory(file3);
            
            folder4.addItemToDirectory(file5);
            folder4.addItemToDirectory(file6);
            folder4.addItemToDirectory(file7);
            folder4.addItemToDirectory(file8);
            
            
            //listázás
            getDataAll(folder0);

            //mappa törlése
            folder0.deleteItemFromDirectory(folder4);
            Console.WriteLine("\nGAMES mappa törlése után\n");
            getDataAll(folder0);

            Console.WriteLine("");
        }

        //összes könyvtár és fájlok adatai kiírása
        public static void getDataAll(Folder directories)
        {
            Console.WriteLine("FolderType | Name | Size | CreationDate");
            foreach (var item in directories.GetDirectories())
            {
                item.getData();
            }
        }
    }
}
