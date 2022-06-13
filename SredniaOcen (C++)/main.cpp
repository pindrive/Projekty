#include <iostream>
#include <string>

using namespace std;

struct uczniowie
    {
        string nazwisko;
        string imie;
        string plec;
        int ocena_z_matematyki;
        int ocena_z_polskiego;
    };

int main()
{
    /* WPROWADZENIE DANYCH */

    uczniowie u1 =
    {
        "Kowalski",
        "Jan",
        "Mezczyzna",
        6,
        3
    };

    uczniowie u2 =
    {
        "Kapron",
        "Lukasz",
        "Mezczyzna",
        2,
        1
    };

    uczniowie u3 =
    {
        "Perzynski",
        "Wojciech",
        "Mezczyzna",
        6,
        6
    };

    uczniowie u4 =
    {
        "Repec",
        "Magdalena",
        "Kobieta",
        4,
        4
    };

    uczniowie u5 =
    {
        "Kowalska",
        "Malwina",
        "Kobieta",
        6,
        1
    };

    /* WYPISANIE DANYCH */

    cout << u1.imie << ", " << u1.nazwisko << ", " << u1.plec << ", " << u1.ocena_z_matematyki << ", " << u1.ocena_z_polskiego << endl;

    cout << u2.imie << ", " << u2.nazwisko << ", " << u2.plec << ", " << u2.ocena_z_matematyki << ", " << u2.ocena_z_polskiego << endl;

    cout << u3.imie << ", " << u3.nazwisko << ", " << u3.plec << ", " << u3.ocena_z_matematyki << ", " << u3.ocena_z_polskiego << endl;

    cout << u4.imie << ", " << u4.nazwisko << ", " << u4.plec << ", " << u4.ocena_z_matematyki << ", " << u4.ocena_z_polskiego << endl;

    cout << u5.imie << ", " << u5.nazwisko << ", " << u5.plec << ", " << u5.ocena_z_matematyki << ", " << u5.ocena_z_polskiego << endl << endl;

    /* NAZWISKO NA K */

    cout << "Osoby z nazwiskiem rozpoczynajacym sie na litere 'K': " << endl;

    if (u1.nazwisko[0] == 'K')
    {
        cout << u1.imie << " " << u1.nazwisko << endl;
    }

    if (u2.nazwisko[0] == 'K')
    {
        cout << u2.imie << " " << u2.nazwisko << endl;
    }

    if (u3.nazwisko[0] == 'K')
    {
        cout << u3.imie << " " << u3.nazwisko << endl;
    }

    if (u4.nazwisko[0] == 'K')
    {
        cout << u4.imie << " " << u4.nazwisko << endl;
    }

    if (u5.nazwisko[0] == 'K')
    {
        cout << u5.imie << " " << u5.nazwisko << endl << endl;
    }

    /* SREDNIA OCEN Z MATEMATYKI */

    float srednia = 0;
    float suma = (int)u1.ocena_z_matematyki + (int)u2.ocena_z_matematyki + (int)u3.ocena_z_matematyki + (int)u4.ocena_z_matematyki + (int)u5.ocena_z_matematyki;

    srednia = suma / 5;

    cout << "Srednia ocen z matematyki wynosi: " << srednia << endl;

    return 0;
}
