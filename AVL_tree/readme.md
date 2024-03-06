# Implementacja drzewa AVL na przyk�adzie s�ownika

Napisa� program do przechowywania wyraz�w w s�owniku. Program ma umo�liwia� szybkie wykonywanie nast�puj�cych operacji:

- wstawienie nowego s�owa (co najwy�ej 30 ma�ych liter angielskich)
- usuni�cie danego s�owa
- wyszukanie w s�owniku zadanego s�owa
- obliczenie liczby s��w o danym prefiksie
- wy�wietlenie struktury drzewa wraz z elementami
- wykonanie skryptu polece�: 
    - W x � wstaw x 
    - U x � usu� x 
    - S x � szukaj x (odpowied�: TAK/NIE)
    - L x � wypisa�, ile s��w zaczyna si� prefiksem x

Przyk�ad:

**Plik wej�ciowy:**
``` c#
5           //liczba polece� 
W kot       //wstaw s�owo �kot�
W kosa      //wstaw s�owo �kosa�
S kos       //szukaj s�owa �kos�
W kowal     //wstaw s�owo �kowal�
U kot       //usu� s�owo �kot�
L ko        //ile s��w o prefiksie �ko�
```

**Plik wyj�ciowy:**
```c#
NIE         //s�owa �kos� nie ma w drzewie
2           //2 s�owa zaczynaj� si� na �ko�
```