# Implementacja drzewa AVL na przyk³adzie s³ownika

Napisaæ program do przechowywania wyrazów w s³owniku. Program ma umo¿liwiaæ szybkie wykonywanie nastêpuj¹cych operacji:

- wstawienie nowego s³owa (co najwy¿ej 30 ma³ych liter angielskich)
- usuniêcie danego s³owa
- wyszukanie w s³owniku zadanego s³owa
- obliczenie liczby s³ów o danym prefiksie
- wyœwietlenie struktury drzewa wraz z elementami
- wykonanie skryptu poleceñ: 
    - W x – wstaw x 
    - U x – usuñ x 
    - S x – szukaj x (odpowiedŸ: TAK/NIE)
    - L x – wypisaæ, ile s³ów zaczyna siê prefiksem x

Przyk³ad:

**Plik wejœciowy:**
``` c#
5           //liczba poleceñ 
W kot       //wstaw s³owo „kot”
W kosa      //wstaw s³owo „kosa”
S kos       //szukaj s³owa „kos”
W kowal     //wstaw s³owo „kowal”
U kot       //usuñ s³owo „kot”
L ko        //ile s³ów o prefiksie „ko”
```

**Plik wyjœciowy:**
```c#
NIE         //s³owa „kos” nie ma w drzewie
2           //2 s³owa zaczynaj¹ siê na „ko”
```