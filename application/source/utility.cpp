#include "utility.h"

//Source: http://www.cplusplus.com/articles/2wA0RXSz/
vector<string> Utility::split(const string& stringa, const char& c)
{
	string buff{ "" };
	vector<string>v;

	for (auto n : stringa)
	{
		if (n != c)
			buff += n;
		if ((n == c) && (buff != ""))
		{
			v.push_back(buff);
			buff = "";
		}
	}

	if (buff != "")
		v.push_back(buff);

	return v;
}

string Utility::create_new_path(const vector<string>& source)
{
	stringstream path;

	for (int i = 0; i < source.size() - 1; i++)
		path << source[i] + "\\";

	return path.str();
}

string Utility::file_name_without_extension(const string& file_name)
{
	string new_name;

	size_t size = file_name.find_last_of('.');
	new_name = file_name.substr(0, size);

	return new_name;
}