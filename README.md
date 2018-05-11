LeetTranslator 0.9

This software can work in two different modes: 
<ul>
	<li>Rename file: you can translate the name of a file</li>
	<li>Translate some text that you can write via command line and save it into a .txt file</li>
</ul>

The first mode use a reduced alphabet because it's impossibile to create a good translation without use some characters that aren't allowed by OS (for example, '/', '|', '\',).

<br/>------------------------------------------<br/>

<h1>Compile command</h1>

If you want to compile the solution, here's the command:
	g++ -o leettranslator main.cpp translator.cpp utility.cpp
	
<br/>------------------------------------------<br/>

<h1>Execution command</h1>
<ul>
	<li>Rename file mode: leettranslator -f file_path file_extension</li>
	<li>Translate text mode: leettranslator -t destination_file</li>
</ul>