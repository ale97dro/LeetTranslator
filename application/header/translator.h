#ifndef TRANSLATOR_H
#define TRANSLATOR_H

#include <iostream>
#include <string>
#include <sstream>

using namespace std;

class Translator
{
public:
    Translator(bool use_lite_alphabet);
    ~Translator();

    string leet(const string& str);

private:
    string m_alphabet[256];
};

#endif // TRANSLATOR_H
