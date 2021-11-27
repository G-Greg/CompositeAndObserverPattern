# Composite And Observer Pattern
**FÁJLRENDSZER**

Készítsen  egy  fájlrendszerbeli  könyvtár-és  fájlstruktúra  reprezentálására  alkalmas  osztálystruktúrát C# vagy Java nyelven. Ennek során vezesse be a File és Folder osztályokat. A fájlok vonatkozásában a fájl nevét,méretét, és létrehozási dátumátkell nyilvántartani(tagváltozóban), a könyvtáraknálcsak anevétés létrehozási dátumát.

# Composite 
A Compositeminta segítségével oldja meg a következőket:

- Egykönyvtárhierarchia memóriabeli reprezentálása

- A név,a méret, és a létrehozási dátumegységes formában legyen lekérdezhető a fájlokra és a könyvtárakra   vonatkozóan!   A   könyvtárak   esetében   a   méret   a   könyvtárakban   és   az alkönyvtárakban  rekurzívan  levő  valamennyi  fájlt  méretének  összegét  adja  vissza.  Fontos:  a könyvtárak nem tárolhatják a méretet, azt minden lekérdezés során ki kell frissen számolni.

- A  könyvtárhoz  vezessen  be  egy  közös  műveletet  fájl/könyvtár  felvételére  (paraméter  egy  fájl vagy könyvtár objektum).
- A könyvtárhoz vezessen be egy közös műveletet adott fájl/könyvtár eltávolítására (paraméter egy fájl vagy könyvtár objektum).

- Írjon  egy műveletet, mely egy  könyvtárra  vonatkozóan  kilistázza  az  adatait, majd  a  tartalmát, minden  alkönyvtárával,  rekurzívan.  Minden  könyvtár/fájl  információ  új  sorban  jelenjen  meg, minden sorban a következő mezőkkel, az egyes mezők 2 darabszóközzel elválasztva:
  - "Directory" vagy "File" sztring,attól függően, hogy az adott elem könyvtár vagy fájl
  - Adott fájl/könyvtár neve
  - Adott fájl/könyvtár mérete
  - Adott fájl/könyvtár létrehozási dátuma
  
- A  megjelenítés  során  elég  az  egyszerű  lista,  nem  szükséges  behúzással  vagy  egyéb  módon  a hierarchiát vizualizálni.
- A    megjelenítés    során    tesztadatokkal    illusztrálja    a   megoldásának   működőképességét.
- Megoldásában  NEM szükséges  valódi  fájlrendszerbeli  könyvtárakkal  és  fájlokkal  dolgoznia: egyszerűen  olyan  tesztadatokkal  inicializálja  az  adatstruktúráit,  melyekkel  a  működés  jól demonstrálható.oMegoldásában nem szükséges semmilyen adatot fájlba menteni, vagy onnan betölteni.

# Observer
Vezessen be a könyvtárakra vonatkozóan műveleteket fájl/könyvtár könyvtárba való felvételéhez
és törlésére (ennek megoldása során szabadon dönthet a paraméterezésről). Az Observer minta
segítségével oldja meg a következőket:

- Az egyes könyvtárak változásaira (amikor fájlt vagy könyvtárat vesznek fel bele, vagy törölnek
belőle) fel lehessen iratkozni. Az alkönyvtárak változása nem számít az adott könyvtár
vonatkozásában változásnak.

- Mutasson is példát két eltérő típusú feliratkozóra:
  - Az egyik egy könyvtár megváltozásakor a konzolra vesszővel elválasztva írja ki a könyvtárban
levő fájlok és könyvtárak nevét és létrehozási dátumát (az almappákat nem kell bejárni és
kiírni).
  - Egy másik pedig írja ki a konzolra a könyvtár tartalmának méretét (a méretbe beleszámítva
az összes alkönyvtárát, teljes mélységben).

Tipp: ahhoz, hogy ezeket meg lehessen oldani, az értesítés során át kell adni a megváltozott
könyvtár objektumot a feliratkozónak.
- Tesztadatok segítségével illusztrálja megoldásának működését. Megoldásában NEM szükséges
valódi fájlrendszerbeli könyvtárakkal és fájlokkal dolgoznia: egyszerűen olyan tesztadatokkal
inicializálja az adatstruktúráit, melyekkel a működés jól demonstrálható
