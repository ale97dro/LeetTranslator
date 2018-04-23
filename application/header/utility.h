#pragma once

#ifndef UTILITY_H
#define UTILITY_H

#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <cstddef> 

using namespace std;

class Utility //static class
{

public:
	static vector<string> split(const string& stringa, const char& c);
	static string create_new_path(const vector<string>& source);
	static string file_name_without_extension(const string& file_name);
	

};
#endif // UTILITY_H