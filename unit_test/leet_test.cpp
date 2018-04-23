#include "stdafx.h"
#include "CppUnitTest.h"
#include <iostream>
#include <vector>
#include "../LeetTranslator/translator.h"
#include "../LeetTranslator/utility.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace LeetTranslatorUnitTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(lite_leet_test)
		{
			string hello = "Hello World";
			string result = "H3££0 W0r£d";

			Translator trans{ true };

			Assert::AreEqual(trans.leet(hello), result);
		}

		TEST_METHOD(complete_leet_test)
		{
			string hello = "Hello World";
			string result = "H3££0 W0r£d";

			Translator trans{ false };

			Assert::AreEqual(trans.leet(hello), result);
		}

		TEST_METHOD(split_utility_test)
		{
			string path = "Desktop\\prova\\immagine.harambe.jpg";

			vector<string> vec = Utility::split(path, '\\');
			vector<string>real_vec = { "Desktop","prova","immagine.harambe.jpg" };

			bool result = true;

			for (int i = 0; i < real_vec.size(); i++)
			{
				if (vec[i] != real_vec[i])
					result = false;
			}

			if (static_cast<int>(vec.size() != 3))
				result = false;

			Assert::AreEqual(true, result);
		}

		TEST_METHOD(create_new_path_test)
		{
			vector<string> parts = { "Disk", "Root", "Directory", "SubDirectory", "File" };

			string complete_path = Utility::create_new_path(parts);

			string true_path = "Disk\\Root\\Directory\\SubDirectory\\";

			Assert::AreEqual(complete_path, true_path);
		}

		TEST_METHOD(file_name_without_extension_test)
		{
			string file_name = "file.name.dat"; //.dat is the extension

			string true_file_name = "file.name";

			string file_name_no_ext = Utility::file_name_without_extension(file_name);

			Assert::AreEqual(file_name_no_ext, true_file_name);
		}
	};
}