# Implementacja drzewa AVL na przykładzie słownika

Napisać program do przechowywania wyrazów w słowniku. Program ma umożliwiać szybkie wykonywanie następujących operacji:

- wstawienie nowego słowa (co najwyżej 30 małych liter angielskich)
- usunięcie danego słowa
- wyszukanie w słowniku zadanego słowa
- obliczenie liczby słów o danym prefiksie
- wyświetlenie struktury drzewa wraz z elementami
- wykonanie skryptu poleceń: 
    - W x – wstaw x 
    - U x – usuń x 
    - S x – szukaj x (odpowiedź: TAK/NIE)
    - L x – wypisać, ile słów zaczyna się prefiksem x

## Przykład:
### Wejście:
``` c#
5           //liczba poleceń 
W kot       //wstaw słowo „kot”
W kosa      //wstaw słowo „kosa”
S kos       //szukaj słowa „kos”
W kowal     //wstaw słowo „kowal”
U kot       //usuń słowo „kot”
L ko        //ile słów o prefiksie „ko”
```

### Wyjście:
```c#
NIE         //słowa „kos” nie ma w drzewie
2           //2 słowa zaczynają się na „ko”
```
