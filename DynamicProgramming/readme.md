# Programowowanie dynamiczne na przyk³adzie problemu *Rzymscy najemnicy*

Pewien Rzymianin ¿y³ sobie w szczêœciu i bogactwie. Pewnego dnia sta³o siê nieszczêœcie, gdy¿ 
jego ukochana zosta³a uprowadzona przez jego zaciek³ych wrogów. Co mu teraz po samym 
bogactwie, gdy szczêœcia nie ma? A jednak pieni¹dze mog¹ mu pomóc – ma on zamiar wynaj¹æ 
ca³¹ dru¿ynê najemnych ¿o³nierzy, którzy pomog¹ mu odbiæ ukochan¹.

Sprawa nie jest jednak taka prosta, gdy¿ rzymscy najemnicy siê wysoko ceni¹. Ka¿dy z nich ma swoje wymagania w czasie misji. Zgodnie z powiedzeniem „chleba i igrzysk” ¿o³nierze oczekuj¹ prowiantu i rozrywek w 
zamian za œwiadczone przez nich us³ugi. Jeœli którykolwiek z tych warunków nie zostanie 
spe³niony, to najemnik odchodzi w poszukiwaniu lepszego pracodawcy, a nasz Rzymianin dalej 
wzdycha do ukochanej.

Ma on pewien górny próg na sumê prowiantu i sumaryczn¹ rozrywkê, jak¹ 
mo¿e zapewniæ dla dru¿yny najemnej. Ograniczenia wynikaj¹ zarówno z bud¿etu jak i z logistyki. 
Mieszcz¹c siê w tych ograniczeniach nasz bohater chce skompletowaæ oddzia³ o mo¿liwie 
najwiêkszej sile ra¿enia. A mo¿e Ty pomo¿esz mu w tym zadaniu?

## Wejœcie:
W pierwszej linii wejœcia podane s¹ liczby `P` i `R` `(1<=P, R<=1000)` bêd¹ce maksymalnymi iloœciami 
prowiantu i rozrywki, które mo¿e zapewniæ Rzymianin. W drugiej linii podana jest liczba `n`
`(1<=n<=100)` najemników. W kolejnych `n` liniach podane s¹ liczby `si`, `pi`, `ri` `(0<=si, pi, ri <=100000)` 
oznaczaj¹ce odpowiednio: si³ê i-go ¿o³nierza, jego wymagania co do prowiantu oraz rozrywek. 

## Wyjœcie:
W pierwszej linii wyjœcia ma byæ podana sumaryczna si³a najmocniejszego oddzia³u le¿¹cego w 
mo¿liwoœciach wynajmu Rzymianina. W kolejnej linii podane s¹ numery wynajêtych ¿o³nierzy 
(numeracja od 1). 

## Przyk³ad:
### Wejœcie:
```cpp
10 8	//Rzymianin mo¿e zapewniæ 10 jednostek prowiantu i 8 rozrywek
4	//Jest 4 najemników
3 5 2	//Pierwszy z nich ma si³ê 3, wymaga 5 prowiantu i 2 rozrywki
4 6 3	//itd.
2 4 6
3 5 9
```
### Wyjœcie:
```cpp
5	//najmocniejszy wynajêty oddzia³ mo¿e mieæ si³ê 5
1 3	//sk³ada on siê z ¿o³nierzy nr 1 oraz 3, Rzymianin mo¿e sprostaæ ich wymaganiom
```