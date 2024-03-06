# Algorytm Dziel i zwyciê¿aj na przyk³adzie problemu *Lochy*

W pewnym pañstwie rz¹dzi³ dobry i sprawiedliwy król. Uczciwych ludzi nagradza³, natomiast z³ych kara³. Najsurowsz¹ kar¹ by³o wtr¹cenie do wiêzienia. Nie by³o to jednak zwyk³e wiêzienie, lecz wykute w ska³ach, podziemne lochy z komorami dla skazanych. Ka¿da cela ma kwadratow¹ pod³ogê (o powierzchni 1 m2) i sufit po³o¿ony 5 metrów wy¿ej, jednak nie ma œcian. Wiêzienie mo¿na przedstawiæ jako prostok¹t o rozmiarze n na m, który posiada n*m komór. Wiêzienie jest ograniczone z 4 stron ska³ami, w których zosta³o wykute (dotyczy to cel po³o¿onych na brzegach). Co wiêcej, komory mog¹ byæ wykute na ró¿nej g³êbokoœci. W zwi¹zku z brakiem œcian, komory mog¹ nie byæ od siebie odseparowane: jeœli dwie s¹siednie cele s¹ wykute na tej samej lub podobnej g³êbokoœci (pod³oga jednej z komór powy¿ej pod³ogi drugiej komory, ale poni¿ej jej sufitu), to miêdzy nimi istnieje fragment wolnej przestrzeni. W przeciwnym razie, gdy g³êbokoœci dwóch s¹siednich cel znacznie siê ró¿ni¹, s¹ one od siebie odseparowane ska³ami, w których zosta³y wydr¹¿one. W jednej z cel odbywa wyrok pewien s³ynny rozbójnik. Ju¿ w momencie skazania rozmyœla³ on nad planem ucieczki. Mieli mu w tym pomóc jego kompani, którzy byli na wolnoœci i uciekali skuteczniej od rêki sprawiedliwoœci. Plan zak³ada³ przekopanie siê pod ziemi¹. Wszystko by³o dopiête na ostatni guzik... Niestety w dniu planowanej akcji okolicê nawiedzi³o silne trzêsienie ziemi. Zmodyfikowa³o ono przep³yw wód podziemnych. Rozbójnik zauwa¿y³, ¿e ze skalnej pod³ogi w jego celi zaczyna wyp³ywaæ woda. On, skrêpowany, nie bêdzie w stanie nawet p³ywaæ i mo¿e uton¹æ, gdy poziom wody w jego komorze osi¹gnie metr! B³yskawicznie oceni³ tempo z jakim woda wp³ywa do lochu. Za ile czasu utonie? Wiadomo, ¿e wszystkie cele (z wyj¹tkiem le¿¹cych na brzegach lochu) maj¹ po osiem s¹siednich cel (cztery po bokach i cztery na skosach). Woda zawsze d¹¿y do wyrównania swego poziomu w komorach, w których wystêpuje (chyba, ¿e ogranicza j¹ sufit). Wiadomo, ¿e natychmiast sp³ywa ona z danej komory do ni¿ej po³o¿onych s¹siednich komór jeœli jej pod³oga le¿y ni¿ej ni¿ sufit s¹siednich cel. Woda mo¿e równie¿ przelewaæ siê z danej celi do s¹siednich wy¿ej po³o¿onych komór, je¿eli poziom wody w danej komorze wystarczaj¹co siê podniesie (powy¿ej pod³ogi s¹siednich cel). Gdy s¹siednie komory le¿¹ na takiej samej wysokoœci, to bêd¹ one wype³niaæ siê wod¹ tak samo szybko. Napisz program, który oceni ile wody musi nap³yn¹æ, by rozbójnik uton¹³.

## Wejœcie:
W pierwszej linii zestawu danych podane s¹ liczby `n` i `m` `(1 <=n, m<=200)` oznaczaj¹ce wymiary prostok¹tnego wiêzienia. W kolejnych `n` wierszach podane jest po `m` liczb ca³kowitych oddzielonych spacjami i oznaczaj¹cych g³êbokoœæ pod ziemi¹ danej komory (a dok³adnie po³o¿enie jej sufitu). G³êbokoœæ przedstawiona w metrach jest liczb¹ ca³kowit¹ nale¿¹c¹ do przedzia³u `<1, 1000>`. W ostatnim wierszu znajduj¹ siê dwie liczby ca³kowite `i` oraz `j` `(1 <= i<=n, 1<=j<=m)` oznaczaj¹ce po³o¿enie komory rozbójnika (`i` - numer wiersza, `j` - numer kolumny).

## Wyjœcie:
Na wyjœciu ma siê pojawiæ liczba ca³kowita oznaczaj¹ca iloœæ wody (w $m^3$), której nap³yniêcie spowoduje utoniêcie rozbójnika.

## Przyk³ad:
### Wejœcie:

``` c#
4 4	//wymiary wiêzienia
8 8 5 5
9 8 3 3 
2 2 2 2 
2 2 2 2 
1 1
```

### Wyjœcie:
```c#
5
```