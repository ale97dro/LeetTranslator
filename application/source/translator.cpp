#include "translator.h"

Translator::Translator(bool use_lite_alphabet)
{
    for (int i = 0; i < 256; i++) //std alphabet (ASCII 8-bit)
        m_alphabet[i] = i;

    //add custom characters
    if (use_lite_alphabet)
    {
        m_alphabet[65] = m_alphabet[97] = "4";
        m_alphabet[67] = m_alphabet[99] = "[";
        m_alphabet[69] = m_alphabet[101] = "3";
        m_alphabet[71] = m_alphabet[103] = "6";
        m_alphabet[73] = m_alphabet[105] = "1";
        m_alphabet[76] = m_alphabet[108] = "£";
        m_alphabet[79] = m_alphabet[111] = "0";
        m_alphabet[83] = m_alphabet[115] = "$";
        m_alphabet[84] = m_alphabet[116] = "7";
        m_alphabet[85] = m_alphabet[117] = "(_)";
    }
    else
    {
        m_alphabet[65] = m_alphabet[97] = "4"; //A
        m_alphabet[67] = m_alphabet[99] = "["; //B
        m_alphabet[69] = m_alphabet[101] = "3"; //E
        m_alphabet[70] = m_alphabet[102] = "|="; //F
        m_alphabet[71] = m_alphabet[103] = "6"; //G
        m_alphabet[72] = m_alphabet[104] = "[-]"; //H
        m_alphabet[73] = m_alphabet[105] = "1"; //I
        m_alphabet[75] = m_alphabet[107] = "|<"; //K
        m_alphabet[76] = m_alphabet[108] = "£"; //L
        m_alphabet[77] = m_alphabet[109] = "[V]"; //M
        m_alphabet[78] = m_alphabet[110] = "|\\|"; //N
        m_alphabet[79] = m_alphabet[111] = "0"; //O
        m_alphabet[83] = m_alphabet[115] = "$"; //S
        m_alphabet[84] = m_alphabet[116] = "7"; //T
        m_alphabet[85] = m_alphabet[117] = "(_)"; //U
        m_alphabet[87] = m_alphabet[119] = "VV"; //W
        m_alphabet[88] = m_alphabet[120] = "><"; //X
    }
}

Translator::~Translator()
{
}

string Translator::leet(const string & str)
{
    stringstream leet;

    //translation
    for (auto c : str)
        leet << m_alphabet[c];

    return leet.str();
}
