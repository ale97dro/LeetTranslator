<h1>LeetTranslator 0.9</h1>

This software can work in two different modes: 
<ul>
	<li>Rename file: you can translate the name of a file</li>
	<li>Translate some text that you can write via command line and save it into a .txt file</li>
</ul>

The first mode use a reduced alphabet because it's impossibile to create a good translation without use some characters that aren't allowed by OS (for example, '/', '|', '\',).

<br/>

<h1>GUI Project</h1>

I'm working on this GUI for the project. At this moment, I wrote it in C#-WPF but I think I could be rewrite it in C++.<br/>
The GUI application is less powerfull than the command-line: it doesn't allow you to modify files' name. I think I will implement this possibility in the final version. <br/>
If you want modify the GUI, you can open the project with your version of Visual Studio (I use VS 2017 Community).

![2018-05-21](https://user-images.githubusercontent.com/25732860/40309278-366426ee-5d09-11e8-85f5-3c5598e2f6b8.png)


<br/>

<h1>Compile command</h1>

If you want to compile the solution, here's the command:<br/><br/>
	<b>g++ -o leettranslator main.cpp translator.cpp utility.cpp</b>
	
<br/>

<h1>Execution command</h1>
<ul>
	<li>Rename file mode: leettranslator -f file_path file_extension</li>
	<li>Translate text mode: leettranslator -t destination_file</li>
</ul>

<br/>

<h1>Running issues</h1>

On Windows, you can find some problem when you want to execute this software: if you don't change your variable %PATH to execute C++, the software doesn't run.
Because of this, I add .dll file to the project: you have to copy this file into the software folder and then you have to execute the software normally.
You can find .dll in the MinGW folder of the project.
