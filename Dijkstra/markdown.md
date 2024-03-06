# Algorytm Dijkstry na przyk³adzie problemu *Koleji*

W pewnym postêpowym kraju od stuleci rozwija siê transport kolejowy. Pocz¹tkowo po³¹czenia kolejowe obejmowa³y tylko najwiêksze i najszybciej rozwijaj¹ce siê miasta, a prêdkoœæ poci¹gów pozostawia³a wiele do ¿yczenia. Wed³ug opowieœci starszych mo¿na by³o wyskoczyæ na grzyby, gdy poci¹g przeje¿d¿a³ przez las, by po grzybobraniu za³apaæ siê jeszcze do ostatniego wagonu. Z czasem prêdkoœci poci¹gów ros³y, by w koñcu doprowadziæ do likwidacji konwencjonalnych przejazdów kolejowych (ze wzglêdów bezpieczeñstwa). Zmieni³ siê te¿ wygl¹d poci¹gów – pocz¹tkowo przypomina³y fabryki z kominem, a obecnie bli¿ej im do filmów SF. W kraju tym nie toleruje siê obni¿enia prêdkoœci poci¹gów i po modernizacji danego odcinka œrednia prêdkoœæ na nim mo¿e jedynie wzrosn¹æ. Co wiêcej, postój na ka¿dej stacji wynosi 5 minut i nigdy nie ma opóŸnieñ, a z ¿adnego miasta nie wychodzi wiêcej ni¿ 50 po³¹czeñ. W bazie danych kolei istnieje ca³e archiwum dotycz¹ce budowy i modernizacji odcinków ³¹cz¹cych poszczególne miasta. Zlecono napisanie oprogramowania do analizy tych danych. Twoim zadaniem jest ustalenie, kiedy czas przejazdu poci¹giem miêdzy zadan¹ par¹ miast skróci³ siê do zadanego poziomu.

## Wejœcie:
W pierwszej linii wejœcia podane s¹ trzy liczby ca³kowite `n`, `m` i `z` `(1<=n<=10000,1<=m<=100000, 1<=z<=10)` oznaczaj¹ce odpowiednio liczbê miast, liczbê budowanych/modernizowanych odcinków oraz liczbê zapytañ do programu. W kolejnych m liniach znajduj¹ siê chronologiczne informacje dotycz¹ce budowy. W ka¿dej z tych linii podane s¹: data (format `rrrr-mm-dd`), nastêpnie znak `'m'` lub `'b'` w zale¿noœci od tego czy chodzi o budowê (po³¹czenie wczeœniej nie istnia³o) czy o modernizacjê istniej¹cego ju¿ odcinka, nastêpnie para ró¿nych miast `m1`, `m2` `(1<=m1, m2<=n)` miêdzy którymi budowane/modernizowane jest po³¹czenie, a nastêpnie œredni¹ prêdkoœæ `v` (w km/h) na tym odcinku `(1<=v<=500)` oraz (w przypadku budowy) równie¿ d³ugoœæ `d` (w km) nowo wybudowanego po³¹czenia `(1<=d<=1000)`. `v` i `d` s¹ liczbami ca³kowitymi i `60*d mod v = 0`. W kolejnych z liniach znajduj¹ siê zapytania z³o¿one z liczb `m1`, `m2`, `c` `(1<=m1, m2<=n, 1<=c<=10000)` oznaczaj¹cych parê miast oraz maks. czas po³¹czenia miêdzy nimi (w minutach). 

## Wyjœcie:
W z liniach wyjœcia nale¿y odpowiedzieæ na zapytania: kiedy po raz pierwszy uda³o siê osi¹gn¹æ czas najszybszego po³¹czenia (poœredniego lub bezpoœredniego) miêdzy danymi miastami nie przekraczaj¹cy zadanego limitu. Jeœli taki czas nie zosta³ dot¹d osi¹gniêty, nale¿y wypisaæ `'NIE'`.

## Przyk³ad:
### Wejœcie:

``` c#
5 10 3			//5 miast, 10 po³¹czeñ, 3 zapytania
1900-05-30 b 1 2 30 60	//budowane po³¹czenie miêdzy miastami 1 i 2, v=30 km/h, d=60 km
1900-07-15 b 2 5 40 120	//itd.
1905-04-19 b 1 4 35 70
1910-06-03 b 4 5 50 100
1950-10-25 m 2 5 72	//modernizowane po³¹czenie miêdzy miastami 2 i 5: nowe v=72 km/h
1955-01-31 b 1 3 60 90
1990-12-12 b 3 5 180 90
2000-09-20 b 3 4 240 60
2005-06-14 m 1 4 280	//itd.
2008-03-07 b 2 3 150 50
1 5 230			//Kiedy pomiêdzy miastami 1 i 5 osi¹gniêto czas podró¿y maks. 230 minut
1 5 75			//itd.
2 4 35
```

**Plik wyjœciowy:**
```c#
1950-10-25	//od 1950-10-25 miêdzy miastami 1 i 5 da³o siê przejechaæ w 225 minut (<=230)
2005-06-14	//od 2005-06-14 miêdzy miastami 1 i 5 da³o siê przejechaæ w 70 minut (<=75)
NIE		//najszybsze po³¹czenie miêdzy 2 i 4 wymaga obecnie 40 minut
```