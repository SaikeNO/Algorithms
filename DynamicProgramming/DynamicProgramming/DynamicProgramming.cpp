#include <iostream>
#include <fstream>
#include <stack>

using namespace std;

typedef struct najemnik {
    int sila = 0;
    int prowiant = 0;
    int rozrywka = 0;
} najemnik;

najemnik najemnicy[101];
int tab[101][1001][1001];

int main()
{
    int max_prowiant, max_rozrywka, ilosc_najemnikow;

    ifstream file;
    file.open("duzy.txt");

    if (file.fail())
    {
        cout << "Blad pliku";
        return 0;
    }

    file >> max_prowiant;
    file >> max_rozrywka;
    file >> ilosc_najemnikow;

    for (int i = 1; i <= ilosc_najemnikow; i++)
    {
        najemnik a;
        file >> a.sila;
        file >> a.prowiant;
        file >> a.rozrywka;
        najemnicy[i] = a;
    }

    file.close();

    for (int i = 0; i <= ilosc_najemnikow; i++) {
        for (int j = 0; j <= max_prowiant; j++) {
            for (int k = 0; k <= max_rozrywka; k++) {
                if (i == 0 || j == 0 || k == 0) {
                    tab[i][j][k] = 0;
                }
                else if (j >= najemnicy[i].prowiant && k >= najemnicy[i].rozrywka) {
                    tab[i][j][k] = max(tab[i - 1][j][k], tab[i - 1][j - najemnicy[i].prowiant][k - najemnicy[i].rozrywka] + najemnicy[i].sila);
                }
                else {
                    tab[i][j][k] = tab[i - 1][j][k];
                }
            }
        }
    }

    int i = ilosc_najemnikow;
    int j = max_prowiant;
    int k = max_rozrywka;
    stack<int> stack;

    while (1) {
        if (i == 0 || j == 0 || k == 0) break;

        if (tab[i][j][k] == tab[i - 1][j][k]) {
            i--;
        }
        else {
            stack.push(i);
            j -= najemnicy[i].prowiant;
            k -= najemnicy[i].rozrywka;
            i--;
        }
    }

    cout << tab[ilosc_najemnikow][max_prowiant][max_rozrywka] << endl;
    while (!stack.empty()) {
        cout << stack.top() << " ";
        stack.pop();
    }

    return 0;
}