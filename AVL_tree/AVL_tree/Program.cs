// a) wstawienie nowego słowa (co najwyżej 30 małych liter angielskich)
// b) usunięcie danego słowa
// c) wyszukanie w słowniku zadanego słowa
// d) obliczenie liczby słów o danym prefiksie
// e) wyświetlenie struktury drzewa wraz z elementami
// f) wykonanie skryptu poleceń:
//   1) W x – wstaw x
//   2) U x – usuń x
//   3) S x – szukaj x (odpowiedź: TAK / NIE)
//   4) L x – wypisać, ile słów zaczyna się prefiksem x

class Wezel
{
    public string Slowo;
    public int Wysokosc;
    public int IloscWPoddrzewie;
    public Wezel Lewy;
    public Wezel Prawy;
    public Wezel(string slowo)
    {
        Slowo = slowo;
        Wysokosc = 1;
        IloscWPoddrzewie = 1;
    }
}

class DrzewoAVL
{
    private Wezel korzen;

    public DrzewoAVL(Wezel korzen = null)
    {
        this.korzen = korzen;
    }

    private Wezel RotacjaLL(Wezel wezelA)
    {
        Wezel wezelB = wezelA.Prawy;
        Wezel pom = wezelB.Lewy;

        wezelB.Lewy = wezelA;
        wezelA.Prawy = pom;

        wezelA.Wysokosc = GetNowaWysokosc(wezelA); // najpierw dla wezla A, zeby wezel B mógł wziąc wysokość z wezla A
        wezelA.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezelA);

        wezelB.Wysokosc = GetNowaWysokosc(wezelB);
        wezelB.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezelB);

        return wezelB;
    }

    private Wezel RotacjaRR(Wezel wezelA)
    {
        Wezel wezelB = wezelA.Lewy;
        Wezel pom = wezelB.Prawy;

        wezelB.Prawy = wezelA;
        wezelA.Lewy = pom;

        wezelA.Wysokosc = GetNowaWysokosc(wezelA); // najpierw dla wezla A, zeby wezel B mógł wziąc wysokość z wezla A
        wezelA.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezelA);

        wezelB.Wysokosc = GetNowaWysokosc(wezelB);
        wezelB.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezelB);

        return wezelB;
    }

    private Wezel RotacjaLR(Wezel wezel)
    {
        wezel.Lewy = RotacjaLL(wezel.Lewy);
        return RotacjaRR(wezel);
    }

    private Wezel RotacjaRL(Wezel wezel)
    {
        wezel.Prawy = RotacjaRR(wezel.Prawy);
        return RotacjaLL(wezel);
    }

    private Wezel Rotuj(Wezel wezel)
    {
        int wagaWezla = GetWaga(wezel);
        int wagaLewego = GetWaga(wezel.Lewy);
        int wagaPrawego = GetWaga(wezel.Prawy);

        if (wagaWezla == 2 && (wagaLewego == 1 || wagaLewego == 0))
            return RotacjaRR(wezel);

        if (wagaWezla == 2 && wagaLewego == -1)
            return RotacjaLR(wezel);

        if (wagaWezla == -2 && (wagaPrawego == -1 || wagaPrawego == 0))
            return RotacjaLL(wezel);

        if (wagaWezla == -2 && wagaPrawego == 1)
            return RotacjaRL(wezel);

        return wezel;
    }

    private int GetNowaWysokosc(Wezel wezel)
    {
        int wysokoscLewy = 0;
        int wysokoscPrawy = 0;

        if (wezel.Lewy != null)
        {
            wysokoscLewy = wezel.Lewy.Wysokosc;
        }

        if (wezel.Prawy != null)
        {
            wysokoscPrawy = wezel.Prawy.Wysokosc;
        }

        return Math.Max(wysokoscLewy, wysokoscPrawy) + 1;
    }

    private int GetWaga(Wezel wezel)
    {
        if (wezel == null) return 0;

        int wysokoscLewy = 0;
        int wysokoscPrawy = 0;

        if (wezel.Lewy != null)
        {
            wysokoscLewy = wezel.Lewy.Wysokosc;
        }

        if (wezel.Prawy != null)
        {
            wysokoscPrawy = wezel.Prawy.Wysokosc;
        }

        return wysokoscLewy - wysokoscPrawy;
    }

    private int GetIloscWPoddrzewie(Wezel wezel)
    {
        if (wezel == null) return 0;
        return wezel.IloscWPoddrzewie;
    }

    private int GetNowaIloscWPoddrzewie(Wezel wezel)
    {
        if (wezel == null) return 0;
        return GetIloscWPoddrzewie(wezel.Lewy) + GetIloscWPoddrzewie(wezel.Prawy) + 1;
    }

    private Wezel WstawRekurencyjnie(Wezel wezel, string slowo)
    {
        if (wezel == null) // warunek wyjscia - znalezlismy miejsce - lisc
        {
            return new Wezel(slowo);
        }

        if (Compare(slowo, wezel.Slowo) == 0) // duplikat
        {
            return wezel;
        }

        if (Compare(slowo, wezel.Slowo) < 0)
        {
            wezel.Lewy = WstawRekurencyjnie(wezel.Lewy, slowo);
        }
        else if (Compare(slowo, wezel.Slowo) > 0)
        {
            wezel.Prawy = WstawRekurencyjnie(wezel.Prawy, slowo);
        }

        wezel.Wysokosc = GetNowaWysokosc(wezel); //wracamy z rekurencji i aktualizujemy wysokosci w drodze do korzenia
        wezel.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezel);

        return Rotuj(wezel); // rotujemy jezeli to potrzebne i zwracamy poprawny nowy wezel po rotacji
    }

    private Wezel UsunRekurencyjnie(Wezel wezel, string slowo)
    {
        if (wezel == null) return wezel; // warunek wyjscia jak nie znaleziono slowa

        if (Compare(slowo, wezel.Slowo) < 0)
        {
            wezel.Lewy = UsunRekurencyjnie(wezel.Lewy, slowo);
        }
        else if (Compare(slowo, wezel.Slowo) > 0)
        {
            wezel.Prawy = UsunRekurencyjnie(wezel.Prawy, slowo);
        }
        else // znalezlismy wezel do usuniecia
        {
            if (wezel.Lewy == null && wezel.Prawy == null) // gdy usuwamy lisc
            {
                wezel = null;
                return wezel;
            }
            else if (wezel.Lewy == null || wezel.Prawy == null) // jezeli ma jednego syna
            {
                if (wezel.Lewy == null)
                {
                    wezel = wezel.Prawy;
                }
                else
                {
                    wezel = wezel.Lewy;
                }

                return wezel;
            }
            else // ma dwoch synow
            {
                Wezel nastepnik = wezel.Prawy;

                while (nastepnik.Lewy != null)
                {
                    nastepnik = nastepnik.Lewy;
                }

                wezel.Slowo = nastepnik.Slowo;

                wezel.Prawy = UsunRekurencyjnie(wezel.Prawy, nastepnik.Slowo); // usuwamy rekurencyjnie nastepnika i zmieniamy wysokosci na powrocie od nastepnika
            }
        }

        wezel.Wysokosc = GetNowaWysokosc(wezel);
        wezel.IloscWPoddrzewie = GetNowaIloscWPoddrzewie(wezel);

        return Rotuj(wezel);
    }

    private int ZliczWLewym(Wezel wezel, string prefix, ref int kandydat)
    {
        int count = 0;
        Stack<Wezel> stack = new Stack<Wezel>();
        stack.Push(wezel);

        while (true)
        {
            if (prefix.Length > wezel.Slowo.Length) break;
            if (wezel.Lewy == null && wezel.Prawy == null) break; // lisc

            if (Compare(prefix, wezel.Slowo) < 0)
            {
                if (wezel.Lewy == null) break;
                wezel = wezel.Lewy;
            }
            else
            {
                if (wezel.Prawy == null) break;
                wezel = wezel.Prawy;
            }

            stack.Push(wezel);
        }

        wezel = stack.Pop();
        if (wezel.Slowo.StartsWith(prefix)) kandydat = 1; // dla przypadku jezeli znaleziony wezel nie ma dzieci
        while (stack.Count > 0)
        {
            Wezel rodzic = stack.First();
            if (wezel == rodzic.Lewy)
            {
                count += GetIloscWPoddrzewie(rodzic.Prawy) + 1;
            }

            wezel = stack.Pop();
        }

        return count;
    }

    private int ZliczWPrawym(Wezel wezel, string prefix, ref int kandydat)
    {
        int count = 0;
        Stack<Wezel> stack = new Stack<Wezel>();
        stack.Push(wezel);

        while (true)
        {
            if (prefix.Length > wezel.Slowo.Length) break;
            if (wezel.Lewy == null && wezel.Prawy == null) break;

            if (wezel.Slowo.StartsWith(prefix))
            {
                if (wezel.Prawy == null) break;
                wezel = wezel.Prawy;
            }
            else if (Compare(prefix, wezel.Slowo) < 0)
            {
                if (wezel.Lewy == null) break;
                wezel = wezel.Lewy;
            }
            else
            {
                if (wezel.Prawy == null) break;
                wezel = wezel.Prawy;
            }
            stack.Push(wezel);
        }


        wezel = stack.Pop();
        if (wezel.Slowo.StartsWith(prefix)) kandydat = 1;
        while (stack.Count > 0)
        {
            Wezel rodzic = stack.First();
            if (wezel == rodzic.Prawy)
            {
                count += GetIloscWPoddrzewie(rodzic.Lewy) + 1;

            }

            wezel = stack.Pop();
        }

        return count;
    }

    private int ZliczSlowaZPrefixemRekurencyjnie(Wezel wezel, string prefix) // do poprawy
    {
        if (wezel == null) return 0;

        int count = 0;
        int prawyMaximum = 0;
        int lewyMinimum = 0;

        if (wezel.Slowo.StartsWith(prefix))
        {
            count = 1; // jako korzen do wyszukania dalej
            if (wezel.Lewy != null)
            {
                count += ZliczWLewym(wezel.Lewy, prefix, ref lewyMinimum);
            }

            // prawe poddrzewo
            if (wezel.Prawy != null && wezel.Prawy.Slowo.Length > prefix.Length)
            {
                count += ZliczWPrawym(wezel.Prawy, prefix, ref prawyMaximum);
            }

        }
        else if (Compare(prefix, wezel.Slowo) < 0)
        {
            return ZliczSlowaZPrefixemRekurencyjnie(wezel.Lewy, prefix);
        }
        else if (Compare(prefix, wezel.Slowo) > 0)
        {
            return ZliczSlowaZPrefixemRekurencyjnie(wezel.Prawy, prefix);
        }

        return count + prawyMaximum + lewyMinimum;

    }

    public void Wstaw(string slowo)
    {
        if (!CzyPoprawnyString(slowo)) return;
        korzen = WstawRekurencyjnie(korzen, slowo); // podstawiamy nowy korzen jezeli sie zmieni
    }

    public void Usun(string slowo)
    {
        if (!CzyPoprawnyString(slowo)) return;
        korzen = UsunRekurencyjnie(korzen, slowo);
    }

    public void ZliczSlowaZPrefixem(string prefix)
    {
        if (!CzyPoprawnyString(prefix)) return;
        Console.WriteLine(ZliczSlowaZPrefixemRekurencyjnie(korzen, prefix));
    }

    public void Wyszukaj(string slowo)
    {
        if (SzukajWezel(slowo) != null)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }
    }

    private Wezel SzukajWezel(string slowo)
    {
        if (!CzyPoprawnyString(slowo)) return null;

        Wezel wezel = korzen;
        while (wezel != null && Compare(slowo, wezel.Slowo) != 0)
        {
            if (Compare(slowo, wezel.Slowo) > 0)
            {
                wezel = wezel.Prawy;
            }
            else
            {
                wezel = wezel.Lewy;
            }
        }

        return wezel;
    }

    private bool CzyPoprawnyString(string str)
    {
        return str.Length < 30 && str.Length > 0;
    }

    private void WypiszRekurencyjnie(Wezel wezel, int poziom = 0)
    {
        if (wezel == null)
        {
            WypiszTabulacje(poziom);
            Console.Write("NULL\n");
        }
        else
        {
            WypiszRekurencyjnie(wezel.Prawy, poziom + 1);
            WypiszTabulacje(poziom);
            Console.Write($"{wezel.Slowo}: {wezel.Wysokosc}\n");
            WypiszRekurencyjnie(wezel.Lewy, poziom + 1);
        }
    }

    public void Wypisz()
    {
        WypiszRekurencyjnie(korzen);
    }

    public void WykonajSkrypt(string sciezka)
    {
        using (StreamReader plik = new StreamReader(sciezka))
        {
            var n = int.Parse(plik.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var key = plik.Read();
                var slowo = plik.ReadLine().Trim();

                switch (key)
                {
                    case 'W':
                        Wstaw(slowo);
                        break;
                    case 'U':
                        Usun(slowo);
                        break;
                    case 'S':
                        Wyszukaj(slowo);
                        break;
                    case 'L':
                        ZliczSlowaZPrefixem(slowo);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void WypiszTabulacje(int ilosc)
    {
        for (int i = 0; i < ilosc; i++) Console.Write("   ");
    }

    virtual public int Compare(string s1, string s2)
    {
        return string.Compare(s1, s2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var drzewo = new DrzewoAVL();

        while (true)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Wstaw słowo");
            Console.WriteLine("2. Usuń słowo");
            Console.WriteLine("3. Wyszukaj słowo");
            Console.WriteLine("4. Oblicz ile słow o prefixie");
            Console.WriteLine("5. Wyświetl drzewo");
            Console.WriteLine("6. Wykonaj skrypt");
            Console.WriteLine("0. Wyjdź");
            Console.WriteLine("-----------------------------");

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D0) break;

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("Podaj słowo do dodania> ");
                        var slowo = Console.ReadLine();
                        drzewo.Wstaw(slowo);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Write("Podaj słowo do usuniecia> ");
                        var slowo = Console.ReadLine();
                        drzewo.Usun(slowo);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Console.Write("Podaj słowo do wyszukania> ");
                        var slowo = Console.ReadLine();
                        drzewo.Wyszukaj(slowo);
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        Console.Write("Podaj prefix do zliczenia> ");
                        var prefix = Console.ReadLine();
                        drzewo.ZliczSlowaZPrefixem(prefix);
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        drzewo.Wypisz();
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        Console.Write("Podaj ścieżke do skryptu> ");
                        var sciezka = Console.ReadLine();
                        drzewo.WykonajSkrypt(sciezka);

                        break;
                    }
            }
        }
    }
}

