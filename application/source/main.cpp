#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <cstddef>
#include <fstream>
#include <stdio.h>
#include "utility.h"
#include "translator.h"

using namespace std;

bool parameters_validation(int argc, char* argv[]);
int choose_mode(const string mode);
void leet_file(char* argv[]);
void leet_text(char* argv[]);

int main(int argc, char *argv[])
{
    /*
        DA AGGIUNGERE:
        implementare le diverse modalità
        implementare traduzione sfruttando un vettore con gli indici
        controllare prima se il file esiste e usare eccezioni
    */

    /*
        Stringa per linea di comando
        -f C:\Users\alex2_000\Desktop\prova\immagine.harambe.jpg jpg
        -t C:\Users\alex2_000\Desktop\prova\testo
    */

    if (!parameters_validation(argc, argv))
        return 0;

    switch (choose_mode(argv[1]))
    {
        case 1:
            leet_file(argv);
            break;
        case 2:
            leet_text(argv);
            break;
    }

    return 0;
}

bool parameters_validation(int argc, char* argv[])
{
    if ((argc == 4) || (argc == 3))
        return true;

    return false;
}

int choose_mode(const string mode)
{
    if (mode == "-f")
        return 1;
    else
        if (mode == "-t")
            return 2;

    return 0;
}

void leet_file(char* argv[])
{
    string mode = argv[1];
    string path = argv[2];
    string extension = argv[3];

    vector<string>splitted_string{ Utility::split(path, '\\') };

    Translator trans{ true };
    string leet_name{ trans.leet(splitted_string[splitted_string.size() - 1]) }; //convert into leet
    string file_name_no_ext{ Utility::file_name_without_extension(leet_name) }; //add the right extension

    string new_path{ Utility::create_new_path(splitted_string) }; //ricreate the path
    string new_name{ new_path + file_name_no_ext + "." + extension }; //new path+name+extension

    rename(path.c_str(), new_name.c_str()); //rename the original file
}

void leet_text(char* argv[])
{
    string text;
    cout << "Insert your text: ";
    getline(cin, text);

    Translator trans{ false };
    string leet_text{ trans.leet(text) };

    string txt_path{ argv[2] };
    txt_path += ".txt";

    //save on file the conversion
    ofstream outf;
    outf.open(txt_path.c_str());
    outf << leet_text;
    outf.close();
}
