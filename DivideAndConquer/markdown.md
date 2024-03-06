# Algorytm Dziel i zwyci�aj na przyk�adzie problemu *Lochy*

W pewnym pa�stwie rz�dzi� dobry i sprawiedliwy kr�l. Uczciwych ludzi nagradza�, natomiast z�ych kara�. Najsurowsz� kar� by�o wtr�cenie do wi�zienia. Nie by�o to jednak zwyk�e wi�zienie, lecz wykute w ska�ach, podziemne lochy z komorami dla skazanych. Ka�da cela ma kwadratow� pod�og� (o powierzchni 1 m2) i sufit po�o�ony 5 metr�w wy�ej, jednak nie ma �cian. Wi�zienie mo�na przedstawi� jako prostok�t o rozmiarze n na m, kt�ry posiada n*m kom�r. Wi�zienie jest ograniczone z 4 stron ska�ami, w kt�rych zosta�o wykute (dotyczy to cel po�o�onych na brzegach). Co wi�cej, komory mog� by� wykute na r�nej g��boko�ci. W zwi�zku z brakiem �cian, komory mog� nie by� od siebie odseparowane: je�li dwie s�siednie cele s� wykute na tej samej lub podobnej g��boko�ci (pod�oga jednej z kom�r powy�ej pod�ogi drugiej komory, ale poni�ej jej sufitu), to mi�dzy nimi istnieje fragment wolnej przestrzeni. W przeciwnym razie, gdy g��boko�ci dw�ch s�siednich cel znacznie si� r�ni�, s� one od siebie odseparowane ska�ami, w kt�rych zosta�y wydr��one. W jednej z cel odbywa wyrok pewien s�ynny rozb�jnik. Ju� w momencie skazania rozmy�la� on nad planem ucieczki. Mieli mu w tym pom�c jego kompani, kt�rzy byli na wolno�ci i uciekali skuteczniej od r�ki sprawiedliwo�ci. Plan zak�ada� przekopanie si� pod ziemi�. Wszystko by�o dopi�te na ostatni guzik... Niestety w dniu planowanej akcji okolic� nawiedzi�o silne trz�sienie ziemi. Zmodyfikowa�o ono przep�yw w�d podziemnych. Rozb�jnik zauwa�y�, �e ze skalnej pod�ogi w jego celi zaczyna wyp�ywa� woda. On, skr�powany, nie b�dzie w stanie nawet p�ywa� i mo�e uton��, gdy poziom wody w jego komorze osi�gnie metr! B�yskawicznie oceni� tempo z jakim woda wp�ywa do lochu. Za ile czasu utonie? Wiadomo, �e wszystkie cele (z wyj�tkiem le��cych na brzegach lochu) maj� po osiem s�siednich cel (cztery po bokach i cztery na skosach). Woda zawsze d��y do wyr�wnania swego poziomu w komorach, w kt�rych wyst�puje (chyba, �e ogranicza j� sufit). Wiadomo, �e natychmiast sp�ywa ona z danej komory do ni�ej po�o�onych s�siednich kom�r je�li jej pod�oga le�y ni�ej ni� sufit s�siednich cel. Woda mo�e r�wnie� przelewa� si� z danej celi do s�siednich wy�ej po�o�onych kom�r, je�eli poziom wody w danej komorze wystarczaj�co si� podniesie (powy�ej pod�ogi s�siednich cel). Gdy s�siednie komory le�� na takiej samej wysoko�ci, to b�d� one wype�nia� si� wod� tak samo szybko. Napisz program, kt�ry oceni ile wody musi nap�yn��, by rozb�jnik uton��.

## Wej�cie:
W pierwszej linii zestawu danych podane s� liczby `n` i `m` `(1 <=n, m<=200)` oznaczaj�ce wymiary prostok�tnego wi�zienia. W kolejnych `n` wierszach podane jest po `m` liczb ca�kowitych oddzielonych spacjami i oznaczaj�cych g��boko�� pod ziemi� danej komory (a dok�adnie po�o�enie jej sufitu). G��boko�� przedstawiona w metrach jest liczb� ca�kowit� nale��c� do przedzia�u `<1, 1000>`. W ostatnim wierszu znajduj� si� dwie liczby ca�kowite `i` oraz `j` `(1 <= i<=n, 1<=j<=m)` oznaczaj�ce po�o�enie komory rozb�jnika (`i` - numer wiersza, `j` - numer kolumny).

## Wyj�cie:
Na wyj�ciu ma si� pojawi� liczba ca�kowita oznaczaj�ca ilo�� wody (w $m^3$), kt�rej nap�yni�cie spowoduje utoni�cie rozb�jnika.

## Przyk�ad:
### Wej�cie:

``` c#
4 4	//wymiary wi�zienia
8 8 5 5
9 8 3 3 
2 2 2 2 
2 2 2 2 
1 1
```

### Wyj�cie:
```c#
5
```