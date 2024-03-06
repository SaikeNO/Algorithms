# Programowowanie dynamiczne na przyk�adzie problemu *Rzymscy najemnicy*

Pewien Rzymianin �y� sobie w szcz�ciu i bogactwie. Pewnego dnia sta�o si� nieszcz�cie, gdy� 
jego ukochana zosta�a uprowadzona przez jego zaciek�ych wrog�w. Co mu teraz po samym 
bogactwie, gdy szcz�cia nie ma? A jednak pieni�dze mog� mu pom�c � ma on zamiar wynaj�� 
ca�� dru�yn� najemnych �o�nierzy, kt�rzy pomog� mu odbi� ukochan�.

Sprawa nie jest jednak taka prosta, gdy� rzymscy najemnicy si� wysoko ceni�. Ka�dy z nich ma swoje wymagania w czasie misji. Zgodnie z powiedzeniem �chleba i igrzysk� �o�nierze oczekuj� prowiantu i rozrywek w 
zamian za �wiadczone przez nich us�ugi. Je�li kt�rykolwiek z tych warunk�w nie zostanie 
spe�niony, to najemnik odchodzi w poszukiwaniu lepszego pracodawcy, a nasz Rzymianin dalej 
wzdycha do ukochanej.

Ma on pewien g�rny pr�g na sum� prowiantu i sumaryczn� rozrywk�, jak� 
mo�e zapewni� dla dru�yny najemnej. Ograniczenia wynikaj� zar�wno z bud�etu jak i z logistyki. 
Mieszcz�c si� w tych ograniczeniach nasz bohater chce skompletowa� oddzia� o mo�liwie 
najwi�kszej sile ra�enia. A mo�e Ty pomo�esz mu w tym zadaniu?

## Wej�cie:
W pierwszej linii wej�cia podane s� liczby `P` i `R` `(1<=P, R<=1000)` b�d�ce maksymalnymi ilo�ciami 
prowiantu i rozrywki, kt�re mo�e zapewni� Rzymianin. W drugiej linii podana jest liczba `n`
`(1<=n<=100)` najemnik�w. W kolejnych `n` liniach podane s� liczby `si`, `pi`, `ri` `(0<=si, pi, ri <=100000)` 
oznaczaj�ce odpowiednio: si�� i-go �o�nierza, jego wymagania co do prowiantu oraz rozrywek. 

## Wyj�cie:
W pierwszej linii wyj�cia ma by� podana sumaryczna si�a najmocniejszego oddzia�u le��cego w 
mo�liwo�ciach wynajmu Rzymianina. W kolejnej linii podane s� numery wynaj�tych �o�nierzy 
(numeracja od 1). 

## Przyk�ad:
### Wej�cie:
```cpp
10 8	//Rzymianin mo�e zapewni� 10 jednostek prowiantu i 8 rozrywek
4	//Jest 4 najemnik�w
3 5 2	//Pierwszy z nich ma si�� 3, wymaga 5 prowiantu i 2 rozrywki
4 6 3	//itd.
2 4 6
3 5 9
```
### Wyj�cie:
```cpp
5	//najmocniejszy wynaj�ty oddzia� mo�e mie� si�� 5
1 3	//sk�ada on si� z �o�nierzy nr 1 oraz 3, Rzymianin mo�e sprosta� ich wymaganiom
```