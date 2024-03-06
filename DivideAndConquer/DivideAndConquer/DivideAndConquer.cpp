#include <iostream>
#include <fstream>

using namespace std;

struct field {
    int deep;
    bool is_visited = false;
};

field arr[200][200];
int size_n, size_m, start_n, start_m;
int water_counter = 1;
int start_level = 0;

void rek(int n, int m)
{
    arr[n][m].is_visited = true;

    for (int offsetN = -1; offsetN <= 1; offsetN++) {
        for (int offsetM = -1; offsetM <= 1; offsetM++) {
            if (
                abs(arr[n + offsetN][m + offsetM].deep - arr[n][m].deep) < 5 &&
                start_level <= arr[n + offsetN][m + offsetM].deep &&
                !arr[n + offsetN][m + offsetM].is_visited &&
                n + offsetN >= 0 &&
                m + offsetM >= 0 &&
                n + offsetN < size_n &&
                m + offsetM < size_m
                )
            {
                if (arr[n + offsetN][m + offsetM].deep - start_level >= 5) {
                    water_counter += 5;
                }
                else {
                    water_counter += arr[n + offsetN][m + offsetM].deep - start_level + 1;
                }

                rek(n + offsetN, m + offsetM);

            }
        }
    }
}

int main()
{
    ifstream file;
    file.open("in3.txt");
    file >> size_n;
    file >> size_m;
    for (int i = 0; i < size_n; i++) {
        for (int j = 0; j < size_m; j++) {
            field a;
            file >> a.deep;
            arr[i][j] = a;
        }
    }

    file >> start_n;
    file >> start_m;
    start_n--;
    start_m--;
    start_level = arr[start_n][start_m].deep;

    file.close();
    rek(start_n, start_m);

    cout << water_counter;

    return 0;
}
