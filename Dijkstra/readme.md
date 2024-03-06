# Algorytm Dijkstry na przyk�adzie problemu *Koleji*

W pewnym post�powym kraju od stuleci rozwija si� transport kolejowy. Pocz�tkowo po��czenia kolejowe obejmowa�y tylko najwi�ksze i najszybciej rozwijaj�ce si� miasta, a pr�dko�� poci�g�w pozostawia�a wiele do �yczenia. Wed�ug opowie�ci starszych mo�na by�o wyskoczy� na grzyby, gdy poci�g przeje�d�a� przez las, by po grzybobraniu za�apa� si� jeszcze do ostatniego wagonu. Z czasem pr�dko�ci poci�g�w ros�y, by w ko�cu doprowadzi� do likwidacji konwencjonalnych przejazd�w kolejowych (ze wzgl�d�w bezpiecze�stwa). Zmieni� si� te� wygl�d poci�g�w � pocz�tkowo przypomina�y fabryki z kominem, a obecnie bli�ej im do film�w SF. W kraju tym nie toleruje si� obni�enia pr�dko�ci poci�g�w i po modernizacji danego odcinka �rednia pr�dko�� na nim mo�e jedynie wzrosn��. Co wi�cej, post�j na ka�dej stacji wynosi 5 minut i nigdy nie ma op�nie�, a z �adnego miasta nie wychodzi wi�cej ni� 50 po��cze�. W bazie danych kolei istnieje ca�e archiwum dotycz�ce budowy i modernizacji odcink�w ��cz�cych poszczeg�lne miasta. Zlecono napisanie oprogramowania do analizy tych danych. Twoim zadaniem jest ustalenie, kiedy czas przejazdu poci�giem mi�dzy zadan� par� miast skr�ci� si� do zadanego poziomu.

## Wej�cie:
W pierwszej linii wej�cia podane s� trzy liczby ca�kowite `n`, `m` i `z` `(1<=n<=10000,1<=m<=100000, 1<=z<=10)` oznaczaj�ce odpowiednio liczb� miast, liczb� budowanych/modernizowanych odcink�w oraz liczb� zapyta� do programu. W kolejnych m liniach znajduj� si� chronologiczne informacje dotycz�ce budowy. W ka�dej z tych linii podane s�: data (format `rrrr-mm-dd`), nast�pnie znak `'m'` lub `'b'` w zale�no�ci od tego czy chodzi o budow� (po��czenie wcze�niej nie istnia�o) czy o modernizacj� istniej�cego ju� odcinka, nast�pnie para r�nych miast `m1`, `m2` `(1<=m1, m2<=n)` mi�dzy kt�rymi budowane/modernizowane jest po��czenie, a nast�pnie �redni� pr�dko�� `v` (w km/h) na tym odcinku `(1<=v<=500)` oraz (w przypadku budowy) r�wnie� d�ugo�� `d` (w km) nowo wybudowanego po��czenia `(1<=d<=1000)`. `v` i `d` s� liczbami ca�kowitymi i `60*d mod v = 0`. W kolejnych z liniach znajduj� si� zapytania z�o�one z liczb `m1`, `m2`, `c` `(1<=m1, m2<=n, 1<=c<=10000)` oznaczaj�cych par� miast oraz maks. czas po��czenia mi�dzy nimi (w minutach). 

## Wyj�cie:
W z liniach wyj�cia nale�y odpowiedzie� na zapytania: kiedy po raz pierwszy uda�o si� osi�gn�� czas najszybszego po��czenia (po�redniego lub bezpo�redniego) mi�dzy danymi miastami nie przekraczaj�cy zadanego limitu. Je�li taki czas nie zosta� dot�d osi�gni�ty, nale�y wypisa� `'NIE'`.

## Przyk�ad:
### Wej�cie:

``` c#
5 10 3			//5 miast, 10 po��cze�, 3 zapytania
1900-05-30 b 1 2 30 60	//budowane po��czenie mi�dzy miastami 1 i 2, v=30 km/h, d=60 km
1900-07-15 b 2 5 40 120	//itd.
1905-04-19 b 1 4 35 70
1910-06-03 b 4 5 50 100
1950-10-25 m 2 5 72	//modernizowane po��czenie mi�dzy miastami 2 i 5: nowe v=72 km/h
1955-01-31 b 1 3 60 90
1990-12-12 b 3 5 180 90
2000-09-20 b 3 4 240 60
2005-06-14 m 1 4 280	//itd.
2008-03-07 b 2 3 150 50
1 5 230			//Kiedy pomi�dzy miastami 1 i 5 osi�gni�to czas podr�y maks. 230 minut
1 5 75			//itd.
2 4 35
```

**Plik wyj�ciowy:**
```c#
1950-10-25	//od 1950-10-25 mi�dzy miastami 1 i 5 da�o si� przejecha� w 225 minut (<=230)
2005-06-14	//od 2005-06-14 mi�dzy miastami 1 i 5 da�o si� przejecha� w 70 minut (<=75)
NIE		//najszybsze po��czenie mi�dzy 2 i 4 wymaga obecnie 40 minut
```