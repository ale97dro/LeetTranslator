<h1>LeetTranslator 0.9</h1>

In this repository you'll find two different version of the Translator: the first is written in C++ and has got only command-line interface, while the second is C# version with also a small GUI.

The Translator use two alphabet:
<ul>
	<li>Light leet: use only symbols and characters allowed by OS</li>
	<li>Complete leet: use all characters and symbols</li>
</ul>


The software can work in two different modes: 
<ul>
	<li>Rename file: you can translate the name of a file</li>
	<li>Translate some text that you can write via command line and save it into a .txt file</li>
</ul>

The first mode use a reduced alphabet because it's impossibile to create a good translation without use some characters that aren't allowed by OS (for example, '/', '|', '\',).

<br/>

<h1>GUI Project</h1>

I'm working on this GUI for the project.<br/>
The GUI application is less powerfull than the command-line: it doesn't allow you to modify files' name in the filesystem. I think I will implement this possibility in the final version. <br/>
If you want modify the GUI, you can open the project with your version of Visual Studio (I use VS 2017 Community).<br/>
You can also lunch only the .exe file in the solution to run the Translator.

![2018-05-21](https://user-images.githubusercontent.com/25732860/40309278-366426ee-5d09-11e8-85f5-3c5598e2f6b8.png)


<br/>

<h1>Command-line versione</h1>

<h2>Compile command</h2>

If you want to compile the solution, here's the command:<br/><br/>
	<b>g++ -o leettranslator main.cpp translator.cpp utility.cpp</b>
	
<br/>

<h2>Execution command</h2>
<ul>
	<li>Rename file mode: leettranslator -f file_path file_extension</li>
	<li>Translate text mode: leettranslator -t destination_file</li>
</ul>

<br/>

<h2>Running issues</h2>

On Windows, you can find some problem when you want to execute this software: if you don't change your variable %PATH to execute C++, the software doesn't run.
Because of this, I add .dll file to the project: you have to copy this file into the software folder and then you have to execute the software normally.
You can find .dll in the MinGW folder of the project.
